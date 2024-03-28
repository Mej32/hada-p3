using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADCategory
    {
        private string constring { get; set; }
        public CADCategory()
        {
            constring = ConfigurationManager.ConnectionStrings["constring"].ToString();

        }
        public bool read(ENCategory en)
        {
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "SELECT name FROM Categories WHERE name = @name;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@name", en.name);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        en.id = (int)dr["id"];
                        en.name = dr["name"].ToString();

                    }
                    dr.Close();
                    connection.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    return false;

                }
            }
        }
        public List<ENCategory> readAll()
        {
            List<ENCategory> listaenc = new List<ENCategory>();
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "SELECT * FROM Categories;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    SqlDataReader dr = consulta.ExecuteReader();
                    while (dr.Read())
                    {
                        ENCategory enc = new ENCategory(dr["name"].ToString(),(int) dr["id"]);
                        listaenc.Add(enc);
                    }
                    dr.Close();
                    connection.Close();
                    return listaenc;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    return listaenc;

                }
            }
        } 

    }
}
