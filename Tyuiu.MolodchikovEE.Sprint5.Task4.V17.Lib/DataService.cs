using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolodchikovEE.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }
            string fileContent = File.ReadAllText(path);
            double.TryParse(fileContent, out double x);
            double result = Math.Round(Math.Sin(2/(3*x)) + Math.Pow(x,2),3);
            return result;
        }
    }
}
