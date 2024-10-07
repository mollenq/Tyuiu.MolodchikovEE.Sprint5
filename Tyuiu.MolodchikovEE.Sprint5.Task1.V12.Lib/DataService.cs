using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolodchikovEE.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string output = "";
            for (int i = startValue; i <= stopValue; i++) 
            {

                double numerator = 5 * i + 2.5;
                double denominator = Math.Sin(i) - 2;

                if (denominator == 0)
                {
                    output += "0\n";
                }
                else 
                {
                    output += $"{Math.Round((numerator / denominator) + 2, 2)}\n";
                }
            } return output;
        }
    }
}
