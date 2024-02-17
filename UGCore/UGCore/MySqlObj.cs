using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UGCore {
    public class MySqlObj {
        public enum EnumMySqlCommands {
            ShowTableNames,
            SelectString,
            SelectTable,
            Insert,
            InsertMulti,
            Update,
            Truncate
        }
        //public struct MySqlPair {
        //    public string colName_;
        //    public string value_;
        //    public MySqlPair(string ColName, string Value) : this() {
        //        this.colName_ = ColName;
        //        this.value_ = Value;
        //    }
        //}
        public struct MySqlPair {
            public string colName_;
            public object value_;
            public int colSize_ { get; set; }
            //public MySqlDbType colType_ { get; set; }
            public MySqlPair(string ColName, object Value, int ColSize = 0/*, MySqlDbType ColType = MySqlDbType.String*/) : this() {
                this.colName_ = ColName;
                this.value_ = Value;
                this.colSize_ = ColSize;
                //this.colType_ = ColType;
            }
        }

        private MySqlConnection m_connection;
        private MySqlCommand m_command;
        private string m_connectionString = "";
        private string m_query = "";
        // results
        private string m_scalarString = "";
        private long m_lastInsertedId = 0;
        private int m_recordsAffected = 0;
        private DataTable m_dataTable;


        // Getters and setters
        public string connectionStringGetSet { get { return m_connectionString; } set { m_connectionString = value; } }
        public string queryGetSet { get { return m_query; } }
        public string scalarStringGet { get { return m_scalarString; } }
        public long lastInsertedId { get { return m_lastInsertedId; } }
        public int recordsAffectedGet { get { return m_recordsAffected; } }
        public DataTable dataTableGet { get { return m_dataTable; } }

        public MySqlObj() {
            /// Empty
        }
        public MySqlObj(string mySqlConn) {
            /// MySqlObj.DEFAULT_CONN_STRING
            initalizeMySqlConnection(mySqlConn);
        }
        ~MySqlObj() {
            this.closeConnection();
            if (m_connection != null) {
                m_connection.Dispose();
            }
        }
        public void initalizeMySqlConnection(string connectionString) {
            m_connectionString = connectionString;
            m_connection = new MySqlConnection(m_connectionString);
            m_command = new MySqlCommand();
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
                    catch (MySqlException ex) {
                        switch (ex.Number) {
                            case 0:
                                Console.WriteLine("Cannot connect to server.  Contact administrator");
                                break;
                            case 1045:
                                Console.WriteLine("Invalid username/password, please try again");
                                break;
                            default:
                                Console.WriteLine(ex.Number.ToString() + ". Error!\nCannot connect to server.\n" + ex.Message);
                                break;
                        }
                        return false;
                    }
                }
            }
            return false;
        }

        public void closeConnection() {
            if (m_connection!= null && m_connection.State != ConnectionState.Closed) {
                try {
                    m_connection.Close();
                }
                catch (MySqlException ex) {
                    MessageBox.Show("MySql DisConnection Error! " + ex.Message);
                    throw;
                }

            }
        }
        /// ///
        /// selectString
        /// ///
        public void selectString(string querry, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20; 
             */
            /// use first elements
            m_query = querry;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectString);
            }
        }
        public void selectString(string querryWithParameters, List<MySqlObj.MySqlPair> mySqlPairs, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > @age; 
             */
            /// use first elements
            m_query = querryWithParameters;
            m_command.CommandText = m_query;
            foreach (var pair in mySqlPairs) {
                m_command.Parameters.AddWithValue("@" + pair.colName_, pair.value_);
            }
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectString);
            }
        }
        ///this is bad
        public void selectString(string expressions, string tableName, string conditions, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20; 
             */
            /// use first elements
            m_query = string.Format(@"SELECT {0} FROM {1} WHERE {2}", expressions, tableName, conditions);
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectString);
            }
        }

        public void selectString(string expressions, string tableName, List<MySqlObj.MySqlPair> mySqlPairs, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20; 
             */
            /// use first elements
            m_query = $@"SELECT {expressions} FROM {expressions} WHERE {makeUpdateExpression(mySqlPairs)}";
            m_command.CommandText = m_query;
            foreach (var pair in mySqlPairs) {
                m_command.Parameters.AddWithValue("@" + pair.colName_, pair.value_);
            }
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectString);
            }
        }
        /// ///
        /// selectTable
        /// ///
        public void selectTable(string querry, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20;  
             */
            /// use first elements
            m_query = querry;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectTable);
            }
        }

        public void selectTable(string querryWithParameters, List<MySqlObj.MySqlPair> mySqlPairs, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > @age;  
             */
            /// use first elements
            m_query = querryWithParameters;
            m_command.CommandText = m_query;
            foreach (var pair in mySqlPairs) {
                m_command.Parameters.AddWithValue("@" + pair.colName_, pair.value_);
            }
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectTable);
            }
        }

        ///this is bad
        public void selectTable(string expressions, string tableName, string conditions, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20;  
             */
            /// use first elements
            m_query = string.Format(@"SELECT {0} FROM {1} WHERE {2}", expressions, tableName, conditions);
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectTable);
            }
        }

        public void selectTable(string expressions, string tableName, List<MySqlObj.MySqlPair> mySqlPairs, bool sendCommand = false) {
            /*SELECT expression1 FROM table_names WHERE condition; 
              SELECT emp_name FROM employee WHERE age > 20;  
             */
            /// use first elements
            m_query = $@"SELECT {expressions} FROM {tableName} WHERE {makeUpdateExpression(mySqlPairs)}";
            m_command.CommandText = m_query;
            foreach (var pair in mySqlPairs) {
                m_command.Parameters.AddWithValue("@" + pair.colName_, pair.value_);
            }
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.SelectTable);
            }
        }
        /// ///
        /// insert
        /// ///
        public void insert(string query, bool sendCommand = false) {
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType) VALUES (@ArticleTitle, @ArticleContent, @ArticleType)";
              -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            m_query = query;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.Insert);
            }
        }

        public void insert(string tableName, List<MySqlPair> mySqlPairs, bool sendCommand = false) {
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType) VALUES (@ArticleTitle, @ArticleContent, @ArticleType)";
              -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            Tuple<string,string> t = makeParameterExpression(mySqlPairs.Select(o => o.colName_).ToList());
            m_query = $@"INSERT INTO {tableName} ({t.Item1}) VALUES ({t.Item2})";
            m_command.CommandText = m_query;
            Console.WriteLine();
            foreach (var pair in mySqlPairs) {
                /*                /*  foreach (var sqlObj in sqlObjs) {
                            SqlParameter sqlParameter = new SqlParameter("@" + sqlObj._colName, (object)sqlObj._value ?? DBNull.Value);                            
                            if (sqlObj._datLength != 0) {
                                sqlParameter.Size = sqlObj._datLength;
                            }
                            if (sqlObj._sqlDbType != SqlDbType.VarChar) {
                                sqlParameter.SqlDbType = sqlObj._sqlDbType;
                            }
                            command.Parameters.Add(sqlParameter);
                        }
                        ////
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
                 */
                m_command.Parameters.AddWithValue("@" + pair.colName_, pair.value_);
                if (pair.colSize_ != 0)
                    m_command.Parameters["@" + pair.colName_].Size = pair.colSize_;
            }
            Console.WriteLine();
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.Insert);
            }
        }

        public void insertMulti(string tableName, string ColNames, string values, bool sendCommand = false) { // values = (x, y)
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType) VALUES (@ArticleTitle, @ArticleContent, @ArticleType)"; -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            string val = Regex.Replace(values, "\r", " ");
            val = Regex.Replace(val, "\n", " ");
            val = Regex.Replace(val, "'", "\'");
            val = Regex.Replace(val, @"^\\", @"\\");
            if (string.IsNullOrEmpty(ColNames) || string.IsNullOrWhiteSpace(ColNames)) {
                m_query = string.Format(@"INSERT INTO {0} {1} VALUES {2}", tableName, ColNames, val);
            }
            else {
                m_query = string.Format(@"INSERT INTO {0} ({1}) VALUES {2}", tableName, ColNames, val);
            }           
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.InsertMulti);
            }
        }

        public void insertMulti(string tableName, List<List<MySqlObj.MySqlPair>> mySqlPairRowList, bool sendCommand = true) { // values = (x, y)
            /*INSERT INTO table_name (col1, col2, col3,.... col N) VALUES (value1, value2, value3, .... valueN);
              INSERT INTO javatpoint (Author, Subject) VALUES ('Sonoo', 'DBMS'); 
              string query = "INSERT INTO ArticlesTBL  VALUES (@ArticleTitle, @ArticleContent, @ArticleType)"; 
              -> myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            */
            ///get query ending from first row list @colnames
            if (mySqlPairRowList.Count <= 0) {
                return;
            }
            Tuple<string, string> t = makeParameterExpression(mySqlPairRowList[0].AsEnumerable().Select(r => r.colName_).ToList());
            
            m_query = $@"INSERT INTO {tableName} ({t.Item1}) VALUES ({t.Item2})";
            m_command.CommandText = m_query;

            foreach (var mySqlPairRow in mySqlPairRowList) {
                foreach (var pair in mySqlPairRow) {
                    if (string.IsNullOrEmpty(pair.value_.ToString()) ||
                        string.IsNullOrWhiteSpace(pair.value_.ToString()) || 
                        pair.value_.ToString() == "''") {
                        m_command.Parameters.AddWithValue("@" + pair.colName_, DBNull.Value);
                        if (pair.colSize_ != 0)
                            m_command.Parameters["@" + pair.colName_].Size = pair.colSize_;
                    }
                    else {
                        m_command.Parameters.AddWithValue("@" + pair.colName_, pair.value_);
                        if (pair.colSize_ != 0)
                            m_command.Parameters["@" + pair.colName_].Size = pair.colSize_;
                    }
                }
                //getGeneratdSql(true);
                if (sendCommand) {
                    executeCommand(EnumMySqlCommands.InsertMulti);
                }
            }            
        }

        /// ///
        /// update
        /// ///
        public void update(string query, bool sendCommand = false) {
            /*UPDATE table_name SET [column_name1= value1,...column_nameN = valueN] [WHERE expression2]
              UPDATE students SET User_Name = 'Sonoo' WHERE Student_Id = '3' 
              "UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn AND LastName = @ln" -> command.Parameters.AddWithValue("@ln", lastName);
             */
            m_query = query;
            m_command.CommandText = m_query;
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.Update);
            }
        }
       
        public void update(string tableName, List<MySqlPair> mySqlPairs, string condition, bool sendCommand = false) {
            /*UPDATE table_name SET [column_name1= value1,...column_nameN = valueN] [WHERE expression2]
              UPDATE students SET User_Name = 'Sonoo' WHERE Student_Id = '3' 
              "UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn AND LastName = @ln" 
              -> command.Parameters.AddWithValue("@ln", lastName);
            */
            m_query = string.Format(@"UPDATE {0} SET {1} WHERE {2}", tableName, makeUpdateExpression(mySqlPairs), condition);
            m_command.CommandText = m_query;
            //string val = "";

            foreach (var mySqlPair in mySqlPairs) {
                //val = Regex.Replace(mySqlPair.value_.ToString(), "\r", " ");
                //val = Regex.Replace(val, "\n", " ");
                //val = Regex.Replace(val, "'", "\'");
                //val = Regex.Replace(val, @"^\\", @"\\"); id FROM robot.crm_customer WHERE email 
                m_command.Parameters.AddWithValue("@" + mySqlPair.colName_, mySqlPair.value_);//[\r\n'/\\]
                //val = "";
            }
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.Update);
            }
        }
        /// ///
        /// truncate table
        /// ///
        public void truncate(string tableName, bool sendCommand = false) {
           
            m_query = "TRUNCATE TABLE " + tableName;
            m_command.CommandText = m_query;
            //cmd.ExecuteNonQuery();
            if (sendCommand) {
                executeCommand(EnumMySqlCommands.Truncate);
            }
        }
        /// ///
        /// execute command
        /// ///
        public void executeCommand(EnumMySqlCommands enumMySqlCommand) {
            m_dataTable = new DataTable();
            using (m_connection) {
                using (m_command) {
                    try {
                        openConnection();
                        //getGeneratdSql();
                        switch (enumMySqlCommand) {
                            case EnumMySqlCommands.ShowTableNames:
                                if (m_dataTable.Rows.Count != 0)
                                    m_dataTable.Clear();
                                m_dataTable = m_connection.GetSchema("Tables");
                                break;
                            case EnumMySqlCommands.SelectString:
                                m_scalarString = "";
                                var scalar = m_command.ExecuteScalar();
                                if (scalar != null && scalar != DBNull.Value) {
                                    m_scalarString = scalar.ToString();
                                }
                                break;
                            case EnumMySqlCommands.SelectTable:
                                if (m_dataTable.Rows.Count != 0)
                                    m_dataTable.Clear();
                                MySqlDataAdapter da = new MySqlDataAdapter(m_command);
                                da.Fill(m_dataTable);
                                break;
                            case EnumMySqlCommands.Insert:
                            case EnumMySqlCommands.InsertMulti:
                            case EnumMySqlCommands.Update:
                            case EnumMySqlCommands.Truncate:
                                m_recordsAffected = 0;
                                m_lastInsertedId = 0;
                                m_recordsAffected = m_command.ExecuteNonQuery();
                                m_lastInsertedId = m_command.LastInsertedId;
                                break;
                            default:
                                break;
                        }
                        m_command.Parameters.Clear();
                    }
                    catch (MySqlException ex) {
                        MessageBox.Show("MySql error\n" + ex.Message);
                        Console.WriteLine(ex);
                    }

                }

            }

        }

        public string makeCommaLine(List<string> stringList, bool isParanthesesOn = false, bool isSingleQuoteOn = true) {
            try {
                string expresssion = "";
                //string val = "";
                foreach (var val in stringList) {
                    //val = Regex.Replace(s, "\r", " ");
                    //val = Regex.Replace(val, "\n", " ");
                    //val = Regex.Replace(val, "'", "\'");
                    //val = Regex.Replace(val, @"^\\", @"\\");
                    if (isSingleQuoteOn) {
                        expresssion += "'" + val + "',";
                    }
                    else {
                        expresssion += val + ",";
                    }
                    //val = "";
                }
                if (!isParanthesesOn)
                    return expresssion.Remove(expresssion.Length - 1);
                else
                    return ("(" + expresssion.Remove(expresssion.Length - 1) + ")");
            }
            catch (Exception ex) {
                MessageBox.Show("makeInsertExpression error!");
                Console.WriteLine(ex);
                return null;
            }
        }

        private Tuple<string,string> makeParameterExpression(List<string> colnames) {
            string s1 = "";
            string s2 = "";
            foreach (var col in colnames) {
                if (!s1.Trim().Contains(col)) {
                    s1 += " " + col + ",";
                }
                if (!s2.Trim().Contains(col)) {
                    s2 += " @" + col + ",";
                }
            }

            s1 = s1.Trim();
            if (s1.Contains(",")) {
                s1 = s1.Remove(s1.LastIndexOf(","));
            }

            s2 = s2.Trim();
            if (s2.Contains(",")) {
                s2 = s2.Remove(s2.LastIndexOf(","));
            }
            return new Tuple<string, string>(s1, s2);
        }

        private string makeUpdateExpression(List<MySqlPair> mySqlPairs) {
            try {
                string middle = "";
                foreach (var mySqlPair in mySqlPairs) {
                    middle += mySqlPair.colName_ + "=@" + mySqlPair.colName_ + ",";
                }
                if (middle.Contains(",")) {
                    middle = middle.Remove(middle.LastIndexOf(","));
                }
                return middle;
            }
            catch (Exception ex) {
                MessageBox.Show("makeUpdateExpression error!");
                Console.WriteLine(ex);
                return null;
            }

        }

        public DataTable deleteAllColumnsFromTable(DataTable table) {
            for (int i = 0; i < table.Columns.Count; i++) {
                table.Columns.RemoveAt(i);
            }
            return table;
        }

        private void getGeneratdSql(bool isReplace = false) {
            if (!isReplace) {
                Console.WriteLine(m_command.CommandText.ToString());
                if (m_command.Parameters.Count > 0) {
                    foreach (MySqlParameter p in m_command.Parameters) {
                        if (string.IsNullOrEmpty(p.Value.ToString()) || string.IsNullOrWhiteSpace(p.Value.ToString()) ||
                            p.Value == DBNull.Value || p.Value == null) {
                            Console.WriteLine(p.ParameterName.ToString() + "=>DBNull");
                        }
                        else {
                            Console.WriteLine(p.ParameterName.ToString() + "=>" + p.Value.ToString());
                        }                        
                    }
                }
            }
            else {
                string tmp = m_command.CommandText.ToString();
                foreach (MySqlParameter p in m_command.Parameters) {
                    tmp = tmp.Replace('@' + p.ParameterName.ToString(), "'" + p.Value.ToString() + "'");
                }
                Console.WriteLine(tmp);
            }            
        }

        public int Import(string path) {
            ///*
            // LOAD DATA
            //[LOW_PRIORITY | CONCURRENT] [LOCAL]
            //INFILE 'file_name'
            //[REPLACE | IGNORE]
            //INTO TABLE tbl_name
            //[PARTITION (partition_name [, partition_name] ...)]
            //[CHARACTER SET charset_name]
            //[{FIELDS | COLUMNS}
            //    [TERMINATED BY 'string']
            //    [[OPTIONALLY] ENCLOSED BY 'char']
            //    [ESCAPED BY 'char']
            //]
            //[LINES
            //    [STARTING BY 'string']
            //    [TERMINATED BY 'string']
            //]
            //[IGNORE number {LINES | ROWS}]
            //[(col_name_or_user_var
            //    [, col_name_or_user_var] ...)]
            //[SET col_name={expr | DEFAULT},
            //    [, col_name={expr | DEFAULT}] ...]
            // */
            try {
                string cmd = "LOAD DATA INFILE '" + path + "' INTO TABLE zen_hardware.products FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n'";
                int a = MySqlHelper.ExecuteNonQuery(m_connection, cmd);
                return a;
            }
            catch {
                return -1;
            }
        }

    }
}
