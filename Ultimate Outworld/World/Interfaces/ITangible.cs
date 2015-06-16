using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Interfaces {
    /// <summary>
    /// A tangible object/mobile of the map, representation.
    /// </summary>
    public interface ITangible {

        Coordinates Coordinates { get; }
        CreationType CreationType { get; }
        long SerialNumber { get; }

    }
}
