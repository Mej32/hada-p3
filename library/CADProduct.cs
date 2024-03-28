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
                    string Consulta = "Insert Into Products (code,name,amount,price,category,creationDate) VALUES (@code,@name,@amount,@price,@category,@fecha)";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@code", en.code);
                    consulta.Parameters.AddWithValue("@name", en.name);
                    consulta.Parameters.AddWithValue("@amount", en.amount);
                    consulta.Parameters.AddWithValue("@price", en.price);
                    consulta.Parameters.AddWithValue("@category", en.category);
                    consulta.Parameters.AddWithValue("@fecha", en.creationDate);
                    consulta.ExecuteNonQuery(); 
                    connection.Close();
                    return true; //no hace falta comprobar ya que si entra en el bool create de CADProducts significa que no hay otro codigo igual y que no 
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;
                }
            }
        }
        public bool Update(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "UPDATE Products SET name=@name,price=@price,amount=@amount,category=@category,creationDate=@fecha WHERE code =@code;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@code", en.code);
                    consulta.Parameters.AddWithValue("@name", en.name);
                    consulta.Parameters.AddWithValue("@amount", en.amount);
                    consulta.Parameters.AddWithValue("@price", en.price);
                    consulta.Parameters.AddWithValue("@category", en.category);
                    consulta.Parameters.AddWithValue("@fecha", en.creationDate);
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
                    throw ex;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;
                }
            }

        }/* Actualiza los datos de un producto en la BDconlos datos del producto representado por el parámetro en.*/
        
        public bool Delete(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "DELETE FROM Products WHERE code = @code;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@code", en.code);
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
                    throw ex;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;
                }
            }
        } /*Borra el producto representado en en de la BD.*/
        public bool Read(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "SELECT * FROM Products WHERE code=@code;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@code", en.code);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if(dr.Read()){
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)(double)dr["price"]; //al no estar definido en la bd creada el float se le pone de valor predeterminado 53, lo que lo convierte en un coulbe por lo que se ha de realizar un doble casteo
                        en.creationDate = (DateTime)dr["creationDate"];
                        return true;
                    }
                    dr.Close();
                    connection.Close();
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;

                }catch(Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
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
                    string Consulta = "SELECT TOP 1 * from Products;";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)(double)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
                        return true;
                    }
                    dr.Close();
                    connection.Close();
                    return false; ;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;
                }
            }
        } /*Devuelve solo el primer producto de la BD.*/
        public bool ReadNext(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = " SELECT * FROM Products WHERE id = (SELECT MIN(id) FROM Products where id  > (SELECT id FROM Products WHERE code =@code));";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@code", en.code);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    { 
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)(double)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
                        return true;
                    }
                    dr.Close();
                    connection.Close();
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;
                }
            }
        }/*Devuelvesolo el producto siguiente  al indicado.*/
        public bool ReadPrev(ENProduct en){
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "SELECT * FROM Products WHERE id = (SELECT MAX(id) FROM Products where id  < (SELECT id FROM Products WHERE code =@code));";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    consulta.Parameters.AddWithValue("@code", en.code);
                    SqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        en.code = dr["code"].ToString();
                        en.name = dr["name"].ToString();
                        en.amount = (int)dr["amount"];
                        en.category = (int)dr["category"];
                        en.price = (float)(double)dr["price"];
                        en.creationDate = (DateTime)dr["creationDate"];
                        return true;
                    }
                    dr.Close();
                    connection.Close();
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    throw ex;
                    
                }
            }
        } /*Devuelve solo elproducto anterior   al indicado.*/
        
    }
}