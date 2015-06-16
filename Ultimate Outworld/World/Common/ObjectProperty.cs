using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Outworld.World.Common {
    public class ObjectProperty {

        public string Key { get; private set; }
        public string Value { get; set; }

        public ObjectProperty(string key) {
            Key = key;
        }
    }
}
