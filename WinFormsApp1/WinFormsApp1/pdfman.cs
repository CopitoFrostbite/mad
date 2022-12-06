using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose;
using Aspose.Pdf;
using System.IO;
using System.Data;
using Aspose.Pdf.Text;

namespace WinFormsApp1
{
    internal class pdfman
    {
        private static readonly string _dataDir = "..\\..\\..\\PDF";
        public static void recibo(DataTable table)
        {
            // Initialize document object
            
            Document document = new Document();
            // Add page
            Page page = document.Pages.Add();
            // Add text to new page
            var nombre = table.Rows[0]["Nombre"].ToString();
            var center = new TextFragment(nombre);
            center.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;



            page.Paragraphs.Add(center);
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Sucursal:  " + table.Rows[0]["Sucursal"].ToString()));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Direccion: " + table.Rows[0]["Direccion"].ToString()));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje1"].ToString()));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje2"].ToString()+ "\n"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Producto" + "\t\t" + "Cantidad" + "\t\t" + "Precio" + "\t\t" + "Descuento" + "\t\t" + "Total" + "\n"));
            foreach (DataRow av in table.Rows)

            {

                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(av["Producto"].ToString()+ "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Cantidad"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Precio"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Descuento"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["TotalProd"].ToString()+ "\n"));

            }
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Total: "+table.Rows[0]["Total"].ToString()+ "\n"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Su Pago: " + table.Rows[0]["Pago"].ToString() + "\n"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Cambio: " + table.Rows[0]["Cambio"].ToString() + "\n"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje3"].ToString()));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje4"].ToString() + "\n"));



            // Save updated PDF
            var outputFileName = System.IO.Path.Combine(_dataDir, "Orden "+ table.Rows[0]["Orden"].ToString() + ".pdf");
            document.Save(outputFileName);
        }
        public static void devo(DataTable table, decimal tot)
        {
            // Initialize document object

            Document document = new Document();
            // Add page
            Page page = document.Pages.Add();
            // Add text to new page
            var nombre = "NOTA DE CREDITO" + "\n";
            var center = new TextFragment(nombre);
            center.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;



            page.Paragraphs.Add(center);
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Orden #    "+table.Rows[0]["Recibo"].ToString() + "\n"));
           
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Numero" + "\t\t" + "Producto" + "\t\t" + "Motivo" + "\t\t" + "Cantidad" + "\t\t" + "Subtotal"+ "\t\t" + "Total"+ "\n"));
            foreach (DataRow av in table.Rows)

            {

                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(av["Articulo"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Nombre"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Motivo"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Cantidad"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Subtotal"].ToString() +"t\t\t\t\t\t\t\t\t\t\t\t" + av["Total"].ToString() + "\n"));

            }
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Total: " + tot+ "\n"));
            


            // Save updated PDF
            var outputFileName = System.IO.Path.Combine(_dataDir, "Nota de Credito # " + table.Rows[0]["Recibo"].ToString() + ".pdf");
            document.Save(outputFileName);
        }
    }
}
