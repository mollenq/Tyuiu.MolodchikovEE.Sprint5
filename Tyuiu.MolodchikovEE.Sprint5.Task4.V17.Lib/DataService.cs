using System.Collections;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolodchikovEE.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            //string tempFilePath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V17.txt");
            //double.TryParse(path, out double x);
            //Console.WriteLine(x);
            //double result = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);

            double x = Double.Parse(File.ReadAllText(path));
            double result = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);
            return result;
        }
    }
}
