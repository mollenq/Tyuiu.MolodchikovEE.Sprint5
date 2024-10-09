using Tyuiu.MolodchikovEE.Sprint5.Task5.V9.Lib;
namespace Tyuiu.MolodchikovEE.Sprint5.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение набора данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                            *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine(@"*Дан файл С:\DataSprint5\InPutDataFileTask5V9.txt (файл взять из архива со*");
            Console.WriteLine(@"*огласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопиро*");
            Console.WriteLine("*овать в неё файл) в котором есть набор значений.Найти максимальное целое *");
            Console.WriteLine("* число в файле. Полученный результат вывести на консоль. У вещественных з*");
            Console.WriteLine("*значений округлить до трёх знаков после запятой.                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
            var result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}