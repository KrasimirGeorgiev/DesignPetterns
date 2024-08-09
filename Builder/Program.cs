// Builder design pattern is about separating the construction process of a complex object from it's representation,
//  allowing the same construction process to create different representations.

// The builder pattern builds a complex object using simple objects and a step-by-step approach. The process of 
//  construction should be so generic that the same construction process can be used to create different representations 
//  of the same complex object.

// Constructing a report
// Step 1: Create a Builder object
// Step 2: Create a Director and pass to it the Builder object through the MakeReport method
// Step 3: Display the report by calling the DisplayReport method of the Product

using Builder;

PdfReport pdfReport = new PdfReport();
ReportDirector reportDirector = new ReportDirector();
Report report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();

Console.WriteLine("-----------------");

ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();