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

            var table2 = new Table
            {
                ColumnWidths = "93",
                Border = new BorderInfo(BorderSide.None, 1f, Aspose.Pdf.Color.DarkSlateGray),
                DefaultCellBorder = new BorderInfo(BorderSide.None, 0.5f, Aspose.Pdf.Color.Black),
                DefaultCellPadding = new MarginInfo(1.5, 10.5, 1.5, 10.5),
                Margin =
                {
                    Bottom = 10
                },
                DefaultCellTextState =
                {
                    Font =  FontRepository.FindFont("Helvetica")
                }
            };
            var headerRow = table2.Rows.Add();
            headerRow.Cells.Add("Producto");
            headerRow.Cells.Add("Cantidad");
            headerRow.Cells.Add("Precio");
            headerRow.Cells.Add("Descuento");
            headerRow.Cells.Add("Total");
            

            var nombre = table.Rows[0]["Nombre"].ToString() + "\n\n";
            var center = new TextFragment(nombre);
            center.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(center);

            var separ = "----------------------------------------------------------------------------------------------------------------\n\n";
            var sep = new TextFragment(separ);
            sep.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            

            var sucursal = "Sucursal:  " + table.Rows[0]["Sucursal"].ToString() + "\n\n";
            var sucu = new TextFragment(sucursal);
            sucu.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(sucu);
            
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Sucursal:  " + ta   ble.Rows[0]["Sucursal"].ToString()));
            var direccion = "Direccion: " + table.Rows[0]["Direccion"].ToString() + "\n\n";
            var dire = new TextFragment(direccion);
            dire.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(dire);
            
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Direccion: " + table.Rows[0]["Direccion"].ToString()));
            var mesaje1 = table.Rows[0]["Mensaje1"].ToString() + "\n\n";
            var ms1 = new TextFragment(mesaje1);
            ms1.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(ms1);
            
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje1"].ToString()));
            var mesaje2 = table.Rows[0]["Mensaje2"].ToString() + "\n\n";
            var ms2 = new TextFragment(mesaje2);
            ms2.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(ms2);
            page.Paragraphs.Add(sep);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje2"].ToString()+ "\n"));
            //var header = "Producto" + "\t \t \t \t \t \t \t \t \t" + "Cantidad" + "\t\t  \t \t\t\t" + "Precio" + "\t \t\t\t \t\t" + "Descuento" + "\t\t \t\t \t\t" + "Total" + "\n";
            //var hdr = new TextFragment(header);
            //hdr.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Justify;



            //page.Paragraphs.Add(hdr);

            // page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Producto" + "\t\t" + "Cantidad" + "\t\t" + "Precio" + "\t\t" + "Descuento" + "\t\t" + "Total" + "\n"));
            //var content = "";
            foreach (DataRow av in table.Rows)

            {
                //content = av["Producto"].ToString() + "\t \t \t \t \t \t \t \t \t" + av["Cantidad"].ToString()  + "\t\t\t\t\t\t" + string.Format("{0:C2}", Convert.ToDecimal(av["Precio"])) + "\t\t\t\t\t\t" + string.Format("{0:C2}", Convert.ToDecimal(av["Descuento"])) + "\t\t\t\t\t\t" + string.Format("{0:C2}", Convert.ToDecimal(av["TotalProd"])) + "\n";
                
                //var cnt = new TextFragment(content);
                //cnt.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Justify;
                
                //page.Paragraphs.Add(cnt);
                var dataRow = table2.Rows.Add();
                dataRow.Cells.Add(av["Producto"].ToString());
                dataRow.Cells.Add(av["Cantidad"].ToString());
                dataRow.Cells.Add(string.Format("{0:C2}", Convert.ToDecimal(av["Precio"])));
                dataRow.Cells.Add(string.Format("{0:C2}", Convert.ToDecimal(av["Descuento"])));
                dataRow.Cells.Add(string.Format("{0:C2}", Convert.ToDecimal(av["TotalProd"])));

                //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(av["Producto"].ToString()+ "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Cantidad"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Precio"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Descuento"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["TotalProd"].ToString()+ "\n"));

            }
            page.Paragraphs.Add(table2);
            page.Paragraphs.Add(sep);
            var total = "Total: " + string.Format("{0:C2}", Convert.ToDecimal(table.Rows[0]["Total"].ToString())) + "\n\n";
            var tota = new TextFragment(total);
            tota.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(tota);

            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Total: "+table.Rows[0]["Total"].ToString()+ "\n"));
            var pago = "Su Pago: " + string.Format("{0:C2}", Convert.ToDecimal(table.Rows[0]["Pago"].ToString())) + "\n\n";
            var pa = new TextFragment(pago);
            pa.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(pa);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Su Pago: " + table.Rows[0]["Pago"].ToString() + "\n"));
            var cambio = "Cambio: " + string.Format("{0:C2}", Convert.ToDecimal(table.Rows[0]["Cambio"].ToString())) + "\n\n";
            var cam = new TextFragment(cambio);
            cam.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(cam);
            page.Paragraphs.Add(sep);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Cambio: " + table.Rows[0]["Cambio"].ToString() + "\n"));
            var mesaje3 = table.Rows[0]["Mensaje3"].ToString() + "\n\n";
            var ms3 = new TextFragment(mesaje3);
            ms3.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(ms3);
            page.Paragraphs.Add(sep);

            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje3"].ToString()));
            var mesaje4 = table.Rows[0]["Mensaje4"].ToString() + "\n\n";
            var ms4 = new TextFragment(mesaje4);
            ms4.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(ms4);
            page.Paragraphs.Add(sep);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(table.Rows[0]["Mensaje4"].ToString() + "\n"));



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
            var table2 = new Table
            {
                ColumnWidths = "87",
                Border = new BorderInfo(BorderSide.None, 1f, Aspose.Pdf.Color.DarkSlateGray),
                DefaultCellBorder = new BorderInfo(BorderSide.None, 0.5f, Aspose.Pdf.Color.Black),
                DefaultCellPadding = new MarginInfo(1.5, 10.5, 1.5, 10.5),
                Margin =
                {
                    Bottom = 10
                },
                DefaultCellTextState =
                {
                    Font =  FontRepository.FindFont("Helvetica")
                }
            };
            var headerRow = table2.Rows.Add();
            headerRow.Cells.Add("Numero");
            headerRow.Cells.Add("Producto");
            headerRow.Cells.Add("Motivo");
            headerRow.Cells.Add("Cantidad");
            headerRow.Cells.Add("Subtotal");
            headerRow.Cells.Add("Total");
            var nombre = "NOTA DE CREDITO" + "\n";
            var center = new TextFragment(nombre);
            center.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;



            page.Paragraphs.Add(center);
            var separ = "----------------------------------------------------------------------------------------------------------------\n\n";
            var sep = new TextFragment(separ);
            sep.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;

            var orde = "Orden #    " + table.Rows[0]["Recibo"].ToString() + "\n";
            var ord = new TextFragment(orde);
            ord.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(ord);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Orden #    "+table.Rows[0]["Recibo"].ToString() + "\n"));
            page.Paragraphs.Add(sep);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Numero" + "\t\t" + "Producto" + "\t\t" + "Motivo" + "\t\t" + "Cantidad" + "\t\t" + "Subtotal"+ "\t\t" + "Total"+ "\n"));
            foreach (DataRow av in table.Rows)

            {

               // page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(av["Articulo"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Nombre"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Motivo"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Cantidad"].ToString() + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + av["Subtotal"].ToString() +"t\t\t\t\t\t\t\t\t\t\t\t" + av["Total"].ToString() + "\n"));
                var dataRow = table2.Rows.Add();
                dataRow.Cells.Add(av["Articulo"].ToString());
                dataRow.Cells.Add(av["Nombre"].ToString());
                dataRow.Cells.Add(av["Motivo"].ToString());
                dataRow.Cells.Add(av["Cantidad"].ToString());
               
                dataRow.Cells.Add(string.Format("{0:C2}", Convert.ToDecimal(av["Subtotal"])));
                dataRow.Cells.Add(string.Format("{0:C2}", Convert.ToDecimal(av["TotalProd"])));
            }
            page.Paragraphs.Add(table2);
            page.Paragraphs.Add(sep);
            var total = "Total: " + string.Format("{0:C2}",tot) + "\n\n";
            var tota = new TextFragment(total);
            tota.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(tota);
            //page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Total: " + tot+ "\n"));
            


            // Save updated PDF
            var outputFileName = System.IO.Path.Combine(_dataDir, "Nota de Credito # " + table.Rows[0]["Recibo"].ToString() + ".pdf");
            document.Save(outputFileName);
        }
    }
}
