using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategory
    {
        private string _name { get; set; }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _id { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public ENCategory()
        {
            id = 0;
            name = "";
        }
        public ENCategory(string name, int id)
        {
            this.id = id;
            this.name = name;
        }
        public bool read() 
        {
            try
            {
                CADCategory producto = new CADCategory();
                return producto.read(this);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }

        public List<ENCategory> readAll()
        {
           CADCategory producto = new CADCategory();
           return producto.readAll();
        }
    }
}
