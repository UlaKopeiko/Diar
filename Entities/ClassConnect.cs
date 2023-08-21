using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Entities
{
    internal class ClassConnect
    {
        public static string GetSQLConnString()
        {
            string sSqlServer = "USER-PC";
            string sDatabase = "Diary";

            string sConnection = string.Format(CultureInfo.InvariantCulture,
             "Data Source={0};Initial Catalog={1};Integrated Security=SSPI",
             sSqlServer, sDatabase);

            return sConnection;
        }
    }
}
