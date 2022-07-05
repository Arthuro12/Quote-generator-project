using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QuoteGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            GeneratePdf();
        }

        public void GeneratePdf()
        {
            string outFilePath = Environment.CurrentDirectory + "/voranschlag.pdf"; // Path of the file that will be generated
            
            Document doc = new Document(); // The document is created
            // We access an instance that will allow us to write in the document before generating the output file
            PdfWriter.GetInstance(doc, new FileStream(outFilePath, FileMode.Create));
            doc.Open();

            // Creation of the color palette
            BaseColor blue = new BaseColor(0, 75, 155);
            BaseColor gray = new BaseColor(240, 240, 240);
            BaseColor white = new BaseColor(255, 255, 255);

            // Writing font
            Font fontTitle = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);
            Font fontTable = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, 1, white);

            // Creation of page and paragraphs
            Paragraph paragraph1 = new Paragraph("Developer 2.0, " + myInformationTb.Text + "\n\n", fontTitle);
            paragraph1.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph("Der Kunde, " + clientInformationTb.Text + "\n\n", fontTitle);
            paragraph2.Alignment = Element.ALIGN_RIGHT;
            doc.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph("Voranschlag :  " + titleTb.Text + "\n\n", fontTitle);
            paragraph3.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragraph3);

            // Creation of the table of products
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;

            // Table cell
            AddCellToTable("Produktbezeichnung", fontTable, blue, table);
            AddCellToTable("Menge", fontTable, blue, table);
            AddCellToTable("Preis", fontTable, blue, table);

            // List of products
            string[] productInfos = new string[3];
            productInfos[0] = nameTb.Text;
            productInfos[1] = quantityTb.Text;
            productInfos[2] = priceTb.Text;

            foreach (string info in productInfos)
            {
                PdfPCell cell = new PdfPCell(new Phrase(info));
                cell.BackgroundColor = gray;
                cell.Padding = 7;
                cell.BorderColor = gray;
                table.AddCell(cell);
            }

            doc.Add(table);
            doc.Add(new Phrase("\n"));

            int totalPrice = int.Parse(priceTb.Text) * int.Parse(quantityTb.Text);
            Paragraph paragraph4= new Paragraph("Ergebnis :  " + totalPrice + "\n\n", fontTitle);
            paragraph4.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragraph4);

            // Close the document
            doc.Close();
            Process.Start(@"cmd.exe", @"/c " + outFilePath);
        }

        /// <summary>
        /// Add a cell to the table
        /// </summary>
        /// <param name="contentCell"></param>
        /// <param name="fontType"></param>
        /// <param name="color"></param>
        /// <param name="table"></param>
        public void AddCellToTable(string contentCell, Font fontType, BaseColor color, PdfPTable table)
        {
            PdfPCell cell = new PdfPCell(new Phrase(contentCell, fontType));
            cell.BackgroundColor = color;
            cell.Padding = 7;
            cell.BorderColor = color;
            table.AddCell(cell);
        }
    }
}
