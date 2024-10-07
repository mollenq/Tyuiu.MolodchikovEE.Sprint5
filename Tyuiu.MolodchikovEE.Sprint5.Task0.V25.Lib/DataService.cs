using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MolodchikovEE.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            double result = (3 * (Math.Pow(x,4) + 1) ) / (Math.Pow(x,3));
            return result.ToString();
        }
    }
}
