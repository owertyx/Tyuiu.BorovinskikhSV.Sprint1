using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            if (x == 0)
            {
                return 0;
            }

            var res = Math.Cos(Math.PI / x) / (3 * Math.Exp(x + y));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
