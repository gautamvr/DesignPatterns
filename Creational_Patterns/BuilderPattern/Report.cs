
namespace BuilderPattern
{
    public abstract class Report
    {   
        public abstract string ReportType { get; set; }
        public abstract string ReportHeader { get; set; }
        public abstract string ReportContent { get; set; }
        public abstract string ReportFooter { get; set; }

        public override string ToString()
        {
            return $"Report type : {ReportType}\n" +
                   $"Report Header : {ReportHeader}\n" +
                   $"Report Content : {ReportContent}\n" +
                   $"Report Footer : {ReportFooter}\n";
        }
    }
}
