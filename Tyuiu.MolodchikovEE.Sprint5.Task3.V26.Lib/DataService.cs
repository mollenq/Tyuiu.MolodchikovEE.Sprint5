using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MolodchikovEE.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        
        public string SaveToFileTextData(int x)
        {
            double calculation = Math.Round((0.7 * (Math.Pow(x, 3))) + (1.52 * (Math.Pow(x, 2))), 3);
            byte[] byteArray;
            byteArray = BitConverter.GetBytes(calculation);
            string base64String = Convert.ToBase64String(byteArray);
            return base64String;
        }
    }
}
