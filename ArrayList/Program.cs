using System;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {  //Arraylist
            ArrayList obj = new ArrayList();
            Console.WriteLine(obj.Capacity); // 0
            obj.Add(100);
            Console.WriteLine(obj[0]); // 100
            Console.WriteLine(obj.Capacity); // 0
            obj.Add(200);
            obj.Add(300);
            obj.Insert(1,150);
            foreach(object O in obj)
            {
                Console.Write(O + " "); //100 150 200 300
            }
            obj.RemoveAt(2);
            foreach(object O in obj)
            {
                Console.Write(O + " ");//100 150 300
            }
        }
    }
}
