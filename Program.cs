using Microsoft.PowerShell.Commands;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
           
            do
            {
                Console.Write("\r\n1=>Car\r\n2=>Train\r\nOther=>Both:");
                string input= Console.ReadLine();
                if(sbyte.TryParse(input,out sbyte num))
                    switch(num)
                        {
                        case 1:
                            Print<Car<byte, string>, byte, string>();

                            break;
                            case 2:
                            Printt<Train<string, float>, string, float>();
                            break;
                            default:
                            Print<Car<byte, string>, byte, string>();
                            Printt<Train<string, float>, string, float>();
                            break;
                        }


                
                

                Console.Write("\nRepeate('y'/'n'?:");
                ch = char.ToLower(Console.ReadKey().KeyChar);
            } while (ch.Equals('y'));
           

        }

        static void Print<C, T, V>() where C : Car<T, V>, new()

        {
            C car = new C();
            //Console.Write("\r\n1=>Car\r\n2=>Train\r\nOther=>Both:");
            //string val = Console.ReadLine();
            //if (sbyte.TryParse(val, out sbyte num))
            //    switch (num)
            //    {
            //        case 1:
            //            //PrintCar<Car<byte, string>, byte, string>();



                        Console.Write("\nCar Passengers: ");
                        string input = Console.ReadLine();

                        try
                        {
                            T passengers = (T)Convert.ChangeType(input, typeof(T));
                            car.Passengers = passengers;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            return;
                        }

                        Console.Write("\nCar Brand: ");
                        string value = Console.ReadLine();

                        try
                        {
                            V brand = (V)Convert.ChangeType(value, typeof(V));
                            car.Brand = brand;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            return;
                        }


                        Console.WriteLine($"\nPassengers: {car.Passengers}");
                        Console.WriteLine($"Brand: {car.Brand}");

                
        }
        static void Printt<C, T, V>() where C : Train<T, V>, new()

        {
            C train = new C();

            Console.Write("\nTrain Passengers: ");
            string input = Console.ReadLine();

            try
            {
                T passengers = (T)Convert.ChangeType(input, typeof(T));
                train.Passengers = passengers;
            }
            catch
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.Write("\nTrain Speed: ");
            string value = Console.ReadLine();

            try
            {
                V speed = (V)Convert.ChangeType(value, typeof(V));
                train.Speed = speed;
            }
            catch
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine($"\nPassengers: {train.Passengers}");
            Console.WriteLine($"Speed: {train.Speed}");

        }
    }

    class Car<T,V>:Ipassangers<T>
    {
        T _passengers;
        V _brand;

        public T Passengers { get => _passengers; set => _passengers = value; }
        internal V Brand { get=>_brand; set => _brand = value; }
    }
    class Train<T,V>: Ipassangers<T>

    {
        T _passengers;
        V _speed;
        public T Passengers { get=> _passengers; set=> _passengers = value; }
        internal V Speed { get=> _speed; set=> _speed = value; }



    }
    interface Ipassangers<T>
    {
        T Passengers {  get; set; }
    }
}
