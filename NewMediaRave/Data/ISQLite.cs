using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewMediaRave.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
