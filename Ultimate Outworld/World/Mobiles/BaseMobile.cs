using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Mobiles {

    [Serializable]
    public class BaseMobile {

        public virtual string Name { get; set; }
        public Coordinates Coordinates { get; private set; }

        public long SerialNumber { get; private set; }

        public virtual bool SetCoordinates(Coordinates coords) {
            if (CanSetCoordinates(coords)) {
                Coordinates = coords;
            }
        }
        public virtual bool CanSetCoordinates(Coordinates coords) {
            //TODO: Put logic here whether you can set the coords or not.
            return true;
        }

        public AccessLevel AccessLevel { get; private set; }
        public virtual void SetAccessLevel(AccessLevel level) {
            AccessLevel = level;
        }

        public virtual int SkillCap { get; private set; }
        public virtual int StatCap { get; private set; }

        public BaseMobile() {
            SerialNumber = World.Mobiles.Last()
        }



    }
}
