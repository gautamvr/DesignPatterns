using System;

namespace BuilderPattern
{
    class BuilderPatternExample
    {
        static void Main(string[] args)
        {
            var reportbuildDirector = new ReportBuildDirector();

            //Build a pdf report
            IReportBuilder pdfbuilder= new PdfReportBuilder();
            reportbuildDirector.MakeReport(pdfbuilder);

            Report pdfReport = reportbuildDirector.GetReport();
            Console.WriteLine($"Report generated is : \n\n{pdfReport}");

            Console.WriteLine("\n-------------------------------------------\n");

            //Now, Building an excel report
            IReportBuilder excelBuilder = new ExcelReportBuilder();
            reportbuildDirector.MakeReport(excelBuilder);

            Report excelReport = reportbuildDirector.GetReport();
            Console.WriteLine($"Report generated is : \n\n{excelReport}");
            Console.ReadKey();
        }
    }
}
