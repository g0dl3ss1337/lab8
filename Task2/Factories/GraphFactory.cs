namespace Task2;

public class GraphFactory
{
    public IChart CreateChart(string chartType)
    {
        switch (chartType.ToLower())
        {
            case "line":
                return new LineChartFactory().CreateChart();
            case "bar":
                return new BarChartFactory().CreateChart();
            case "pie":
                return new PieChartFactory().CreateChart();
            default:
                return null; // Невірний вибір
        }
    }
}
