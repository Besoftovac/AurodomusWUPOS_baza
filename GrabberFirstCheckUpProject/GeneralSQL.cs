using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabberFirstCheckUpProject
{
    class GeneralSQL
    {
        public static SqlConnection CatchDatabase()
        {
            String user = "Korisnik";
            String pass = "123";
            String konekcija = String.Format(@"Initial Catalog=AurodomusWUPOS; Data Source=213.191.149.106; User Id={0}; Password={1}", user, pass);
            
            SqlConnection conn = new SqlConnection(konekcija);

            return conn;

        }
    }
}
