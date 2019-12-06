using System;
using System.Collections.Generic;
using RethinkDb.Driver;
using RethinkDb.Driver.Net;

namespace DotaFantasyApp.Utils
{
    public static class ThinkDb<T>
    {
        public static Cursor<T> ts;
        public static RethinkDB rethink = RethinkDB.R;
        public static Connection conn = rethink.Connection().Db("Fantasy").Hostname("10.0.2.2").Port(RethinkDBConstants.DefaultPort).Connect();
        public static T GetData(string tableName, object key)
        {
            return rethink.Table(tableName).Get(key).Run<T>(conn);
        }
        public static List<T> GetAllData(string tableName, List<KeyValuePair<string, string>> pair)
        {
            try
            {
                ts = rethink.Table(tableName).GetAll(pair[0].Value).OptArg("index", pair[0].Key).Run<T>(conn);
                return ts.BufferedItems;
            }
            catch(Exception ex)
            {
                return new List<T>();
            }
        }

        public static List<T> FilterData(string tableName, object filterQuery)
        {
            try
            {
                ts = rethink.Table(tableName).Filter(row => filterQuery).Run<T>(conn);
                return ts.BufferedItems;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
