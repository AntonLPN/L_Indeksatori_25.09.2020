using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Indeksatori_25._09._2020
{
    class MyArray
    {
        int size_arr;
        int[] arr;
        int count;


        public MyArray()
        {
            size_arr = 1;
            arr = new int[size_arr];
            count = 0;

        }

        public MyArray(int size_arr)
        {
            this.size_arr = size_arr;
            arr = new int[this.size_arr];
        }

        //•	размер массива «length»
        //сформировано автоматической подсказкой после написания свойства с одним геттером
        public int Length => size_arr;

        //•	количество элементов в массиве «actual»
        public int Actual
        {
            get
            {
                int actual = 0;

                for (int i = 0; i < this.arr.GetLength(0); i++)
                {

                    if (arr[i] != 0)
                    {
                       actual++;
                    }
                }

                count = actual;
                return count;
            }

        }
        

        //•	количество элементов в массиве «free»(свободных)
        public int Free
        {
            get
            {
                
                for (int i = 0; i < this.arr.GetLength(0); i++)
                {
               
                    if (arr[i]!=0)
                    {
                        count++;
                    }
                }

                int free = size_arr - count;
                return free;
            }
        }
        //присвоение значение по индексу или обращение по индексу
        public int this[int index]
        {
            get
            {
                try
                {
                    if (index > size_arr || index < 0)
                    {
                        throw new OverflowException();
                    }
                    else
                    {


                        return arr[index];
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
                
               
            }
            set
            {
                try
                {
                    if (index > size_arr || index < 0)
                    {
                        throw new OverflowException();
                    }
                    this.arr[index] = value;
                   

                }
                catch (OverflowException ex)
                {
                    throw ex;
                }

            }

        }

        //
        //Методы
        //•	максимальный элемент в массиве  «Max».
        public int  Max()
        {
            int max = arr[0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        public int Min()
        {
            int min = arr[0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

    }
}
