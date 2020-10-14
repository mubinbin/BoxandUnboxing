using System;
using System.Collections.Generic;


namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> new_list = new List<object>();
            new_list.Add(7);
            new_list.Add(28);
            new_list.Add(-1);
            new_list.Add(true);
            new_list.Add("chair");

            int sum = 0;
            foreach(object element in new_list){

                Console.WriteLine(element);
                
                if(element is int){
                    Console.WriteLine($"this {element} is integer");
                    int i = (int) element; // safe unboxing can't be used on int, but explicit casting can. String can use safe unboxing
                    sum += i;
                }
            }
            Console.WriteLine($"the sum is {sum}");

        }
    }
}
