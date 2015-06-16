using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Outworld.World.Interfaces;

namespace Ultimate_Outworld.World.Helpers {
    public class Distance {

        public static int Calculate(ITangible source, ITangible destination) {
            return Calculate(source.Coordinates, destination.Coordinates);
        }

        public static int Calculate(Coordinates source, Coordinates destination) {
            var deltaX = source.X - destination.X;
            var deltaY = source.Y - destination.Y;
            var deltaZ = source.Z - destination.Z;
            return Convert.ToInt32(Math.Sqrt((deltaX^2) + (deltaY^2) + (deltaZ^2)));
        }
    }
}
