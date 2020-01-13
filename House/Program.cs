using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            House myFlat = new House(ResidenceType.Flat, 3) { hasGarden = true};
            House myHouse = new House(ResidenceType.House, 5, false);
            House myBungalow = new House(ResidenceType.Bungalow, 4, false,true);
            House myApartament = new House(ResidenceType.Apartment, 8, true, true);
            Console.WriteLine($"{myFlat.type}, {myFlat.numberOfBedrooms}, {myFlat.hasGarage},{myFlat.hasGarden}");
            myFlat.CalculateSalePrice(0);
            Console.WriteLine(myFlat.CalculateSalePrice(0) + "\t = flat");
            Console.WriteLine(myHouse.CalculateSalePrice(0) + "\t = house");
            Console.WriteLine(myBungalow.CalculateSalePrice(0) + "\t = bungalow");
            Console.WriteLine(myApartament.CalculateSalePrice(0)+"\t = apartament");
            Console.ReadKey();
            new House() { hasGarden = true };
          
        }
    }
    public enum ResidenceType
    {
        House,
        Flat,
        Bungalow,
        Apartment
    }
   public class House
    {
        public ResidenceType type;
        public int numberOfBedrooms;
        public bool hasGarage, hasGarden;
        public double CalculateSalePrice(double price)
        {
            price = 0;
            if (type == ResidenceType.House)
            {
                price = 1000;
            }
            if (type == ResidenceType.Bungalow)
            {
                price = 3000;
            }
            if (type == ResidenceType.Apartment)
            {
                price = 4000;
            }
            if (type == ResidenceType.Flat)
            {
                price = 2000;
            }
            price += price * (1 + numberOfBedrooms * 0.1); // +10% room
            if (hasGarage == true)
            {
                price += 500;
            }
            if (hasGarage == true)
            {
                price += 500;
            }
            return price;
        }
        public int CalculateRebuildingCost()
        {
            return 2;
        }
        public House(ResidenceType type,int numberOfBedrooms)
        {
            this.type = type;
            this.numberOfBedrooms = numberOfBedrooms;
        }
        public House(ResidenceType type, int numberOfBedrooms,bool hasGarage)
        {
            this.type = type;
            this.numberOfBedrooms = numberOfBedrooms;
            this.hasGarage = hasGarage;
        }
        public House(ResidenceType type, int numberOfBedrooms,bool hasGarage,bool hasGarden)
        {
            this.type = type;
            this.numberOfBedrooms = numberOfBedrooms;
            this.hasGarage = hasGarage;
            this.hasGarden = hasGarden;
        }
        public House() : this(ResidenceType.House, 3,true,true)
        {

        }
    }
}
