using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;


namespace library
{
    public class CADProduct
    {
        private string constring { get; set; }
        public CADProduct()
        {
            constring = ConfigurationManager.ConnectionStrings["constring"].ToString();


        }

        public bool Create(ENProduct en) //falta
        {
            using(SqlConnection connection = new SqlConnection(en.ToString()))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"INSERT INTO Products (name,code,amount,price,category,creationDate) VALUES ('{en.name}','{en.code}',{en.amount},{en.price},{en.category},'{en.creationDate}')";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                    connection.Close();
                    return true;
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    connection.Close();
                    return false;

                }    
            }
        }
        public bool Update(ENProduct en){
            using (SqlConnection connection = new SqlConnection(en.ToString()))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"UPDATE Products SET name='" + en.name + "',price=" + en.price + ",amount=" + en.amount + ",category=" + en.category + ",creationDate='" + en.creationDate + "'WHERE code ='" + en.code + "';";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
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

        }/* Actualiza los datos de un producto en la BDconlos datos del producto representado por el parámetro en.*/
        
        public bool Delete(ENProduct en){
            using (SqlConnection connection = new SqlConnection(en.ToString()))
            {
                try
                {
                    connection.Open();
                    string Consulta = $"DELETE FROM Products WHERE code = '"+ en.code + "';";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
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
        } /*Borra el producto representado en en de la BD.*/
        public bool Read(ENProduct en){
            return false;
        }/* Devuelve solo el producto indicado leído de la BD.*/
        public bool ReadFirst(ENProduct en){
            return false;
        } /*Devuelve solo el primer producto de la BD.*/
        public bool ReadNext(ENProduct en){
            return false;
        }/*Devuelvesolo el producto siguiente  al indicado.*/
        public bool ReadPrev(ENProduct en){
            return false;
        } /*Devuelve solo elproducto anterior   al indicado.*/
        
    }
}