using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets make some bubbles!\r\n");

            BlueBubble BlueBubble = new BlueBubble();
            GreenBubble GreenBubble = new GreenBubble();
            RedBubble RedBubble = new RedBubble();

            Console.ReadKey();
        }
    }
}
