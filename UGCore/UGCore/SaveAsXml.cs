using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UGCore {
    public static class SaveAsXML {
        public static void WriteObject<T>(T outputObject, string outputFile) {
            try {
                using (FileStream writer = new FileStream(outputFile, FileMode.Create)) {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, outputObject);
                }
            }
            catch (Exception) {}
            
        }

        public static T ReadObject<T>(string objectData) {
            T deserializedObject = default(T);
            using (StringReader reader = new StringReader(objectData)) {
                XmlTextReader xmlReader = new XmlTextReader(reader);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                deserializedObject = (T)ser.Deserialize(xmlReader);
                xmlReader.Close();
            }                
            return deserializedObject;
        }
    }
}
