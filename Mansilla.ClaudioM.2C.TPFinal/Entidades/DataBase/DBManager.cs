using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DataBase
{
    public static class DBManager
    {
        private static string stringConnection;

        static DBManager()
        {
            DBManager.stringConnection = "Server=.;Database=MansillaClaudio-2C-TPFinal;Trusted_Connection=True;";
        }

        public static string StringConnection
        {
            get { return DBManager.stringConnection; }
        }
    }
}
