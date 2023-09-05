using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program

{
    public static void Main()
    {
        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
        m1.Vastus();

        for (int i = 0; i < 10; i++) { m1.AddLike(); }

        Console.WriteLine(m1.GetPopularity());

        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        m2.Vastus();

        for (int i = 0; i < 1000; i++) { m2.AddLike(); }
        
        Console.WriteLine(m2.GetPopularity());

        Console.Write(m1.GetPopularityInfo(m1.GetPopularity(),m2.GetPopularity()));
        Message m4 = new Message("Hello", "Johny", DateTime.Now.AddDays(-3));
        Message m5 = new Message("Privet", "Mark", DateTime.Now.AddDays(-5));
        List<Message> list = new List<Message>();
        list.Add(m1);
        list.Add(m2);
        list.Add(m4);
        list.Add(m5);
        Console.WriteLine(m1.GetPopularityInfoN(list));

        
        
        List<Message> list1 = new List<Message>();
        Random r = new Random();
        Message m = new Message();
        int Mcount=r.Next(1, 10);
        for (int i = 0; i < Mcount; i++)
        {
            Console.WriteLine("Sõnume sisu: ");
            string c = Console.ReadLine();
            Console.WriteLine("Sõnume autor: ");
            string a = Console.ReadLine();
            int t = -1*r.Next(0, 1000000000);
            DateTime dhm= DateTime.Now.Date.AddSeconds(t);//Now()
            m = new Message(c, a, dhm);
            for(int j = 0; j< r.Next(1, 1000); j++)
            {
                m.AddLike();

            }
            list.Add(m);
            m.Vastus();


        }
        Console.WriteLine(m.GetPopularityInfoN(list));
        







    }
}















