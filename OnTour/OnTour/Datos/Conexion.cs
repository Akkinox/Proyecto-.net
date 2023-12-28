using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnTour.Datos
{
    class Conexion
    {
        private SqlConnection conn = new SqlConnection();
        
        
        public Conexion()
        {
            this.conn = new SqlConnection(@";Data Source=kuro;Initial Catalog=ONTOUR;Integrated Security=True");
        }
        public SqlConnection Conn { get => conn; }
    }

}
