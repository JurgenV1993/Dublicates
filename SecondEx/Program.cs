using System;
using System.Collections.Generic;
using System.Linq;

namespace Dublicates
{
    class Program
    {
        private static List<ClassData> list;
        static void Main(string[] args)
        {
            int[] numbers = { 1, 7, 2, 4,7, 2, 3, 1, 7, 5 };
            countDublicate(numbers);
        }

        private static void countDublicate(int[] numbers)
        {
            list = new List<ClassData>();
            int i, j;
            for (i = 0; i < numbers.Length; i++)
            {
                int count = 0;

                if (list.Select(x => x.Value).Contains(numbers[i]))
                {
                    break;
                }
                for (j = 1 + i; j <= numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j - 1])
                    {
                        count++;
                    }
                }
                if (count>1) 
                {
                    list.Add(new ClassData
                    {
                        Value = numbers[i],
                        RepeatedTimes = count
                    });
                }
                
            }

            foreach (var item in list)
            {
                Console.WriteLine("Value: " + "==>" + item.Value + "Repeat times" + "==>" + item.RepeatedTimes);
            }
        }
    }

    public class ClassData
    {
        public int Value { get; set; }
        public int RepeatedTimes { get; set; }
    }
}
