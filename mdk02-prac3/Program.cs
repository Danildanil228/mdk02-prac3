//шаблонный метод

    
// базовые генераторы отчетов в разных форматах, вызов переопределенных методов
ReportGenerator pdfReport = new PdfReportGenerator();
pdfReport.GenerateReport();

Console.WriteLine();

ReportGenerator excelReport = new ExcelReportGenerator();
excelReport.GenerateReport();

Console.WriteLine();

ReportGenerator htmlReport = new HtmlReportGenerator();
htmlReport.GenerateReport();


// методы, 
abstract class ReportGenerator
{
    public void GenerateReport()
    {
        GenerateHeader();
        GenerateBody();
        GenerateFooter();
        SaveReport();
    }

    protected abstract void GenerateHeader();
    protected abstract void GenerateBody();
    protected abstract void GenerateFooter();
    protected virtual void SaveReport()
    {
        Console.WriteLine("Сохранение отчета...");
    }
}

// PDF
class PdfReportGenerator : ReportGenerator
{
    protected override void GenerateHeader()
    {
        Console.WriteLine("PDF HEADER");
    }

    protected override void GenerateBody()
    {
        Console.WriteLine("PDF BODY");
    }

    protected override void GenerateFooter()
    {
        Console.WriteLine("PDF FOOTER");
    }

    protected override void SaveReport()
    {
        Console.WriteLine("сохранение...");
    }
}

// EXEL
class ExcelReportGenerator : ReportGenerator
{
    protected override void GenerateHeader()
    {
        Console.WriteLine("EXEL HEADER");
    }

    protected override void GenerateBody()
    {
        Console.WriteLine("EXEL BODY");
    }

    protected override void GenerateFooter()
    {
        Console.WriteLine("EXEL FOOTER");
    }

    protected override void SaveReport()
    {
        Console.WriteLine("сохранение...");
    }
}

// HTML
class HtmlReportGenerator : ReportGenerator
{
    protected override void GenerateHeader()
    {
        Console.WriteLine("HTML FOOTER");
    }

    protected override void GenerateBody()
    {
        Console.WriteLine("HTML BODY");
    }

    protected override void GenerateFooter()
    {
        Console.WriteLine("HTML FOOTER");
    }

    protected override void SaveReport()
    {
        Console.WriteLine("сохранение..");
    }
}
