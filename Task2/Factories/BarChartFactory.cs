namespace Task2;

public class BarChartFactory : IChartFactory
{
    public IChart CreateChart()
    {
        return new BarChart();
    }
}
