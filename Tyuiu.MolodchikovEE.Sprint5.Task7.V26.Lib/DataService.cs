using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolodchikovEE.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string fileContent = File.ReadAllText(path);
            string pattern = @"\b[A-Za-z]+\b";
            string modifiedContent = Regex.Replace(fileContent, pattern, "word");
            string output = Path.GetTempPath();
            File.WriteAllText(output, modifiedContent);
            return output;
        } 
    }
}
