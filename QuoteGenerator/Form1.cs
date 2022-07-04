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



            // Close the document
            doc.Close();
            Process.Start(@"cmd.exe", @"/c " + outFilePath);
        }
    }
}
