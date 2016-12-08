using System;
using System.Linq;

namespace lab4_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ui u = new ui();
            bool work = true;
            while (work == true)
            {
                u.menu();
                u.casein();
            }
            
        }
        
    }

}
