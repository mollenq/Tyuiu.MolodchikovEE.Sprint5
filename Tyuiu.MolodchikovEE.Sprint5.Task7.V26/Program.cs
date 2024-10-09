using Tyuiu.MolodchikovEE.Sprint5.Task7.V26.Lib;
namespace Tyuiu.MolodchikovEE.Sprint5.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine(@"*Дан файл С:\DataSprint5\InPutDataFileTask7V26.txt (файл взять из архива с*");
            Console.WriteLine(@"*согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопир*");
            Console.WriteLine("*ровать в неё файл) в котором есть набор символьных данных.Заменить все ан*");
            Console.WriteLine("*нглийские слова на слово word.Полученный результат сохранить в файл Out*");
            Console.WriteLine("*tPutDataFileTask7V26.txt.                                                *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V26.txt";
            var result = ds.LoadDataAndSave(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}