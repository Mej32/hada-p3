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
        public ENCategory()
        {
            name = "";
        }
        public ENCategory(string name)
        {
            this.name = name;
        }
        public bool read() 
        {
            try
            {
                CADCategory producto = new CADCategory();
                if (producto.read(this))
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
        }

        public List<ENCategory> readAll()
        {
           CADCategory producto = new CADCategory();
           return producto.readAll();
        }
    }
}
