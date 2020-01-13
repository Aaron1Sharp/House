using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("price += price * (1 + numberOfBedrooms * 0.1); // +10% room*/");
            House.ShowResidence(out House myFlat, out House myHouse, out House myBungalow, out House myApartament);
            House.ShowTypeHouse(myFlat, myHouse, myBungalow, myApartament);
            House.ShowPrice(myFlat, myHouse, myBungalow, myApartament);
            Console.ReadKey();
        }
    }
}
