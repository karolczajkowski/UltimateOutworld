using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World {
    public class World {

        private static IWorld _world;

        public static IWorld Instance {
            get {
                if (_world == null) {
                    _world = new BaseWorld();
                    return _world;  
                }
                return _world;
            }
        }
    }
}
