using System;

namespace _1._19.ConfirmZeroValidInValueType
{
    class Program
    {
        // 确保0是值类型中有效的状态

        // 创建枚举类型时，保证 0 位模式是有效的状态
        // struct 和 enum 值类型的默认初始化，要能保证0值时一个有效的值。


        static void Main(string[] args)
        {

            Planet planet = new Planet();
            Console.WriteLine(planet);// 输出为 0 ，但是这个0不是一个有效的值

            Planet planet1 = Planet.Mercury;// 强迫所有使用者都显示初始化值：
            Console.WriteLine(planet1);

            // d 里面，planet 是无效的，magnitude 是有效的
            ObservationData d = new ObservationData();
            Console.WriteLine(d.ToString()); // 输出：0_0 Planet 的值是无效的

            Planet2 planet2 = new Planet2();
            Console.WriteLine(planet2); // 输出：None，这个值代表None

            Styles styles = new Styles();
            Console.WriteLine(styles);


            Console.WriteLine("Hello World!");
        }
    }

    public struct ObservationData
    {
        private Planet whichPlanet;
        private double magnitude;

        public Planet WhichPlanet
        {
            set
            {
                whichPlanet = value;
            }
            get { return whichPlanet; }
        }
        public double Magnitude
        {
            set
            {
                magnitude = value;
            }
            get { return magnitude; }
        }

        public override string ToString()
        {
            return $"{whichPlanet}_{magnitude}";
        }
    }

    public enum Planet
    {
        // Explicitly assign values.
        // Default starts at 0 otherwise.
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Neptune = 7,
        Uranus = 8
        // First edition included Pluto. 
    }

    public enum Planet2
    {
        None = 0,
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Neptune = 7,
        Uranus = 8
    }

    [Flags]
    public enum Styles
    {
        None = 0,
        Flat = 1,
        Sunken = 2,
        Raised = 4,
    }
}
