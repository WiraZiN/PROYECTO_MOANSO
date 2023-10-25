using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datMatPrenda
    {
        #region sigleton
        private static readonly datMatPrenda _instancia = new datMatPrenda();
        public static datMatPrenda Instancia
        {
            get
            {
                return datMatPrenda._instancia;
            }
        }
        #endregion singleton
        #region metodos

        public List<entMatPrenda> ListarPrenda()
        {
            SqlCommand cmd = null;
            List<entMatPrenda> lista = new List<entMatPrenda>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMaterialesPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMatPrenda Mat = new entMatPrenda();
                    Mat.idMatPrenda = Convert.ToInt32(dr["idMatPrenda"]);
                    Mat.Material = dr["Material"].ToString();
                    Mat.estMaterial = Convert.ToBoolean(dr["estMaterial"]);
                    lista.Add(Mat);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;


        }
        #endregion metodos


        public Boolean InsertarMatPrenda(entMatPrenda Pr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMaterialPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Material", Pr.Material);
                cmd.Parameters.AddWithValue("@estMaterial", Pr.estMaterial);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        public Boolean ModificarMatPrenda(entMatPrenda Pr)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarMaterialPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMatPrenda", Pr.idMatPrenda);
                cmd.Parameters.AddWithValue("@NuevoMaterial", Pr.Material);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarMatPrenda(entMatPrenda Pr)
        {
            SqlCommand cmd = null;
            Boolean eliminado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarMaterialPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMatPrenda", Pr.idMatPrenda);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return eliminado;
        }
    }
}
