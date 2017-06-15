using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetrProj
{
    class Auto
    {
        private const double nCarr = 9;
        private const double nSpeed = 5;
        private const double nCoast = 2;
        private const double nCapa = 8;

        public int carrying;    //грузоподъемность
        public int speed;       //скорость
        public int cost;        //цена
        public int capacity;    //вместимость
        public string kind;     //вид

        public Auto(string s)
        {
            switch (s)
            {
                case ("truck"):
                    this.carrying = 10;
                    this.speed = 2;
                    this.cost = 8;
                    this.capacity = 2;
                    this.kind = "truck";
                    break;
                case ("car"):
                    this.carrying = 4;
                    this.speed = 10;
                    this.cost = 10;
                    this.capacity = 5;
                    this.kind = "car";
                    break;
                case ("bus"):
                    this.carrying = 5;
                    this.speed = 5;
                    this.cost = 2;
                    this.capacity = 10;
                    this.kind = "bus";
                    break;
                case ("motocycle"):
                    this.carrying = 2;
                    this.speed = 8;
                    this.cost = 5;
                    this.capacity = 1;
                    this.kind = "motocycle";
                    break;
                default:
                    this.carrying = 2;
                    this.speed = 8;
                    this.cost = 5;
                    this.capacity = 1;
                    this.kind = "motocycle";
                    break;
            }
        }

        public Auto(int Carrying, int Speed, int Cost, int Capacity)
        {
            this.carrying = Carrying;
            this.speed = Speed;
            this.cost = Cost;
            this.capacity = Capacity;
        }

        public static double SortEvklid(Auto obj1, Auto obj2)
        {
            double x = Math.Sqrt(Math.Pow((obj1.carrying - obj2.carrying), 2) +
                Math.Pow((obj1.speed - obj2.speed), 2) +
                Math.Pow((obj1.cost - obj2.cost), 2) +
                Math.Pow((obj1.capacity - obj2.capacity), 2));
            return x;
        }

        public static double SumModRaz(Auto obj1, Auto obj2)
        {

            double x = Math.Abs(obj1.carrying - obj2.carrying) +
                Math.Abs(obj1.speed - obj2.speed) +
                Math.Abs(obj1.cost - obj2.cost) +
                Math.Abs(obj1.capacity - obj2.capacity);
            return x;
        }

        public static double MetKanberra(Auto obj1, Auto obj2)
        {

            double x = Math.Sqrt(nCarr*Math.Pow((obj1.carrying - obj2.carrying), 2) +
                nSpeed * Math.Pow((obj1.speed - obj2.speed),2) +
                nCoast * Math.Pow((obj1.cost - obj2.cost),2) +
                nCapa * Math.Pow((obj1.capacity - obj2.capacity),2));
            return x;
        }
    }
}
