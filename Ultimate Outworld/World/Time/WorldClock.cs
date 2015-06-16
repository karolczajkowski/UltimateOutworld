using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Time {
    public class WorldClock : IWorldClock {

        private long _ticks;

        public WorldClock(IWorld world) {
            _ticks = world.Deserialize("Time")
        }

        public long Ticks {
            get { return _ticks; }
        }

        public void Tick() {
            _ticks++;
        }
    }
}
