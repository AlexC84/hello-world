using System;

namespace hello_world
{
    public class SystemOfMeasurement
    {
        public SystemOfMeasurement(){
            /* initiate system with;
             base dimensions
             base units
            */
        }
    }

    public class BaseDimension{
        public string Symbol { get; private set; }
        public string Name { get; private set; }
        public BaseUnit BaseUnit { get; private set; }

    }

    public class BaseUnit
    {
        public string Symbol { get; private set; }
        public string Name { get; private set; }
    }
}
