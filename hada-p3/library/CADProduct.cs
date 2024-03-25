using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace library
{
    public class CADProduct
    {
        private string constring { get; set; }
        public CADProduct()
        {
            constring = System.String.Empty;
        }
        public bool Create(ENProduct en) //falta
        {
            return false;
        }
        public bool Update(ENProduct en){
        
        }/* Actualiza los datos de un producto en la BDconlos datos del producto representado por el parámetro en.*/
        
        public bool Delete(ENProduct en){
        
        } /*Borra el producto representado en en de la BD.*/
        public bool Read(ENProduct en){

        }/* Devuelve solo el producto indicado leído de la BD.*/
        public bool ReadFirst(ENProduct en){

        } /*Devuelve solo el primer producto de la BD.*/
        public bool ReadNext(ENProducten){
    
        }/*Devuelvesolo el producto siguiente  al indicado.*/
        public bool ReadPrev(ENProduct en){

        } /*Devuelve solo elproducto anterior   al indicado.*/
        
    }
}