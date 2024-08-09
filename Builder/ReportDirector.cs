namespace Builder
{
    public class ReportDirector
    {
        // The director is only responsible for executing the building steps in a particular order
        // It is helpful when producing products accordig to a specific order or configuration
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
