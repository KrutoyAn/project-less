using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace project_less
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShip ship = GetShip(ShipType.FightShip);
            string result = ship.Fight();

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static BaseShip GetShip(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.FightShip:
                    return new FightShip();
                case ShipType.TransportShip:
                    return new TransportShip();
                default:
                 throw new Exception("Неизвестный корабль");
            }
        }    
    }
}

