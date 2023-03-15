using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ArticuloDAL
    {
        SqlConnection conn = new SqlConnection();
        public List<Articulos> obtenerArticulos()
        {
            try
            {
                conn = ConectionDAL.Singleton.ConnetionFactory;
                conn.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[ObtenerArticulos]");
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                List<Articulos> listaArticulos = new List<Articulos>();

                listaArticulos = (from DataRow dr in dt.Rows

                                select new Articulos
                                {
                                    Nombre = dr["Nombre"].ToString(),
                                    descripcion = dr["descripcion"].ToString(),
                                    precio_unidad = dr["precio_unidad"].ToString(),
                                    stock = dr["stock"].ToString(),
                                    imagen = dr["imagen"].ToString(),
                                   
                                }).ToList();

                return listaArticulos;



            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
