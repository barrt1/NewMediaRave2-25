﻿using Foundation;
using NewMediaRave.Data;
using NewMediaRave.iOS.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace NewMediaRave.iOS.Data
{
   public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection() 
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connenction = new SQLite.SQLiteConnection(path);
            return connenction;
        }
    }
}