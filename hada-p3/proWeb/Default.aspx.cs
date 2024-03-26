using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;


namespace proWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Check(ref int amount, ref float price, ref int valuecat, ref DateTime Correctformat)
        {
            string formatofecha = "dd/mm/aaaa hh:mm:ss";

            try
            {
                if (!int.TryParse(AmountBox.Text, out amount))
                {
                    throw new Exception();
                }
                if (!float.TryParse(PriceBox.Text, out price))
                {
                    throw new Exception();
                }
                else
                {
                    price = (float)Math.Round(price, 2);
                }
                if (!int.TryParse(CategoryList.SelectedValue, out valuecat))
                {
                    throw new Exception();
                }
                if (!DateTime.TryParseExact(CreationDateBox.Text, formatofecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out Correctformat)) //Compara el formato de la fecha con el formato del segundo string y si es igual devuelve true y esa fecha en Correctformat
                {
                    throw new ArgumentException();
                }
                if ((Codebox.Text.Length > 16 || Codebox.Text.Length < 1) || (NameBox.Text.Length > 32) || (amount < 0 || amount > 9999) || (price < 0 || price > 9999.99) || (valuecat > 3 || valuecat < 0)){
                    EtiquetaFallo.Visible = true;
                    throw new Exception();
                }
                else
                {
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
                return false;
            }

        }
        protected void Create_click(object sender, EventArgs create)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount,ref price,ref valuecat,ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat);
                producto.Create();
                EtiquetaExito.Visible = true;
            }


        }
        protected void Update_click(object sender, EventArgs update)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount, ref price, ref valuecat, ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat);
                try
                {
                    if (producto.Update())
                    {
                        EtiquetaExito.Visible = true;
                    }
                    else
                    {
                        EtiquetaFallo.Visible = true;
                    }
                }
                finally
                {
                    producto = null;
                }
            }
        }
        protected void Delete_click(object sender, EventArgs delete)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount, ref price, ref valuecat, ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat);
                try
                {
                    if (producto.Delete())
                    {
                        EtiquetaExito.Visible = true;
                    }
                    else
                    {
                        EtiquetaFallo.Visible = true;
                    }
                }
                finally
                {
                    producto = null;
                }
            }
        }
        protected void ReadFirst_click(object sender, EventArgs RF)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount, ref price, ref valuecat, ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat); //mirarlo de aqui a abajo
                try
                {
                    if (producto.ReadFirst())
                    {
                        EtiquetaExito.Visible = true;
                    }
                    else
                    {
                        EtiquetaFallo.Visible = true;
                    }
                }
                finally
                {
                    producto = null;
                }
            }
        }
        protected void Read_click(object sender, EventArgs RF)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount, ref price, ref valuecat, ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat); //mirarlo de aqui a abajo
                try
                {
                    if (producto.Read())
                    {
                        EtiquetaExito.Visible = true;
                    }
                    else
                    {
                        EtiquetaFallo.Visible = true;
                    }
                }
                finally
                {
                    producto = null;
                }
            }
        }
        protected void ReadPrev_click(object sender, EventArgs RP)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount, ref price, ref valuecat, ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat);
                try
                {
                    if (producto.ReadPrev())
                    {
                        EtiquetaExito.Visible = true;
                    }
                    else
                    {
                        EtiquetaFallo.Visible = true;
                    }
                }
                finally
                {
                    producto = null;
                }
            }

        }
        protected void ReadNext_click(object sender, EventArgs RN)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            int amount = 0, valuecat = 0;
            float price = 0;
            DateTime Correctformat = DateTime.MinValue;
            if (Check(ref amount, ref price, ref valuecat, ref Correctformat))
            {
                ENProduct producto = new ENProduct(Codebox.Text, NameBox.Text, amount, price, valuecat, Correctformat);
                try
                {
                    if (producto.ReadNext())
                    {
                        EtiquetaExito.Visible = true;
                    }
                    else
                    {
                        EtiquetaFallo.Visible = true;
                    }
                }
                finally
                {
                    producto = null;
                }
            }

        }

    }
}