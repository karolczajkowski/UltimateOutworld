using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Mobiles;

namespace Ultimate_Outworld.World.Commands {
    interface ICommand {

        AccessLevel RequiredAccessLevel { get; }
        string Name { get; }
        void Execute(BaseMobile mobile, string args);
    }
}
