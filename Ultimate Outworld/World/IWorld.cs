using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Interfaces;
using Ultimate_Outworld.World.Mobiles;

namespace Ultimate_Outworld.World {
    public interface IWorld {

        void Serialize();
        void Deserialize();

        event EventHandler Serialized;
        event EventHandler Deserialized;

        IList<BaseMobile> Mobiles { get; }
        ITangible GetObjectBySerialNumber(long serialNumber);

        void MobileSpawned(BaseMobile mobile);
        void MobileDied(BaseMobile mobile);



    }
}
