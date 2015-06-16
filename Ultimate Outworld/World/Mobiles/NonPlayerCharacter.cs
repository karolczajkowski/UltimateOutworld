using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Interfaces;

namespace Ultimate_Outworld.World.Mobiles {
    class NonPlayerCharacter : BaseMobile {

        // NPCs do not need to have access level
        public override void SetAccessLevel(AccessLevel level) {
            return;
        }

        public override bool Die(ITangible killer) {
            return base.Die(killer);
        }

        public NonPlayerCharacter(Coordinates coords) : base(coords) {
            
        }

    }
    }
}
