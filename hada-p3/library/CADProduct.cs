using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Configuration;
using System.Globalization;

namespace library
{
    public class CADProduct
    {
        private string constring { get; set; }
        public CADProduct()
        {
            constring = ConfigurationManager.ConnectionStrings["constring"].ToString();


        }

        public bool Create(ENProduct en) 
        {
            using(SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string fechaHoraSQL = en.creationDate.ToString("yyyy-MM-dd HH:mm:ss");
                    string Consulta = $"Insert Into Products (code,name,amount,price,category,creationDate) VALUES ('" +en.code +"','" +en.name +"',"+en.amount+","+en.price+","+en.category+",'"+fechaHoraSQL+"')";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.ExecuteNonQuery(); 
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
        public bool Update(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string fechaHoraSQL = en.creationDate.ToString("yyyy-MM-dd HH:mm:ss");
                    string Consulta = $"UPDATE Products SET name='" + en.name + "',price=" + en.price + ",amount=" + en.amount + ",category=" + en.category + ",creationDate='" + fechaHoraSQL + "'WHERE code ='" + en.code + "';";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    int columnasafectadas=consulta.ExecuteNonQuery();
                    connection.Close();
                    if (columnasafectadas < 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    return false;

                }
            }

        }/* Actualiza los datos de un producto en la BDconlos datos del producto representado por el parámetro en.*/
        
        public bool Delete(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"DELETE FROM Products WHERE code = '"+ en.code + "';";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    int columnasafectadas = consulta.ExecuteNonQuery();
                    connection.Close();
                    if (columnasafectadas < 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    return false;

                }
            }
        } /*Borra el producto representado en en de la BD.*/
        public bool Read(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"SELECT * FROM Products WHERE code='" + en.code + "';";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if(dr.Read()){
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
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

                }catch(Exception ex)
                {
                    connection.Close();
                    throw ex;
                }
            }
        }/* Devuelve solo el producto indicado leído de la BD.*/
        public bool ReadFirst(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"SELECT * FROM Products LIMIT 1;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
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
        } /*Devuelve solo el primer producto de la BD.*/
        public bool ReadNext(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"SELECT * FROM Productos WHERE id = (SELECT MAX(id) FROM Productos where id  < (SELECT id FROM Productos WHERE code =" + en.code + "));";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    { 
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
                        
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
        }/*Devuelvesolo el producto siguiente  al indicado.*/
        public bool ReadPrev(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"SELECT * FROM Productos WHERE id = (SELECT MIN(id) FROM Productos where id  > (SELECT id FROM Productos WHERE code =" + en.code + "));";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
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
        } /*Devuelve solo elproducto anterior   al indicado.*/
        
    }
}