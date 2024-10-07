using Tyuiu.MolodchikovEE.Sprint5.Task0.V25.Lib;
namespace Tyuiu.MolodchikovEE.Sprint5.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в те*");
            Console.WriteLine("*екстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх*");
            Console.WriteLine("*х знаков после запятой.                                                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 3;
            var result = ds.SaveToFileTextData(x);
            string filePath = "OutPutFileTask0.txt";
            File.WriteAllText(filePath, result.ToString());

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}