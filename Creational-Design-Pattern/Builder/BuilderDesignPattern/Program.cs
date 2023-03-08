
using BuilderDesignPattern;

Report report;
ReportDirector reportDirector = new ReportDirector();

// Construct and display PDF Reports
PDFReport pdfReport = new PDFReport();
report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();

Console.WriteLine("-------------------");

// Construct and display Excel Reports
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();