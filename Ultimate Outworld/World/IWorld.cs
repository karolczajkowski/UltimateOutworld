using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Mobiles;

namespace Ultimate_Outworld.World {
    interface IWorld {

        void Serialize();
        void Deserialize();

        event EventHandler Serialized;
        event EventHandler Deserialized;

        IList<BaseMobile> Mobiles { get; }

    }
}
