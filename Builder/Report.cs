namespace Builder
{
    //Product
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public string ReportFooter { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine($"Report Type: {ReportType}");
            Console.WriteLine($"Header: {ReportHeader}");
            Console.WriteLine($"Content: {ReportContent}");
            Console.WriteLine($"Footer: {ReportFooter}");
        }
    }
}

// It makes sense to use the Builder design pattern when your products are quite complex
// and require an extensive configuration.
// Using the following Report Product class, we can configure different types of Product