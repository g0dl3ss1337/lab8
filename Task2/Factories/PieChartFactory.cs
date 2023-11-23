namespace Task2;

public class PieChartFactory : IChartFactory
{
    public IChart CreateChart()
    {
        return new PieChart();
    }
}
