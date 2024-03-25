using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {
        private string code { get; set; }
        private string name { get; set; }
        private int amount { get; set; }
        private int category { get; set; }
        private float price { get; set; }
        private DateTime creationDate { get; set; }
        public ENProduct()
        {

        }
        public ENProduct(string code, string name, int amount, float price, int category ,DateTime creationDate)
        {
            this.code = code;
            this.name = name;
            this.amount = amount;
            this.category = category;
            this.price = price;
            this.creationDate = creationDate;

        }
        public bool Create() //falta a base de CADProducts
        {
            return true;
        }

        public bool Update() { 
        
        } /*Actualiza este producto en la BD.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool Delete() { 
        
        } /*Borra este producto de la BD.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool Read() { 
        
        } /*Recupera el producto indicado de la BD.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadFirst() { 
        
        } /*Recupera todos los productos de la BD y devuelve solo el primer producto.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadNext() { 
        
        } /*Recupera todos los productos de la BD ydevuelve solo el producto siguiente al indicado.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadPrev() { 
        
        } /*Recupera todos los productos de la BD ydevuelvesolo el producto anterior al indicado.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
    }
}
