using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Net;
using System.Text;

namespace UGCore {

    public static class Functions {

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
        public static DataTable getDataFromSql(string connString, string query, string name = "") {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                // take data from sql server
                using (SqlConnection conn = new SqlConnection(connString)) {
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {

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
            catch (Exception) {
                Log.append("makeJson -> JSON oluşturulamadı.", filePath);
                throw;
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
                        Console.WriteLine(output);
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
            catch (Exception) {
                Log.append("makeJson -> JSON oluşturulamadı.", filePath);
                throw;
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
            catch (Exception) {
                Log.append("makeJson -> JSON oluşturulamadı.", filePath);
                throw;
            }

        }
        public static string writeToSite(string url1, string json) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                byte[] responseArray = new byte[] { };
                // Create a new WebClient instance.
                using (WebClient myWebClient = new WebClient()) {
                    // Create a new NameValueCollection instance to hold some custom parameters to be posted to the URL.
                    NameValueCollection myNameValueCollection = new NameValueCollection();
                    // httpsssssss
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    // Add necessary parameter/value pairs to the name/value container.
                    myNameValueCollection.Add("json", json);
                    // 'The Upload(String,NameValueCollection)' implicitly method sets HTTP POST as the request method.            
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

        public static string createUrl4WebOrders(string url, string textBoxDaysAgo, string textBoxWebUsername, string textBoxWebUserPass) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            /////
            ///Create url base on date
            ////
            DateTime now = DateTime.Now;
            int days = Convert.ToInt32(textBoxDaysAgo);
            if (days == 0) {
                days = 10;
                Log.append("textBoxDaysAgo Boş olamaz ->" + days.ToString(), filePath);
            }
            DateTime daysAgo = now.AddDays(-1 * days);

            string dateFormat = "yyyy-MM-dd";
            string date2 = now.ToString(dateFormat);
            string date1 = daysAgo.ToString(dateFormat);
            string user = textBoxWebUsername;
            if (user == "") {
                user = "uzaktanGLR6523";
                Log.append("textBoxWebUsername Boş olamaz ->" + days.ToString(), filePath);
            }
            string pass = textBoxWebUserPass;
            if (pass == "") {
                pass = "654Dfg654DFgj5645";
                Log.append("textBoxWebUserPass Boş olamaz ->" + days.ToString(), filePath);
            }
            return url + "&date1=" + date1 + "&date2=" + date2 + @"&user=" + user + "&pass=" + pass;

        }
        public static void sendSQLCommand(string connString, string query) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            try {
                using (SqlConnection connection = new SqlConnection(connString)) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
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
                            command.Parameters.AddWithValue("@" + sqlObj.colNameGetSet, sqlObj.valueGetSet);
                            //Console.WriteLine("@" + sqlObj.colNameGetSet + "=" +sqlObj.valueGetSet.ToString());
                        }
                        //Console.WriteLine("______________________");
                        try {
                            connection.Open();

                            int recordsAffected = command.ExecuteNonQuery();
                            Log.append("insertToSQL " + recordsAffected.ToString() + " kadar işlem yapıldı!", filePath);
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

            using (var conn = new SqlConnection(CONST.SQL_CONN_STRING)) {
                using (var cmd = new SqlCommand()) {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
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

        //public static string tryGetJsonVar(string s) {
        //    try {

        //    }
        //    catch (Exception) {

        //        throw;
        //    }
        //}
    }

}
