using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UGCore {
    //public class UserRecord {
    //    public string user { get; set; }
    //    public List<SerialRecord> SerialRecords { get; set; }
    //}
    public class UserRecord {
        public string user { get; set; }
        public SerialRecord serialRecord { get; set; }
    }
    public class SerialRecord {
        public string publicKey { get; set; }
        public string serial { get; set; }
    }
    /*
     //Create two classes to represent UserRecord and SerialRecord.

        Populate them like this:

         var userRecord = new UserRecord 
         { 
             user = "UserName1", 
             SerialRecord = new List<SerialRecord> {
                new SerialRecord { publicKey = "Alias1", serial = "12345678" }, 
                new SerialRecord { publicKey = "Alias2", serial = "23456789" }
             }
         };
         Example usage:

        var result = XmlHelper.ToXml(userRecord);
        And use this code to serialize/deserialize it:

        <UserRecord>
            <user>Username1</user>
            <SerialRecords>
                <SerialRecord>
                    <publicKey>Alias1</publicKey>
                    <serial>12345678</serial>
                </SerialRecord>
                <SerialRecord>
                    <publicKey>Alias2</publicKey>
                    <serial>23456789</serial>
                </SerialRecord>
            </SerialRecords>
        </UserRecord>


    */
    public static class XmlHelper {

        public static bool NewLineOnAttributes { get; set; }
        /// <summary>
        /// Serializes an object to an XML string, using the specified namespaces.
        /// </summary>
        public static string ToXml(object obj, XmlSerializerNamespaces ns) {
            Type T = obj.GetType();

            var xs = new XmlSerializer(T);
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = NewLineOnAttributes, OmitXmlDeclaration = true };

            var sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb, ws)) {
                xs.Serialize(writer, obj, ns);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Serializes an object to an XML string.
        /// </summary>
        public static string ToXml(object obj) {
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            return ToXml(obj, ns);
        }

        /// <summary>
        /// Deserializes an object from an XML string.
        /// </summary>
        public static T FromXml<T>(string xml) {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(xml)) {
                return (T)xs.Deserialize(sr);
            }
        }

        /// <summary>
        /// Deserializes an object from an XML string, using the specified type name.
        /// </summary>
        public static object FromXml(string xml, string typeName) {
            Type T = Type.GetType(typeName);
            XmlSerializer xs = new XmlSerializer(T);
            using (StringReader sr = new StringReader(xml)) {
                return xs.Deserialize(sr);
            }
        }


        /// <summary>
        /// Serializes an object to an XML file.
        /// </summary>
        public static void ToXmlFile(Object obj, string filePath) {
            var xs = new XmlSerializer(obj.GetType());
            var ns = new XmlSerializerNamespaces();
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = NewLineOnAttributes, OmitXmlDeclaration = true };
            ns.Add("", "");

            using (XmlWriter writer = XmlWriter.Create(filePath, ws)) {
                xs.Serialize(writer, obj);
            }
        }

        /// <summary>
        /// Deserializes an object from an XML file.
        /// </summary>
        public static T FromXmlFile<T>(string filePath) {
            StreamReader sr = new StreamReader(filePath);
            try {
                var result = FromXml<T>(sr.ReadToEnd());
                return result;
            }
            catch (Exception e) {
                throw new Exception("There was an error attempting to read the file " + filePath + "\n\n" + e.InnerException.Message);
            }
            finally {
                sr.Close();
            }
        }


    }
}
