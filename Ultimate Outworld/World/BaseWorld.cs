using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
