using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
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
    }
}