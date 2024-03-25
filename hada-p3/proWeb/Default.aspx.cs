using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_click(object sender, EventArgs create)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a crear obj
            try
            {
                //Create();
                EtiquetaExito.Visible = true;
                
            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }
        }
        protected void Update_click(object sender, EventArgs update)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a actualizar obj
            try
            {
                //Update();
                EtiquetaExito.Visible = true;

            }
            catch(Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }
        }
        protected void Delete_click(object sender, EventArgs delete)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a borrar obj
            try
            {
                //Delete();
                EtiquetaExito.Visible = true;

            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }
        }
        protected void Read_click(object sender, EventArgs read)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a leer obj
            try
            {
                //Read();
                EtiquetaExito.Visible = true;

            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }
        }
        protected void ReadFirst_click(object sender, EventArgs RF)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a leer primer obj
            try
            {
                //ReaFirst();
                EtiquetaExito.Visible = true;

            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }
        }
        protected void ReadPrev_click(object sender, EventArgs RP)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a leer obj anterior obj
            try
            {
                //ReadPrev();
                EtiquetaExito.Visible = true;

            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }

        }
        protected void ReadNext_click(object sender, EventArgs RN)
        {
            EtiquetaExito.Visible = false;
            EtiquetaFallo.Visible = false;
            //llama a leer siguiente obj
            try
            {
                //ReadNext();
                EtiquetaExito.Visible = true;

            }
            catch (Exception ex)
            {
                EtiquetaFallo.Visible = true;
                Console.WriteLine($"Product operation has failed.Error: {0}", ex.Message);
            }

        }

    }
}