using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Commands {
    public class Version : ICommand {

        public AccessLevel RequiredAccessLevel {
            get { return AccessLevel.Player; }
        }

        public void Execute(Mobiles.BaseMobile mobile, string args) {
            if (mobile.AccessLevel < RequiredAccessLevel) {
                return;
            }
        }


        public string Name {
            get { return "version"; }
        }
    }
}
