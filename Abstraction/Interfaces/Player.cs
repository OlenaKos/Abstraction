using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Player : IRecordable, IPlayable
    {
        void IRecordable.Pause()
        {
            Console.WriteLine("Record paused");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Play paused");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Play started");
        }

        void IRecordable.Record()
        {
            Console.WriteLine("Record started");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Record stopped");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing stopped");
        }
    }
}
