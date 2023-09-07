using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_array_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name_value;
            Console.WriteLine("please enter how many names you want to enter");
            int len = Convert.ToInt32(Console.ReadLine());
            name_value = new string[len];
            for (int j = 0; j< len; j++ )
            {
                Console.WriteLine("please enter name");
                name_value[j]=Console.ReadLine();
            }
            for (int i = 0; i < name_value.Length; i++)
            {
                Console.WriteLine(name_value[i]);
            }
        Console.ReadKey();


        }
    }
}
