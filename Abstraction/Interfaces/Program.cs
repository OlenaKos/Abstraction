using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();

            IRecordable irec = player;
            IPlayable ipl = player;

            irec.Record();
            irec.Pause();
            irec.Stop();
            Console.WriteLine();
            ipl.Play();
            ipl.Pause();
            ipl.Stop();

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
