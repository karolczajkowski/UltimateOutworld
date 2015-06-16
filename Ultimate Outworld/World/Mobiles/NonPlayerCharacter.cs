using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Mobiles {
    class NonPlayerCharacter : BaseMobile {

        // NPCs do not need to have access level
        public override void SetAccessLevel(AccessLevel level) {
            return;
        }
    }
}
