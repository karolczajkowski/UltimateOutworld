using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World {
    public enum AccessLevel {
        Player = 0,
        Counsellor = 1,
        Seer = 2,
        GameMaster = 3,
        Admin = 4
    }

    public enum CreationType {
        Account,
        Character,
        Mobile,
        Item,
        Multi
    }
}
