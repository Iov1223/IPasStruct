using System;

namespace IPasStruct
{
    /// <summary>
    /// Класс работающий с массивом инициализированным как IP
    /// </summary>
    class ipADDR
    {
        /// <summary>
        /// ОбЪявление массива
        /// </summary>
        public int[] ip;
        /// <summary>
        /// Метод инициализирующий массив
        /// </summary>
        public ipADDR()
        {
            ip = new int[4] { 192, 168, 0, 1 };
        }
        /// <summary>
        /// Метод запрашивающий данные для ввода и изменяет изначальный массив
        /// </summary>
        public void Change()
        {
            Console.WriteLine("Введиете другие значения:");
            ip = new int[4];
            bool Flag = true;

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    ip[i] = int.Parse(Console.ReadLine());
                    if (ip[i] < 0 || ip[i] > 255)
                    {
                        Console.WriteLine("Неверный формат! Ведите еще раз:");
                        Flag = false;
                    }
                    else
                        Flag = true;
                } while (Flag != true);
            }
        }
        /// <summary>
        /// Метод выводящий значения элементов массива на экран
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(ip[i]);
                if (i < 3)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

    }
    /// <summary>
    /// Класс работающий с массивом инициализированным как MASK 
    /// наследующий методы IP
    /// </summary>
    class ipMASK : ipADDR
    {
        public ipMASK()
        {
            ip = new int[4] { 255, 255, 255, 0 };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ipADDR myIP = new ipADDR();
            myIP.Print();
            myIP.Change();
            myIP.Print();
            ipMASK myMask = new ipMASK();
            myMask.Print();
            myMask.Change();
            myMask.Print();

        }
    }
}