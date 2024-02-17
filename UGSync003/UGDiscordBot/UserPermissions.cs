using System;
using System.Data;
using UGCore;

namespace UGDiscordBot {
    public static class UserPermissions {
        public static Tuple<bool, string> check(string discordId) {
            SqlObj sql = new SqlObj();
            bool result = false;
            string recId = "";
            try {
                sql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
                sql.openConnection();

                sql.selectTable(string.Format(@"SELECT RecId, DiscordId FROM dbo.Meta_User WHERE DiscordId='{0}'", discordId), true);
                DataTable table = sql.dataTableGet;
                if (table.Rows.Count > 0 && !string.IsNullOrEmpty(table.Rows[0]["DiscordId"].ToString()) &&
                    !string.IsNullOrWhiteSpace(table.Rows[0]["DiscordId"].ToString()) && table.Rows[0]["DiscordId"].ToString() == discordId) {
                    result = true;
                    recId = table.Rows[0]["RecId"].ToString();
                }
                else {
                    result = false;
                }
            }
            catch (Exception) {
                result = false;
            }
            finally {
                sql.closeConnection();
            }
            return new Tuple<bool, string>(result, recId);
        }
        
        public static bool checkOFM(string discordId) {
            bool result = false;
            try {
                if ("656066563165782019" == discordId) {
                    result = true;
                }
                else {
                    result = false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

    }
}
