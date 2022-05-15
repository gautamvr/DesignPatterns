
namespace BuilderPattern
{
    class PdfReportBuilder:IReportBuilder
    {
        private Report _pdfReport;

        public PdfReportBuilder()
        {
            _pdfReport = new PdfReport();
        }

        public void BuildReportType()
        {
            _pdfReport.ReportType = "PDF - .pdf";
        }

        public void BuildReportHeader()
        {
            _pdfReport.ReportHeader = "PDF Header";
        }

        public void BuildReportFooter()
        {
            _pdfReport.ReportFooter = "PDF Footer";
        }

        public void BuildReportContent()
        {
            _pdfReport.ReportContent = "PDF Content";
        }

        public Report GetReport()
        {
            return _pdfReport;
        }
    }
}
