using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            if (x == 1)
            {
                return 0;
            }

            double res = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);
            res = Math.Round(res, 3);
            return res;
            
        }

        
    }
}
