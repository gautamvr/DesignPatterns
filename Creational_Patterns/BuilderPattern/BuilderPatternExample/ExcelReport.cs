

namespace BuilderPattern
{
    class ExcelReport:Report
    {
        public override string ReportType { get; set; }
        public override string ReportHeader { get; set; }
        public override string ReportContent { get; set; }
        public override string ReportFooter { get; set; }
    }
}
