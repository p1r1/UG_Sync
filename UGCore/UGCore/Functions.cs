using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    /// <summary>
    /// increase timeout
    /// </summary>
    public class MyWebClient : WebClient {
        protected override WebRequest GetWebRequest(Uri uri) {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = 3 * 60 * 1000;
            return w;
        }
    }

    public struct SqlPair {
        public string colName_;
        public object value_;
        public int colSize_ { get; set; }
        public SqlDbType colType_ { get; set; }
        public SqlPair(string ColName, object Value, SqlDbType ColType = SqlDbType.VarChar, int ColSize = 0) : this() {
            this.colName_ = ColName;
            this.value_ = Value;
            this.colType_ = ColType;
            this.colSize_ = ColSize;
        }
    }

    public class ConnStringObj {
        public string ms_sql { get; set; }
        public string my_sql { get; set; }
    }
    public class XmlObj {
        public string earchive { get; set; }
        public string einvoice { get; set; }
    }

    public static class Functions {
        public const int COMMAND_TIMEOUT = 180; //sec
        public static XmlObj GetXmlFileLocation(string filePath = @"D:\Projects\Config\ConnStrings.json") {
            try {
                var fileText = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(fileText)) {
                    return null;
                }
                var xmlObj = JsonConvert.DeserializeObject<XmlObj>(fileText);
                if (ReferenceEquals(null, xmlObj)) {
                    return null;
                }

                return xmlObj;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return null;
            }
        }
        private static ConnStringObj GetLoginObj(string filePath = @"D:\Projects\Config\ConnStrings.json") {
            try {
                var fileText = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(fileText)) {
                    return null;
                }
                var loginObj = JsonConvert.DeserializeObject<ConnStringObj>(fileText);
                if (ReferenceEquals(null, loginObj)) {
                    return null;
                }

                return loginObj;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return null;
            }
        }

        public static string GetConnString(string which) {
            if (which == "ms_sql") {
                return GetLoginObj().ms_sql;
            }
            else if (which == "my_sql") {
                return GetLoginObj().my_sql;
            }
            else {
                Console.WriteLine("wrong call");
                return null;
            }
        }

        public struct SqlObj {
            private string _colName;
            private string _value;
            private bool _isString;
            //private bool _isDecimal;

            public string colNameGetSet { get { return _colName; } set { _colName = value; } }
            public string valueGetSet { get { return _value; } set { _value = value; } }
            public bool isStringGetSet { get { return _isString; } set { _isString = value; } }
            //public bool isDecimalGetSet { get { return _isDecimal; } set { _isDecimal = value; } }
            public SqlObj(string colName, string value, bool isString = true) {
                _colName = colName;
                _value = value;
                _isString = isString;
                //_isDecimal = isDecimal;
            }
        }

        public struct SqlObj2 {
            public string _colName { get; set; }
            public dynamic _value { get; set; }
            public int _datLength { get; set; }
            public SqlDbType _sqlDbType { get; set; }
            public SqlObj2(string colName, dynamic value, int datLength = 0, string dbType = "VarChar") {
                _colName = colName;
                _value = value;
                _datLength = datLength;

                switch (dbType) {
                    case "VarChar":
                        _sqlDbType = SqlDbType.VarChar;
                        break;
                    case "Int":
                        _sqlDbType = SqlDbType.Int;
                        break;
                    case "DateTime":
                        _sqlDbType = SqlDbType.DateTime;
                        break;
                    case "NVarChar":
                        _sqlDbType = SqlDbType.NVarChar;
                        break;
                    case "Text":
                        _sqlDbType = SqlDbType.Text;
                        break;
                    case "NText":
                        _sqlDbType = SqlDbType.NText;
                        break;
                    case "Image":
                        _sqlDbType = SqlDbType.Image;
                        break;
                    default:
                        _sqlDbType = SqlDbType.VarChar;
                        break;
                }
            }
        }

        public static DataTable getDataFromSql(string connString, string query, string name = "") {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                // take data from sql server
                using (SqlConnection conn = new SqlConnection(connString)) {
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.CommandTimeout = COMMAND_TIMEOUT;
                        conn.Open();
                        // create data adapter
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will queryCountRecId your database and return the result to your datatable
                        DataTable dataTable;
                        if (name != string.Empty || name != null) {
                            dataTable = new DataTable(name);
                        }
                        else {
                            dataTable = new DataTable();
                        }
                        da.Fill(dataTable);
                        conn.Close();
                        da.Dispose();

                        return dataTable;
                    }
                }
            }
            catch (Exception) {
                //Log uLog = new Log();
                Log.append("getDataFromSql -> SQL veri alınamadı.", filePath);
                Console.WriteLine("getDataFromSql -> SQL veri alınamadı.");
                return new DataTable();
            }

        }
        public static DataTable getDataFromProcedure(string connString, string query, List<SqlPair> pairList) {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                DataTable table = new DataTable();
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(query, conn))
                using (var da = new SqlDataAdapter(cmd)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = COMMAND_TIMEOUT;
                    if (!Object.ReferenceEquals(null, pairList)) {
                        foreach (var pair in pairList) {
                            cmd.Parameters.Add("@" + pair.colName_, pair.colType_);
                            if (pair.colSize_ != 0) {
                                cmd.Parameters["@" + pair.colName_].Size = pair.colSize_;
                            }
                            cmd.Parameters["@" + pair.colName_].Value = pair.value_;
                        }
                    }
                    da.Fill(table);
                    return table;
                }
            }
            catch (Exception) {
                //Log uLog = new Log();
                Log.append("getDataFromSql -> SQL veri alınamadı.", filePath);
                return new DataTable();
            }
        }

        public static string makeJson(DataSet dat, string textBoxWebUsername, string textBoxWebUserPass) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                // serialize json from dataset
                string output = "";
                output += JsonConvert.SerializeObject(dat, Newtonsoft.Json.Formatting.Indented);//new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}

                string userName = textBoxWebUsername;
                if (userName == "") {
                    Log.append("textBoxWebUsername Empty!!!", filePath);
                }

                string passWord = textBoxWebUserPass;
                if (passWord == "") {
                    Log.append("textBoxWebUserPass Empty!!!", filePath);
                }
                string firstOutput = "{\n    \"settings\": {\n      \"user\": \"" + userName + "\",\n      \"pass\": \"" + passWord + "\"\n    },\n    \"products\":";
                string lastOutput = "\n}";

                output = firstOutput + output + lastOutput;
                return output;
            }
            catch (Exception ex) {
                Log.append("makeJson -> JSON oluşturulamadı.", filePath);
                Console.WriteLine(ex);
                return null;
            }

        }

        public static string makeJson2(DataSet dat, string textBoxWebUsername, string textBoxWebUserPass) {
            /// this is for sets
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                // serialize json from dataset
                string output = "";
                bool isProductEmpty = false;
                foreach (DataTable table in dat.Tables) {
                    if (table.TableName == "product") { // product one table and that include set main, sets have diffrent table                        
                        output = output.Contains("]") ? output.Remove(output.LastIndexOf("]")) : output;
                        output += JsonConvert.SerializeObject(table, Newtonsoft.Json.Formatting.Indented);
                    }
                    else if (table.TableName.Substring(0, 3) == "set") {
                        //Console.WriteLine(output);
                        if (output.Contains("[]")) {
                            isProductEmpty = true;
                        }
                        else {
                            isProductEmpty = false;
                        }
                        output = output.Contains("]") ? output.Remove(output.LastIndexOf("]")) : output;
                        string s = JsonConvert.SerializeObject(table, Newtonsoft.Json.Formatting.Indented);
                        if (isProductEmpty) {
                            output += s.Contains("[") ? s.Remove(s.IndexOf("["), 1) : s;
                        }
                        else {
                            output += s.Contains("[") ? s.Replace("[", ",") : s;
                        }
                        //output += s;
                        foreach (DataRow row in table.Rows) {
                            foreach (DataTable tableSet in dat.Tables) {
                                if (tableSet.TableName == "product" || tableSet.TableName.Substring(0, 3) == "set" || string.IsNullOrEmpty(tableSet.TableName) || string.IsNullOrEmpty(row["prd_barcode"].ToString())) {
                                    continue;
                                }
                                else if (row["prd_barcode"].ToString() == tableSet.TableName) {
                                    output = output.Contains("]") ? output.Remove(output.LastIndexOf("]")) : output;
                                    output = output.Contains("}") ? output.Remove(output.LastIndexOf("}")) : output;
                                    output += " ,\"prd_set\": ";
                                    output += JsonConvert.SerializeObject(tableSet, Newtonsoft.Json.Formatting.Indented);
                                    output += "\n}";
                                }
                            }
                        }
                        output += "\n]";
                    }
                    else {
                        continue;
                    }
                    output += "\n}";
                }
                //output += JsonConvert.SerializeObject(dat, Newtonsoft.Json.Formatting.Indented);//new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}

                string userName = textBoxWebUsername;
                if (userName == "") {
                    Log.append("textBoxWebUsername Empty!!!", filePath);
                }

                string passWord = textBoxWebUserPass;
                if (passWord == "") {
                    Log.append("textBoxWebUserPass Empty!!!", filePath);
                }
                string firstOutput = "{\n    \"settings\": {\n      \"user\": \"" + userName + "\",\n      \"pass\": \"" + passWord + "\"\n    },\n    \"products\":{\n\"product\":";
                string lastOutput = "\n}";


                output = firstOutput + output + lastOutput;
                //MessageBox.Show(output);
                return output;
            }
            catch (Exception ex) {
                Log.append("makeJson -> JSON oluşturulamadı.", filePath);
                Console.WriteLine(ex);
                return null;
            }

        }
        public static bool IsPropertyExist(dynamic settings, string name) {
            if (settings is ExpandoObject)
                return ((IDictionary<string, object>)settings).ContainsKey(name);

            return settings.GetType().GetProperty(name) != null;
        }


        public static List<string> makeJsonList(DataSet dat, string textBoxXer) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                List<string> myJsons = new List<string>();
                var JSONString = new StringBuilder();
                foreach (DataTable table in dat.Tables) {
                    if (table.Rows.Count > 0) {
                        for (int i = 0; i < table.Rows.Count; i++) {
                            //JSONString.Append("{\n\"product\": [\n");
                            JSONString.Append("{");
                            for (int j = 0; j < table.Columns.Count; j++) {
                                if (j < table.Columns.Count - 1) {
                                    JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                                }
                                else if (j == table.Columns.Count - 1) {
                                    JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                                }
                            }
                            //if (i == table.Rows.Count) {
                            //    JSONString.Append("}");
                            //}
                            //else {
                            //    JSONString.Append("},");
                            //}
                            if (i != 0 && ((i + 1) % Convert.ToInt32(textBoxXer)) == 0) {
                                JSONString.Append("}\n]");
                                string s = JSONString.ToString();
                                myJsons.Add(s);
                                JSONString.Clear();
                            }
                            else {
                                JSONString.Append("},");
                            }

                        }
                        //JSONString.Append("]");
                    }
                }
                if (JSONString.ToString().Length > 0) {
                    myJsons.Add(JSONString.ToString().Remove(JSONString.ToString().Length - 1) + "\n]");
                }
                //return JSONString.ToString();
                return myJsons;
            }
            catch (Exception ex) {
                Log.append("makeJson -> JSON oluşturulamadı.", filePath);
                Console.WriteLine(ex);
                return null;
            }
        }


        public static string writeToSite(string url1, string json) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                byte[] responseArray = new byte[] { };
                // Create a new WebClient instance.
                using (MyWebClient myWebClient = new MyWebClient()) {
                    // Create a new NameValueCollection instance to hold some custom parameters to be posted to the URL.
                    NameValueCollection myNameValueCollection = new NameValueCollection();
                    // httpsssssss
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    // Add necessary parameter/value pairs to the name/value container.
                    myNameValueCollection.Add("json", json);
                    // 'The Upload(String,NameValueCollection)' implicitly method sets HTTP POST as the request method.
                    //myWebClient.time
                    responseArray = myWebClient.UploadValues(url1, "POST", myNameValueCollection);
                    // Decode and display the response.
                }

                return Encoding.ASCII.GetString(responseArray);

            }
            catch (Exception) {
                Log.append("writeToSite -> Siteye yazamadı.", filePath);
                return "";
                //throw;
            }
            
        }
        
        public static async Task<string> writeToSiteAsync(string url1, string json) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                byte[] responseArray = new byte[] { };
                // Create a new WebClient instance.
                using (MyWebClient myWebClient = new MyWebClient()) {
                    // Create a new NameValueCollection instance to hold some custom parameters to be posted to the URL.
                    NameValueCollection myNameValueCollection = new NameValueCollection();
                    // httpsssssss
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    // Add necessary parameter/value pairs to the name/value container.
                    myNameValueCollection.Add("json", json);
                    // 'The Upload(String,NameValueCollection)' implicitly method sets HTTP POST as the request method.
                    //myWebClient.time
                    responseArray = await myWebClient.UploadValuesTaskAsync(url1, "POST", myNameValueCollection);
                    // Decode and display the response.
                }

                return Encoding.ASCII.GetString(responseArray);

            }
            catch (Exception) {
                Log.append("writeToSite -> Siteye yazamadı.", filePath);
                return "";
                //throw;
            }
            
        }

        public static string createUrl4WebOrders(string url, string textBoxDaysAgo, string textBoxWebUsername, string textBoxWebUserPass, bool isUpdateDate=true) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            //Console.WriteLine("textBoxDaysAgo" + textBoxDaysAgo);
            /////
            ///Create url base on date
            ////
            DateTime now = DateTime.Now;
            int days = Convert.ToInt32(textBoxDaysAgo);
            if (days == 0) {
                days = 7;
                Log.append("textBoxDaysAgo Boş olamaz ->" + days.ToString(), filePath);
            }
            DateTime daysAgo = now.AddDays(-1 * days);

            string dateFormat = "yyyy-MM-dd";
            string date2 = now.ToString(dateFormat);
            string date1 = daysAgo.ToString(dateFormat);
            string user = textBoxWebUsername;
            if (user == "") {
                user = "yourPass";
                Log.append("textBoxWebUsername Boş olamaz ->" + days.ToString(), filePath);
            }
            string pass = textBoxWebUserPass;
            if (pass == "") {
                pass = "yourPass";
                Log.append("textBoxWebUserPass Boş olamaz ->" + days.ToString(), filePath);
            }

            if (isUpdateDate) {
                return url + "&udate1=" + date1 + "&udate2=" + date2 + @"&user=" + user + "&pass=" + pass;
            }
            else {
                return url + "&date1=" + date1 + "&date2=" + date2 + @"&user=" + user + "&pass=" + pass;
            }
            

        }
        public static void sendSQLCommand(string connString, string query) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        Log.append("sendSQLCommand ->" + query, filePath);
                        //Clipboard.SetText(queryCountRecId);
                        command.CommandText = query;
                        //command.CommandText = "INSERT into tbl_staff (staffName, userID, idDepartment) VALUES (@staffName, @userID, @idDepart)";
                        //command.Parameters.AddWithValue("@staffName", name);
                        //command.Parameters.AddWithValue("@userID", userId);
                        //command.Parameters.AddWithValue("@idDepart", idDepart);

                        try {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            Log.append("sendSQLCommand" + recordsAffected.ToString() + " kadar işlem yapıldı!", filePath);
                        }
                        catch (SqlException) {
                            // error here
                            Log.append("Sql Error", filePath);
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception) {
                Log.append("sendSQLCommand -> SQL hatası.", filePath);
                Console.WriteLine("sendSQLCommand -> SQL hatası.");
                throw;
            }

        }
        public static string executeScalar(string connString, string query) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        Log.append("executeScalar ->" + query, filePath);
                        command.CommandText = query;
                        string result = "";
                        try {
                            connection.Open();
                            result = command.ExecuteScalar() != null ? command.ExecuteScalar().ToString() : "";
                            return result;
                        }
                        catch (SqlException) {
                            // error here
                            Log.append("Sql Error", filePath);
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
                return "";
            }
            catch (Exception) {
                Log.append("sendSQLCommand -> SQL hatası.", filePath);
                Console.WriteLine("sendSQLCommand -> SQL hatası.");
                throw;
            }

        }
        public static void insertToSQL(string connString, string tableName, params SqlObj[] sqlObjs) { // send 
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        string begin = "INSERT INTO " + tableName + " (";
                        string middle = "";
                        string end = "";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            //add coloumn names
                            middle += sqlObj.colNameGetSet + ",";
                            // add values placeholders
                            end += "@" + sqlObj.colNameGetSet + ",";
                        }
                        middle = middle.Trim().Remove(middle.Trim().Length - 1, 1) + ") VALUES (";
                        end = end.Trim().Remove(end.Trim().Length - 1, 1) + ")";

                        string query = begin + middle + end;
                        Log.append(query, filePath);
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        // give value as parameters
                        //Console.WriteLine(command.CommandText);
                        foreach (var sqlObj in sqlObjs) {
                            command.Parameters.AddWithValue("@" + sqlObj.colNameGetSet, (object)sqlObj.valueGetSet?? DBNull.Value);
                            //Console.WriteLine("@" + sqlObj.colNameGetSet + "=" +sqlObj.valueGetSet.ToString());
                        }
                        //Console.WriteLine("______________________");
                        try {
                            connection.Open();

                            int recordsAffected = command.ExecuteNonQuery();
                            Log.append("insertToSQL " + recordsAffected.ToString() + " kadar işlem yapıldı!", filePath);
                        }
                        catch (SqlException ex) {
                            // error here
                            Log.append("Sql Error", filePath);
                            Console.WriteLine(ex.Message);
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception) {
                Log.append("insertToSql -> SQL hatası.", filePath);
                Console.WriteLine("insertToSql -> SQL hatası.");
                throw;
            }
        }

        public static void insertToSQL2(string connString, string tableName, params SqlObj2[] sqlObjs) { // send 
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;

                        string begin = "INSERT INTO " + tableName + " (";
                        string middle = "";
                        string end = "";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            //add coloumn names
                            middle += sqlObj._colName + ",";
                            // add values placeholders
                            end += "@" + sqlObj._colName + ",";
                        }
                        middle = middle.Trim().Remove(middle.Trim().Length - 1, 1) + ") VALUES (";
                        end = end.Trim().Remove(end.Trim().Length - 1, 1) + ")";

                        string query = begin + middle + end;
                        Log.append(query, filePath);
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        // give value as parameters
                        //Console.WriteLine(command.CommandText);
                        foreach (var sqlObj in sqlObjs) {
                            SqlParameter sqlParameter = new SqlParameter("@" + sqlObj._colName, (object)sqlObj._value ?? DBNull.Value);                            
                            if (sqlObj._datLength != 0) {
                                sqlParameter.Size = sqlObj._datLength;
                            }
                            if (sqlObj._sqlDbType != SqlDbType.VarChar) {
                                sqlParameter.SqlDbType = sqlObj._sqlDbType;
                            }
                            command.Parameters.Add(sqlParameter);
                        }
                        //Console.WriteLine("______________________");
                        try {
                            connection.Open();

                            int recordsAffected = command.ExecuteNonQuery();
                            Log.append("insertToSQL " + recordsAffected.ToString() + " kadar işlem yapıldı!", filePath);
                        }
                        catch (SqlException ex) {
                            // error here
                            Log.append("Sql Error", filePath);
                            Console.WriteLine(ex.Message);
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (SqlException ex) {
                Log.append("insertToSql -> SQL hatası.", filePath);
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static long insertToSQLAndRetunId(string connString, string tableName, params SqlObj[] sqlObjs) { // send 
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        string begin = "INSERT INTO " + tableName + " (";
                        string middle = "";
                        string end = "";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            //add coloumn names
                            middle += sqlObj.colNameGetSet + ",";
                            // add values placeholders
                            end += "@" + sqlObj.colNameGetSet + ",";
                        }
                        middle = middle.Trim().Remove(middle.Trim().Length - 1, 1) + ") OUTPUT INSERTED.RecId VALUES (";
                        end = end.Trim().Remove(end.Trim().Length - 1, 1) + ")";

                        string query = begin + middle + end;
                        Log.append(query, filePath);
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        // give value as parameters
                        //Console.WriteLine(command.CommandText);
                        foreach (var sqlObj in sqlObjs) {
                            command.Parameters.AddWithValue("@" + sqlObj.colNameGetSet, (object)sqlObj.valueGetSet ?? DBNull.Value);
                            //Console.WriteLine("@" + sqlObj.colNameGetSet + "=" +sqlObj.valueGetSet.ToString());
                        }
                        //Console.WriteLine("______________________");
                        long modified = 0;
                         try {
                            connection.Open();
                            string queryx = command.CommandText;

                            foreach (SqlParameter p in command.Parameters) {
                                queryx = queryx.Replace(p.ParameterName, p.Value.ToString());
                                //Console.WriteLine(queryx);
                            }

                            modified = (long)command.ExecuteScalar();
                        }
                        catch (SqlException) {
                            // error here
                            Log.append("Sql Error", filePath);
                        }
                        finally {
                            connection.Close();
                        }
                        return modified;
                    }
                }
            }
            catch (Exception) {
                Log.append("insertToSql -> SQL hatası.", filePath);
                throw;
            }
        }
        
        public static long insertToSQLAndRetunId2(string connString, string tableName, params SqlObj[] sqlObjs) { // send 
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        string begin = "INSERT INTO " + tableName + " (";
                        string middle = "";
                        string end = "";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            //add coloumn names
                            middle += sqlObj.colNameGetSet + ",";
                            // add values placeholders
                            end += "@" + sqlObj.colNameGetSet + ",";
                        }
                        middle = middle.Trim().Remove(middle.Trim().Length - 1, 1) + ") VALUES (";
                        end = end.Trim().Remove(end.Trim().Length - 1, 1) + ") SELECT SCOPE_IDENTITY()";

                        string query = begin + middle + end;
                        Log.append(query, filePath);
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        // give value as parameters
                        //Console.WriteLine(command.CommandText);
                        foreach (var sqlObj in sqlObjs) {
                            command.Parameters.AddWithValue("@" + sqlObj.colNameGetSet, (object)sqlObj.valueGetSet ?? DBNull.Value);
                            //Console.WriteLine("@" + sqlObj.colNameGetSet + "=" +sqlObj.valueGetSet.ToString());
                        }
                        //Console.WriteLine("______________________");
                        long modified = 0;
                         try {
                            connection.Open();

                            modified = (long)command.ExecuteScalar();
                        }
                        catch (SqlException) {
                            // error here
                            Log.append("Sql Error", filePath);
                        }
                        finally {
                            connection.Close();
                        }
                        return modified;
                    }
                }
            }
            catch (Exception) {
                Log.append("insertToSql -> SQL hatası.", filePath);
                throw;
            }
        }


        public static void updateSQL(string connString, string tableName, string conditions, params SqlObj[] sqlObjs) {
            //"UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        string begin = "UPDATE " + tableName;
                        string middle = " SET ";
                        string end = " WHERE ";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            middle += sqlObj.colNameGetSet + " = @" + sqlObj.colNameGetSet + ",";
                        }
                        middle = middle.Remove(middle.Length - 1, 1);
                        end += conditions;

                        string query = begin + middle + end;
                        Log.append(query, filePath);
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        // give value as parameters
                        foreach (var sqlObj in sqlObjs) {
                            command.Parameters.AddWithValue("@" + sqlObj.colNameGetSet, sqlObj.valueGetSet);
                        }
                        try {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            Log.append("updateSQL " + recordsAffected.ToString() + " kadar işlem yapıldı!", filePath);
                        }
                        catch (SqlException) {
                            // error here
                            Log.append("Sql Error", filePath);
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception) {
                Log.append("updateSql -> SQL hatası.", filePath);
                throw;
            }
        }
        
        public static void updateSQL2(string connString, string tableName, string conditions, params SqlObj2[] sqlObjs) {
            //"UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = COMMAND_TIMEOUT;
                        string begin = "UPDATE " + tableName;
                        string middle = " SET ";
                        string end = " WHERE ";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            middle += sqlObj._colName + " = @" + sqlObj._colName + ",";
                        }
                        middle = middle.Remove(middle.Length - 1, 1);
                        end += conditions;

                        string query = begin + middle + end;
                        Log.append(query, filePath);
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        // give value as parameters
                        foreach (var sqlObj in sqlObjs) {
                            command.Parameters.AddWithValue("@" + sqlObj._colName, sqlObj._value);
                        }
                        try {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            Log.append("updateSQL " + recordsAffected.ToString() + " kadar işlem yapıldı!", filePath);
                        }
                        catch (SqlException) {
                            // error here
                            Log.append("Sql Error", filePath);
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception) {
                Log.append("updateSql -> SQL hatası.", filePath);
                throw;
            }
        }

        public static string changeCommaWithDot(string s) {
            try {
                return s.Replace(',', '.');
            }
            catch (Exception) {
                throw;
            }
        }

        public static string getPicture(string InventoryId) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string query = string.Format("SELECT Attachment FROM Erp_InventoryAttachment WHERE InventoryId = '{0}' AND Type = '9' AND InUse = '1'", InventoryId);

            using (var conn = new SqlConnection(UGCore.Functions.GetConnString("ms_sql"))) {
                using (var cmd = new SqlCommand()) {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = COMMAND_TIMEOUT;
                    //Log.append("sendSQLCommand ->" + queryCountRecId);
                    //Clipboard.SetText(queryCountRecId);
                    cmd.CommandText = query;
                    //cmd.AddInParam("name", DbType.String, name);
                    conn.Open();
                    string strBase64 = Convert.ToBase64String(cmd.ExecuteScalar() as byte[]); // image
                    //Clipboard.SetText(strBase64);
                    Log.append("Image Base64 Copied to clipboard!", filePath);
                }
            }
            return "";
        }

        public static string givePicture() {
            string query = "insert into tableName (ImageColumn) SELECT BulkColumn FROM Openrowset(Bulk ‘image..Path..here’, Single_Blob) as img";
            // give this a parameter
            return query;
        }

        public static void DumpObjectProp(Object obj) {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj)) {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("{0}={1}", name, value);
            }
        }
        //public static string tryGetJsonVar(string s) {
        //    try {

        //    }
        //    catch (Exception) {

        //        throw;
        //    }
        //}
    }

}
