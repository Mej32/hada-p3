using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace library
{
    public class CADProduct
    {
        private string constring { get; set; }
        public CADProduct()
        {
            constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
        }
        
        public bool Create(ENProduct en) //falta
        {
            using(SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string Consulta = "INSERT INTO Products (name,code,amount,price,category,creationDate) VALUES (@name,@code,@amount,@price,@category,@creationDate)";
                    SqlCommand consulta = new SqlCommand(Consulta, connection);
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                    return false;

                }
            }
            
            return true;
        }
        public bool Update(ENProduct en){
            return false;
        }/* Actualiza los datos de un producto en la BDconlos datos del producto representado por el parámetro en.*/
        
        public bool Delete(ENProduct en){
            return false;
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