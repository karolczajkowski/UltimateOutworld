using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Common;
using Ultimate_Outworld.World.Helpers;
using Ultimate_Outworld.World.Interfaces;
using Ultimate_Outworld.World.Mobiles;

namespace Ultimate_Outworld.World.Items {
    [Serializable]
    public class BaseItem : ITangible, IHasProperties {

        private List<ObjectProperty> _properties;

        public virtual long SerialNumber { get; private set; }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual bool Locked { get; set; }
        public virtual Coordinates Coordinates { get; private set; }

        public virtual void SetCoordinates(Coordinates coords) {
            
        }

        public BaseItem(Coordinates coords) {
            _properties = new List<ObjectProperty>();
            SetCoordinates(coords);
        }

        public virtual bool Use(BaseMobile user) {
            if (!IsAccessible(user)) {
                return false;
            }
            return true;
        }

        public virtual bool IsAccessible(BaseMobile mobile) {
            if (Distance.Calculate(mobile, this) > 4) {
                return false;
            }
            return true;
        }


        public IList<Common.ObjectProperty> Properties {
            get { return _properties; }
        }

        public CreationType CreationType {
            get {
                return CreationType.Item;
            }
        }

        public virtual string GetObjProperty(string key) {
            return (Properties.FirstOrDefault(p => p.Key.ToLower() == key) == null) ? "N/A" : Properties.First(p => p.Key.ToLower() == key).Value;
        }

        public virtual void SetObjProperty(string key, string value) {
            var existingProp = GetObjProperty(key);
            if (existingProp != "N/A") {
                Properties.Add(new ObjectProperty(key) {Value = value});
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
