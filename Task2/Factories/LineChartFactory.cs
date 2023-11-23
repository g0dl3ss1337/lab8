namespace Task2;

public class LineChartFactory : IChartFactory
{
    public IChart CreateChart()
    {
        return new LineChart();
    }
}
