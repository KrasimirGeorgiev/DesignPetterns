namespace Builder
{
    // The following concrete Builder implements the ReportBuilder abstract class
    // and provides specific implementation of the steps for creating a Excel Report
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
