using System.Collections;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolodchikovEE.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            if (!double.TryParse(fileContent, out double x))
            {
                throw new FormatException("Содержимое файла не является допустимым вещественным числом.");
            }
            if (x == 0)
            {
                throw new InvalidOperationException("Значение из файла не может быть нулевым.");
            }
            double result = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);
            return result;
        }
    }
}
