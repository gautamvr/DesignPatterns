

namespace BuilderPattern
{
    class ExcelReportBuilder:IReportBuilder
    {
        private Report _excelReport;

        public ExcelReportBuilder()
        {
            _excelReport = new ExcelReport();
        }

        public void BuildReportType()
        {
            _excelReport.ReportType = "Excel - .xlsx";
        }

        public void BuildReportHeader()
        {
            _excelReport.ReportHeader = "Excel Header";
        }

        public void BuildReportFooter()
        {
            _excelReport.ReportFooter = "Excel Footer";
        }

        public void BuildReportContent()
        {
            _excelReport.ReportContent = "Contents inside Excel report";
        }

        public Report GetReport()
        {
            return _excelReport;
        }
    }
}
