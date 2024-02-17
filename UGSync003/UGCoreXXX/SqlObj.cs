using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UGCore {
    public class SqlObj {
        public enum EnumSqlCommands {
            ShowTableNames,
            SelectString,
            SelectTable,
            Insert,
            InsertMulti,
            Update
        }
        public struct SqlPair {
            public string colName;
            public string value;
            public SqlPair(string ColName, string Value) {
                colName = ColName;
                value = Value;
            }
        }
#pragma warning disable 0649
        public DataTable cloneTable = null;
#pragma warning restore 0649
        private SqlConnection m_connection;
        private SqlCommand m_command;
        private string m_connectionString = "";
        private string m_query = "";

        // results
        private string m_scalarString = "";
        private int m_recordsAffected = 0;
        private DataTable m_dataTable;


        // Getters and setters
        public string connectionStringGetSet { get { return m_connectionString; } set { m_connectionString = value; } }
        public string queryGetSet { get { return m_query; } }
        public string scalarStringGet { get { return m_scalarString; } }
        public int recordsAffectedGet { get { return m_recordsAffected; } }
        public DataTable dataTableGet { get { return m_dataTable; } }

        public SqlObj() {
            /// Empty
        }
        ~SqlObj() {
            this.closeConnection();
            m_connection.Dispose();
        }
        public void initalizeSqlConnection(string connectionString) {
            m_connectionString = connectionString;
            m_connection = new SqlConnection(m_connectionString);
            m_command = new SqlCommand();
            m_command.Connection = m_connection;
            m_command.CommandType = CommandType.Text;
        }

        public bool openConnection() {
            if (m_connection.State != ConnectionState.Open) {
                if (m_connectionString == "") {
                    MessageBox.Show("m_connectionString can NOT be empty!");
                    return false;
                }
                else {
                    try {
                        m_connection.ConnectionString = m_connectionString;
                        m_connection.Open();
                        return true;
                    }
                    catch (SqlException ex) {
                        switch (ex.Number) {
                            case 0:
                                MessageBox.Show("Cannot connect to server.  Contact administrator");
                                break;
                            case 1045:
                                MessageBox.Show("Invalid username/password, please try again");
                                break;
                            default:
                                MessageBox.Show(ex.Number.ToString() + ". Error!\nCannot connect to server.\n" + ex.Message);
                                break;
                        }
                        return false;
                    }
                }
            }
            return false;
        }

        public void closeConnection() {
            if (m_connection.State != ConnectionState.Closed) {
                try {
                    m_connection.Close();
                }
                catch (SqlException ex) {
                    MessageBox.Show("Sql DisConnection Error! " + ex.Message);
                    throw;
                }

            }
        }

        public void selectString(string expressions, string tableName, string conditions, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20; 
             */
            /// use first elements
            m_query = string.Format(@"SELECT {0} FROM {1} WHERE {2}", expressions, tableName, conditions);
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.SelectString);
            }
        }

        public void selectTable(string expressions, string tableName, string conditions, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20;  
             */
            /// use first elements
            m_query = string.Format(@"SELECT {0} FROM {1} WHERE {2}", expressions, tableName, conditions);
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.SelectTable);
            }
        }

        public void selectString(string querry, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20; 
             */
            /// use first elements
            m_query = querry;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.SelectString);
            }
        }

        public void selectTable(string querry, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20;  
             */
            /// use first elements
            m_query = querry;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.SelectTable);
            }
        }

        public void insert(string query, bool sendCommand = false) {
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType) VALUES (@ArticleTitle, @ArticleContent, @ArticleType)"; -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            m_query = query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.Insert);
            }
        }

        public void insert(string tableName, List<SqlPair> sqlPairs, bool sendCommand = false) {
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType) VALUES (@ArticleTitle, @ArticleContent, @ArticleType)"; -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            m_query = string.Format(@"INSERT INTO {0} {1} VALUES {2}",
                                    tableName,
                                    makeCommaLine(sqlPairs.Select(o => o.colName).ToList(), true, false),
                                    makeCommaLine(sqlPairs.Select(o => o.value).ToList(), true));
            m_command.CommandText = m_query;
            string val = "";
            foreach (var SqlPair in sqlPairs) {
                //val = Regex.Replace(sqlPair.value, @"[\r\n'/\\]", " ");
                val = Regex.Replace(SqlPair.value, "\r", " ");
                val = Regex.Replace(val, "\n", " ");
                val = Regex.Replace(val, "'", "\'");
                val = Regex.Replace(val, @"^\\", @"\\");
                m_command.Parameters.AddWithValue("@" + SqlPair.colName, val);
                val = "";
            }
            if (sendCommand) {
                executeCommand(EnumSqlCommands.Insert);
            }
        }

        public void insertMulti(string tableName, string ColNames, string values, bool sendCommand = false) { // values = (x, y)
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType) VALUES (@ArticleTitle, @ArticleContent, @ArticleType)"; -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            m_query = string.Format(@"INSERT INTO {0} ({1}) VALUES {2}", tableName, ColNames, values);
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.InsertMulti);
            }
        }

        public void update(string tableName, List<SqlPair> sqlPairs, string condition, bool sendCommand = false) {
            /*UPDATE table_name SET [column_name1= value1,...column_nameN = valueN] [WHERE expression2]
              UPDATE students SET User_Name = 'Sonoo' WHERE Student_Id = '3' 
              "UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn AND LastName = @ln" -> command.Parameters.AddWithValue("@ln", lastName);
             */
            m_query = string.Format(@"UPDATE {0} SET {1} WHERE {2}", tableName, makeUpdateExpression(sqlPairs), condition);
            m_command.CommandText = m_query;
            string val = "";
            foreach (var sqlPair in sqlPairs) {
                val = Regex.Replace(sqlPair.value, "\r", " ");
                val = Regex.Replace(val, "\n", " ");
                val = Regex.Replace(val, "'", "\'");
                val = Regex.Replace(val, @"^\\", @"\\");
                m_command.Parameters.AddWithValue("@" + sqlPair.colName, val);//[\r\n'/\\]
                val = "";
            }
            if (sendCommand) {
                executeCommand(EnumSqlCommands.Update);
            }

        }

        public void update(string query, bool sendCommand = false) {
            /*UPDATE table_name SET [column_name1= value1,...column_nameN = valueN] [WHERE expression2]
              UPDATE students SET User_Name = 'Sonoo' WHERE Student_Id = '3' 
              "UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn AND LastName = @ln" -> command.Parameters.AddWithValue("@ln", lastName);
             */
            m_query = query;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumSqlCommands.Update);
            }
        }


        public void executeCommand(EnumSqlCommands enumSqlCommand) {
            m_dataTable = new DataTable();
            using (m_connection) {
                using (m_command) {
                    try {
                        switch (enumSqlCommand) {
                            case EnumSqlCommands.ShowTableNames:
                                openConnection();
                                if (m_dataTable.Rows.Count != 0)
                                    m_dataTable.Clear();
                                m_dataTable = m_connection.GetSchema("Tables");
                                break;
                            case EnumSqlCommands.SelectString:
                                openConnection();
                                m_scalarString = "";
                                var scalar = m_command.ExecuteScalar();
                                if (scalar != null && scalar != DBNull.Value) {
                                    m_scalarString = scalar.ToString();
                                }
                                break;
                            case EnumSqlCommands.SelectTable:
                                openConnection();
                                if (m_dataTable.Rows.Count != 0)
                                    m_dataTable.Clear();
                                SqlDataAdapter da = new SqlDataAdapter(m_command);
                                da.Fill(m_dataTable);
                                break;
                            case EnumSqlCommands.Insert:
                            case EnumSqlCommands.InsertMulti:
                            case EnumSqlCommands.Update:
                                m_recordsAffected = 0;
                                openConnection();
                                m_recordsAffected = m_command.ExecuteNonQuery();
                                //MessageBox.Show(m_recordsAffected + " kadar işlem yapıldı.");
                                break;
                            default:
                                break;
                        }
                        m_command.Parameters.Clear();
                    }
                    catch (SqlException ex) {
                        MessageBox.Show("Sql error\n" + ex.Message);
                        throw;
                    }

                }

            }

        }

        public string makeCommaLine(List<string> stringList, bool isParanthesesOn = false, bool isSingleQuoteOn = true) {
            try {
                string expresssion = "";
                string val = "";
                foreach (var s in stringList) {
                    val = Regex.Replace(s, "\r", " ");
                    val = Regex.Replace(val, "\n", " ");
                    val = Regex.Replace(val, "'", "\'");
                    val = Regex.Replace(val, @"^\\", @"\\");
                    if (isSingleQuoteOn) {
                        expresssion += "'" + val + "',";
                    }
                    else {
                        expresssion += val + ",";
                    }
                    val = "";
                }
                if (!isParanthesesOn)
                    return expresssion.Remove(expresssion.Length - 1);
                else
                    return ("(" + expresssion.Remove(expresssion.Length - 1) + ")");
            }
            catch (Exception) {
                MessageBox.Show("makeInsertExpression error!");
                throw;
            }
        }

        private string makeUpdateExpression(List<SqlPair> sqlPairs) {
            try {
                string middle = "";
                foreach (var sqlPair in sqlPairs) {
                    middle += sqlPair.colName + "=@" + sqlPair.colName + ",";
                }
                return middle.Remove(middle.Length - 1);
            }
            catch (Exception) {
                MessageBox.Show("makeUpdateExpression error!");
                throw;
            }

        }

        /// idk if this exist in SQL
        //public int Import(string path) {
        //    ///*
        //    // LOAD DATA
        //    //[LOW_PRIORITY | CONCURRENT] [LOCAL]
        //    //INFILE 'file_name'
        //    //[REPLACE | IGNORE]
        //    //INTO TABLE tbl_name
        //    //[PARTITION (partition_name [, partition_name] ...)]
        //    //[CHARACTER SET charset_name]
        //    //[{FIELDS | COLUMNS}
        //    //    [TERMINATED BY 'string']
        //    //    [[OPTIONALLY] ENCLOSED BY 'char']
        //    //    [ESCAPED BY 'char']
        //    //]
        //    //[LINES
        //    //    [STARTING BY 'string']
        //    //    [TERMINATED BY 'string']
        //    //]
        //    //[IGNORE number {LINES | ROWS}]
        //    //[(col_name_or_user_var
        //    //    [, col_name_or_user_var] ...)]
        //    //[SET col_name={expr | DEFAULT},
        //    //    [, col_name={expr | DEFAULT}] ...]
        //    // */
        //    try {
        //        string cmd = "LOAD DATA INFILE '" + path + "' INTO TABLE zen_hardware.products FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n'";
        //        int a = MySqlHelper.ExecuteNonQuery( m_connection, cmd);
        //        return a;
        //    }
        //    catch {
        //        return -1;
        //    }
        //}

        /**/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////old

#if oldFuncitions
        public DataTable getDataFromSql(string connString, string query) {
            try {
                // take data from sql server
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                // create data adapter
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                conn.Close();
                da.Dispose();

                return dataTable;
            }
            catch (Exception) {
                MessageBox.Show("getDataFromSql -> SQL veri alınamadı.");
                throw;
            }

        }
        public string executeScalarMySql(string connString, string query) {
            using (MySqlConnection connection = new MySqlConnection(connString)) {
                using (MySqlCommand command = new MySqlCommand()) {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    MessageBox.Show("getDataFromSql ->" + query);
                    command.CommandText = query;
                    try {
                        connection.Open();
                        string data = command.ExecuteScalar().ToString();
                        MessageBox.Show("getDataFromSql -" + data.ToString() + "- aldı.");
                        return data;
                    }
                    catch (MySqlException) {
                        // error here
                        MessageBox.Show("Sql Error");

                    }
                    finally {
                        connection.Close();
                    }
                }
            }
            return "";
        }
        private void updatedMySQLTable(string connString, string query) {
            try {
                using (MySqlConnection connection = new MySqlConnection(connString)) {
                    using (MySqlCommand command = new MySqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        MessageBox.Show("sendSQLCommand ->" + query);
                        command.CommandText = query;
                        try {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("sendSQLCommand " + recordsAffected.ToString() + " kadar işlem yapıldı!");
                        }
                        catch (MySqlException) {
                            // error here
                            MessageBox.Show("Sql Error");
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("sendSQLCommand -> SQL hatası.");
                throw;
            }

        }

        private void insertToMySQLTable(string connString, string tableName, params SqlObj[] sqlObjs) {
            try {
                using (MySqlConnection connection = new MySqlConnection(connString)) {
                    using (MySqlCommand command = new MySqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        string begin = "INSERT INTO " + tableName + " (";
                        string middle = "";
                        string end = "";
                        // middle
                        foreach (var sqlObj in sqlObjs) {
                            //add coloumn names
                            middle += sqlObj.colNameGetSet + ",";
                            // add values
                            if (sqlObj.isStringGetSet == true) {
                                end += "'" + sqlObj.valueGetSet + "',";
                            }
                            else {
                                end += sqlObj.valueGetSet + ",";//string.Format("{0} AS DECIMAL({1}, 4),", sqlObj.valueGetSet, sqlObj.valueGetSet.Length);
                            }
                        }
                        middle = middle.Trim().Remove(middle.Trim().Length - 1, 1) + ") VALUES (";
                        end = end.Trim().Remove(end.Trim().Length - 1, 1) + ")";

                        string query = begin + middle + end;
                        //MessageBox.Show(query);
                        command.CommandText = query;
                        try {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            //MessageBox.Show("insertToSQL " + recordsAffected.ToString() + " kadar işlem yaptı.");
                        }
                        catch (SqlException) {
                            //MessageBox.Show("Sql Error");
                        }
                        finally {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("insertToSql -> SQL hatası.");
                throw;
            }
        }
#endif

    }
}
