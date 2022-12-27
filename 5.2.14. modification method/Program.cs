using System;

namespace mynamespase
{
    class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] result)
        {
            int number = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        number = result[i];
                        result[i] = result[j];
                        result[j] = number;
                    }
            return result;



            //for (int k = 0; k < result.Length; k++)
            //{
            //    Console.Write(result[k] + " ");
            //}


        }
        public static void Main(string[] args)
        {
            var array = GetArrayFromConsole();

            var sortedarray = SortArray(array);

        }
    }
}