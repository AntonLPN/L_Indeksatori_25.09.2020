using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Тема: Свойства и индексаторы
//Задание №1
//Создать собственный класс массив «MyArray» для имитации работы одномерного массива.
//В классе должны присутствовать:
//Поле – содержит количество записанных значений «count»
//Свойства
//•	размер массива «length»
//•	количество элементов в массиве «actual»
//•	количество элементов в массиве «free»


//Методы
//•	максимальный элемент в массиве  «Max».
//•	минимальный элемент в массиве «Min».

//Конструктор с параметром (задает размерность массива)

//Индексатор для обращения к элементам массива по индексу

//Предусмотреть возможность возникновения исключительной ситуации с выходом за пределы массива.


namespace L_Indeksatori_25._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //задаем размерность массиву внутри класса 10
            MyArray test=new MyArray(10);
            test[0] = 11;
            test[3] = 22;
            Console.WriteLine("Вывод метода free :");
            Console.WriteLine(test.Free);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Вывода метода actual :");
            Console.WriteLine(test.Actual);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Максимальное значение массива :");
            Console.WriteLine(test.Max());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Минимальное значение массива :");
            Console.WriteLine(test.Min());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Вывод отлавливания ошибки если index которому присваивают значение больше или меньше размера массива");
            try
            {
                test[11] = 99;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
              
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Вывод отлавливания ошибки если попытаться вывести згачение массива за пределами значений массива");
            try
            {
                Console.WriteLine(test[11]);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }
          
          
        }
    }
}
