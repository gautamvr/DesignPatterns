
namespace BuilderPattern
{
    class ReportBuildDirector
    {
        private IReportBuilder _reportBuilder;

        public void MakeReport(IReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
            _reportBuilder.BuildReportType();
            _reportBuilder.BuildReportHeader();
            _reportBuilder.BuildReportContent();
            _reportBuilder.BuildReportFooter();
        }

        public Report GetReport()
        {
            return _reportBuilder.GetReport();
        }
    }
}
