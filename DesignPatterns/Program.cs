using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Code
            Report report;
            Director reportDirector = new Director();

            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");


            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }
    }
   
}
