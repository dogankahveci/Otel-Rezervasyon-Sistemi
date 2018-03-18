using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
    class SqlHelper
    {
        private static SqlConnection _cnn =new SqlConnection("server=dfkdk;database=Otel;Integrated Security=true;");
        public static SqlConnection Cnn
        {
            get
            {
                return _cnn;

            }
        }
    }
}
