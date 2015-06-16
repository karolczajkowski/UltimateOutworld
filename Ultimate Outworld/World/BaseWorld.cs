using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Interfaces;

namespace Ultimate_Outworld.World {
    public class BaseWorld : IWorld {

        public void Serialize() {
            throw new NotImplementedException();
        }

        public void Deserialize() {
            throw new NotImplementedException();
        }

        public event EventHandler Serialized;

        public event EventHandler Deserialized;

        public IList<Mobiles.BaseMobile> Mobiles {
            get { throw new NotImplementedException(); }
        }

        public virtual void MobileSpawned(Mobiles.BaseMobile mobile) {
            Mobiles.Add(mobile);
        }

        public virtual void MobileDied(Mobiles.BaseMobile mobile) {
            Mobiles.Remove(mobile);
        }

        public ITangible GetObjectBySerialNumber(long serialNumber) {
            return Mobiles.FirstOrDefault(m => m.SerialNumber == serialNumber);
        }
    }
}
