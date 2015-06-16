using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Common;

namespace Ultimate_Outworld.World.Interfaces {
    interface IHasProperties {

        IList<ObjectProperty> Properties { get; }

        string GetObjProperty(string key);
        void SetObjProperty(string key, string value);
        void DeleteObjProperty(string key);

    }
}
