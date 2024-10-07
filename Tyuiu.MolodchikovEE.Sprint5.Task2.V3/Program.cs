using Tyuiu.MolodchikovEE.Sprint5.Task2.V3.Lib;
namespace Tyuiu.MolodchikovEE.Sprint5.Task2.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись структурированных данных в текстовый файл            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                            *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значения*");
            Console.WriteLine("*ями с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохр*");
            Console.WriteLine("*ранить в файл OutPutFileTask2.csv и вывести на консоль. 5; 9; 1 - 1; 3; 9*");
            Console.WriteLine("*9 - 1; 2; 2                                                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.YOURFUNCTION();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}