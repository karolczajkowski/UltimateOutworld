using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Common;
using Ultimate_Outworld.World.Interfaces;

namespace Ultimate_Outworld.World.Mobiles {

    [Serializable]
    public class BaseMobile : ITangible, IHasProperties {

        private List<ObjectProperty> _properties;

        public virtual string Name { get; set; }
        public Coordinates Coordinates { get; private set; }

        public long SerialNumber { get; private set; }

        public virtual bool SetCoordinates(Coordinates coords) {
            if (CanSetCoordinates(coords)) {
                Coordinates = coords;
                return true;
            }
            return false;
        }
        public virtual bool CanSetCoordinates(Coordinates coords) {
            //TODO: Put logic here whether you can set the coords or not.
            return true;
        }

        public AccessLevel AccessLevel { get; private set; }
        public virtual void SetAccessLevel(AccessLevel level) {
            AccessLevel = level;
        }

        public virtual int SkillCap { get; private set; }
        public virtual int StatCap { get; private set; }

        public BaseMobile(Coordinates coords) {
            var lastMobile = World.Instance.Mobiles.OrderBy(m => m.SerialNumber).FirstOrDefault();
            if (lastMobile == null) {
                SerialNumber = 10000;
            }
            else {
                SerialNumber = World.Instance.Mobiles.OrderBy(m => m.SerialNumber).First().SerialNumber + 1;    
            }

            _properties = new List<ObjectProperty>();
            SetCoordinates(coords);
            World.Instance.MobileSpawned(this);
        }

        public virtual bool Die(ITangible killer) {
            SetObjProperty("Killer", killer.SerialNumber.ToString());
            return true;
        }

        public virtual CreationType CreationType {
            get { return CreationType.Mobile; }
        }

        public IList<Common.ObjectProperty> Properties {
            get { return _properties; }
        }

        public virtual string GetObjProperty(string key) {
            return (Properties.FirstOrDefault(p => p.Key.ToLower() == key) == null) ? "N/A" : Properties.First(p => p.Key.ToLower() == key).Value;
        }

        public virtual void SetObjProperty(string key, string value) {
            var existingProp = GetObjProperty(key);
            if (existingProp != "N/A") {
                Properties.Add(new ObjectProperty(key) { Value = value });
            } else {
                Properties.FirstOrDefault(p => p.Key.ToLower() == key).Value = value;
            }
        }

        public virtual void DeleteObjProperty(string key) {
            var existingProp = GetObjProperty(key);
            if (existingProp == "N/A") {
                return;
            } else {
                Properties.Remove(Properties.FirstOrDefault(p => p.Key.ToLower() == key));
            }
        }
    }
}
