using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using ExamDictionary.Database;
using ExamDictionary.Droid.Database;

[assembly: Dependency(typeof(SQLiteAndroid))]

namespace ExamDictionary.Droid.Database
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "DataSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
