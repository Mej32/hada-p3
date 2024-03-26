﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {
        private string _code { get; set; }
        private string _name { get; set; }
        private int _amount { get; set; }
        private int _category { get; set; }
        private float _price { get; set; }
        private DateTime _creationDate { get; set; }
        public string code
        {
            get { return _code; }
            set { _code = value;}

        }
        public string name
        {
            get { return _name; }
            set { _name = value;}
        }
        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int category
        {
            get { return _category; }
            set { _category = value; }
        }
        public float price
        {
            get { return _price; }
            set { _price = value; }
        }
        public DateTime creationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public ENProduct()
        {

        }
        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationDate)
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
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.Create(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }

        public bool Update() {
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.Update(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        } /*Actualiza este producto en la BD. Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool Delete() {
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.Delete(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        } /*Borra este producto de la BD. Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool Read() {
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.Read(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        } /*Recupera el producto indicado de la BD.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadFirst() {
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.ReadFirst(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        } /*Recupera todos los productos de la BD y devuelve solo el primer producto.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadNext() {
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.ReadNext(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        } /*Recupera todos los productos de la BD y devuelve solo el producto siguiente al indicado.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadPrev() {
            try
            {
                CADProduct producto = new CADProduct();
                if (producto.ReadPrev(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        } /*Recupera todos los productos de la BD y devuelve solo el producto anterior al indicado.Para ello hará uso de los métodos apropiados de CADProduct.Devuelve false si no se ha podido realizar la operación.*/
    }
}
