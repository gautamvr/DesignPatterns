namespace BuilderPattern
{
    public interface IReportBuilder
    {
        void BuildReportType();
        void BuildReportHeader();
        void BuildReportFooter();
        void BuildReportContent();
        Report GetReport();

    }
}