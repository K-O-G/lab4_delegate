using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_delegate
{
    class ui
    {
        public Processing_eventer p_e = new Processing_eventer();
        public void menu()
        {
            Console.WriteLine("1. Create stack");
            Console.WriteLine("2. Push data in stack");
            Console.WriteLine("3. Pop data in stack");
            Console.WriteLine("4. Peek Stack");
            Console.WriteLine("5. Determination of the number of the first given character in a  line");
        }
        public bool casein()
        {
            int swtch = Convert.ToInt32(Console.ReadLine());
            switch (swtch)
            {
                case 1:
                    p_e.InitializationStack();
                    break;
                case 2:
                    p_e.PushData();
                    break;
                case 3:
                    p_e.PopData();
                    break;
                case 4:
                    p_e.PeekData();
                    break;
                case 5:
                    p_e.Determination();
                    break;
                case 6:
                    return false;
                default:
                    Console.WriteLine("Sorry, wrong answer");
                    break;
            }
            return false;
        }
    }
}
