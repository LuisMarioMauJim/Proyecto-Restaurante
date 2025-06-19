using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using WinFormsApp_PrototipoProyectoPOO.Model;
using PrototipoProyectoPOO.Model;


namespace PrototipoProyectoPOO.Presenter
{
    public class WGerente
    {
        ManagerBD managerBD;

        public WGerente()
        {
            managerBD = new ManagerBD();
        }

        public bool listSuministros(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 3 });
            ds = managerBD.GetData("spuGerente", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }

        public bool ConnectionCheck() //verifica la disponiblididad de la conexion
        {
            bool conexionDisponible = false;
            SqlConnection connection = managerBD.GetConnection();
            if (connection.State == ConnectionState.Open)
                conexionDisponible = true;

            return conexionDisponible;
        }

        public bool insertSuministro(CInventarios suministro)
        {
            bool registrado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 1 });

            sqlParameters.Add(new SqlParameter("@Inv_Suministro", SqlDbType.NVarChar) { Value = suministro.Inv_Suministro });
            sqlParameters.Add(new SqlParameter("@Inv_Cantidad", SqlDbType.Int) { Value = suministro.Inv_Cantidad });
            sqlParameters.Add(new SqlParameter("@Inv_Descripcion", SqlDbType.NVarChar) { Value = suministro.Inv_Descripcion });
            registrado = managerBD.UpdateData("spuGerente", sqlParameters.ToArray());
            return registrado;
        }
        
        public bool updateSuministro(CInventarios suministro)

        {
            bool actualizado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 2 });
            sqlParameters.Add(new SqlParameter("@Inv_Pk", SqlDbType.Int) { Value = suministro.Inv_Pk });
            sqlParameters.Add(new SqlParameter("@Inv_Suministro", SqlDbType.NVarChar) { Value = suministro.Inv_Suministro });
            sqlParameters.Add(new SqlParameter("@Inv_Cantidad", SqlDbType.Int) { Value = suministro.Inv_Cantidad });
            sqlParameters.Add(new SqlParameter("@Inv_Descripcion", SqlDbType.NVarChar) { Value = suministro.Inv_Descripcion });
            actualizado = managerBD.UpdateData("spuGerente", sqlParameters.ToArray());
            return actualizado;
        }

        public bool deleteSuministro(CInventarios suministro)
        {
            bool eliminado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 4 });
            sqlParameters.Add(new SqlParameter("@Inv_Pk", SqlDbType.Int) { Value = suministro.Inv_Pk });
            eliminado = managerBD.UpdateData("spuGerente", sqlParameters.ToArray());
            return eliminado;
        }

        public bool listVentas(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 5 });
            ds = managerBD.GetData("spuGerente", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }

        public bool listReservas(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 6 });
            ds = managerBD.GetData("spuGerente", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }

        public bool listMovimientos(ref DataSet ds, int IdVenta)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 7 });
            sqlParameters.Add(new SqlParameter("@Mov_FkVenta", SqlDbType.Int) { Value = IdVenta });
            ds = managerBD.GetData("spuGerente", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }
    }
}
        