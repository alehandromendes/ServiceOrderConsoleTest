// See https://aka.ms/new-console-template for more information

using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using ServiceOrderConsoleTest.Models;
using System.Net.Http.Headers;


namespace ServiceOrderConsoleTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            //Setando o caminho
            string caminho = @"D:\[DEV]\ConsoleApps\ServiceOrders\ServiceOrderConsoleTest\MakingPDF\pdf_files\" + "arquivo2.pdf";

            //Criando o arquivo
            PdfWriter writer= PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            // Abrindo o arquivo
            doc.Open();

            //Configurações de titulo
            Paragraph titulo = new Paragraph();
            titulo.Font = new Font(Font.FontFamily.COURIER, 40);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Teste\n\n"); //Titulo do arquivo

            //Adicionando ao documento
            doc.Add(titulo);

            Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 12)); //Segundo paragrafo (texto comum)
            string conteudo = "Testando arquivo\n\n";
            paragrafo.Add(conteudo); //adicionando ao paragrafo
            doc.Add(paragrafo); //adicionando ao documento

            //Criando tabela de dados
            PdfPTable table = new PdfPTable(3);
            table.AddCell("Linha 1, Coluna 1");
            table.AddCell("Linha 1, Coluna 2");
            table.AddCell("Linha 1, Coluna 3");

            table.AddCell("Linha 2, Coluna 1");
            table.AddCell("Linha 2, Coluna 2");
            table.AddCell("Linha 2, Coluna 3");

            table.AddCell("Linha 3, Coluna 1");
            table.AddCell("Linha 3, Coluna 2");
            table.AddCell("Linha 3, Coluna 3");

            doc.Add(table);

            doc.Close();

            System.Diagnostics.Process.Start(caminho);
        }   

    }
}