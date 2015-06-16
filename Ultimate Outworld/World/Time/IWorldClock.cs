using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Time {
    interface IWorldClock {

        Int64 Ticks { get; }
        void Tick();

    }
}
