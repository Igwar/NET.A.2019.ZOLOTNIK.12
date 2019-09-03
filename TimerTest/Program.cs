using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerLib;
namespace TimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer { Time = 5 };
            var listn1 = new Listner1();
            var listn2 = new Listner2();

            timer.TimeIsOver += listn1.Messege;
            timer.TimeIsOver += listn2.Messege;

            timer.Start("Start");
        }
          public sealed class Listner1
    {


              public void Messege(object sender, TimeIsOverEventArgs e)
        {
            Console.WriteLine("Lisner1");
        }
    }
          public sealed class Listner2
    {
        

        public void Messege(object sender, TimeIsOverEventArgs e)
        {
            Console.WriteLine("Listner2");
        }
    }
    }
}
