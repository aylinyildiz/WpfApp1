using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RightButtonClick(object sender, RoutedEventArgs e)
        {
            page2.Visibility = Visibility.Visible;
            page1.Visibility = Visibility.Hidden;
            
        }

        private void LeftButtonClick(object sender, RoutedEventArgs e)
        {
            page1.Visibility = Visibility.Visible;
            page2.Visibility = Visibility.Hidden;
        }

        private void printbutton(object sender, RoutedEventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog();
            //List<Grid> mainWindows= new List<Grid>();
            //DocumentPaginator documentPaginator = new DocumentPaginator();

          
            //mainWindows.Add(page1);
            //mainWindows.Add(page2);

            //printDialog.PrintDocument(documentPaginator, "text");

            //printDialog.ShowDialog();

        }

        //public void ExportToPdf(DataTable dt)
        //{
        //    Document document = new Document();
        //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("c://sample.pdf", FileMode.Create));
        //    document.Open();

        //    Font font5 = FontFactory.GetFont(FontFactory.HELVETICA, 5);

        //    PdfPTable table = new PdfPTable(dt.Columns.Count);

        //    Array floatArray = Array.CreateInstance(typeof(float), dt.Columns.Count);
        //    //float[] widths = new float[] { };
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //        floatArray.SetValue(4f, i);

        //    table.SetWidths((float[])floatArray);

        //    table.WidthPercentage = 100;
        //    PdfPCell cell = new PdfPCell(new Phrase("Products"));

        //    cell.Colspan = dt.Columns.Count;

        //    foreach (DataColumn c in dt.Columns)
        //    {
        //        table.AddCell(new Phrase(c.ColumnName, font5));
        //    }

        //    foreach (DataRow r in dt.Rows)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            for (int i = 0; i < dt.Columns.Count; i++)
        //            {
        //                table.AddCell(new Phrase(r[i].ToString(), font5));
        //            }
        //        }
        //    }
        //    document.Add(table);
        //    document.Close();
        //}
    }
}
