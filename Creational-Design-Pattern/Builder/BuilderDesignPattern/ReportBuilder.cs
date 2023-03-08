namespace BuilderDesignPattern;

public abstract class ReportBuilder
{
    protected Report reportObject;

    public abstract void SetReportType();
    public abstract void SetReportHeader();
    public abstract void SetReportFooter();
    public abstract void SetReportContent();

    public void CreateNewReport()
    {
        reportObject = new Report();
    }

    public Report GetReport()
    {
        return reportObject;
    }
}
