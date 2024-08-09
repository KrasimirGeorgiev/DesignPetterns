namespace Builder
{
    // The following concrete Builder implements the ReportBuilder abstract class
    // and provides specific implementation of the steps for creating a PdfReport
    public class PdfReport : ReportBuilder
    {
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Pdf Header";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "Pdf Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Pdf Footer";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Pdf";
        }
    }
}
