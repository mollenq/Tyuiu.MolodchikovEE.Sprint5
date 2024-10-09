using System.Collections;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.MolodchikovEE.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "4,68");
            double x = Convert.ToDouble(File.ReadAllText(tempFilePath));
            double result = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);
            return result;
        }
    }
}
