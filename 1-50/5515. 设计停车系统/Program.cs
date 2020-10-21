using System;

namespace _5515._设计停车系统
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem obj = new ParkingSystem(1, 1, 0);

            // [1], [2], [3], [1]
            bool param_1 = obj.AddCar(1);
            Console.WriteLine(param_1);

            bool param_2 = obj.AddCar(2);
            Console.WriteLine(param_2);

            bool param_3 = obj.AddCar(3);
            Console.WriteLine(param_3);

            bool param_4 = obj.AddCar(1);
            Console.WriteLine(param_4);

        }
    }

    public class ParkingSystem
    {
        private int[] _arr;

        public ParkingSystem(int big, int medium, int small)
        {
            //_arr = new int[3];
            //_arr[0] = big;
            //_arr[1] = medium;
            //_arr[2] = small;

            _arr = new int[] { big, medium, small };
        }

        public bool AddCar(int carType)
        {
            return _arr[carType - 1]-- > 0;
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
}
