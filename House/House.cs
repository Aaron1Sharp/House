using System;

namespace House
{
    public class House
    {
        public ResidenceType type;
        public int numberOfBedrooms;
        public bool hasGarage, hasGarden;
        public double CalculateSalePrice(double price)
        {
            price = 0;
            /*switch (type)
            {
                case ResidenceType.Bungalow:
                    price = 1000;
                    goto case ResidenceType.House;
                case ResidenceType.House:
                    price = 2000;
                    goto case ResidenceType.Flat;
                case ResidenceType.Flat:
                    price = 3000;
                    goto case ResidenceType.Apartment;
                case ResidenceType.Apartment:
                    price = 1000;
                    break;
            }
            price += price * (1 + numberOfBedrooms * 0.1); // +10% room*/
            if (type == ResidenceType.House)
                price = 1000;
            if (type == ResidenceType.Flat)
                price = 2000;
            if (type == ResidenceType.Bungalow)            
                price = 3000;           
            if (type == ResidenceType.Apartment)
                price = 4000;
            price += price * (1 + numberOfBedrooms * 0.1); // +10% room
            if (hasGarage == true)
                price += 500;
            if (hasGarage == true)
                price += 500;
            return price;
        }
        public House(ResidenceType type, int numberOfBedrooms)
        {
            this.type = type;
            this.numberOfBedrooms = numberOfBedrooms;
        }
        public House(ResidenceType type, int numberOfBedrooms, bool hasGarage)
        {
            this.type = type;
            this.numberOfBedrooms = numberOfBedrooms;
            this.hasGarage = hasGarage;
        }
        public House(ResidenceType type, int numberOfBedrooms, bool hasGarage, bool hasGarden)
        {
            this.type = type;
            this.numberOfBedrooms = numberOfBedrooms;
            this.hasGarage = hasGarage;
            this.hasGarden = hasGarden;
        }
        /*public House() : this(ResidenceType.House, 3, true, true) { }*/
        public static void ShowTypeHouse(House myFlat,
                                         House myHouse,
                                         House myBungalow,
                                         House myApartament)
        {
            Console.WriteLine($"{myFlat.type}, {myFlat.numberOfBedrooms}, {myFlat.hasGarage},{myFlat.hasGarden}\n{myHouse.type}, {myHouse.numberOfBedrooms}, {myHouse.hasGarage},{myHouse.hasGarden}\n{myBungalow.type}, {myBungalow.numberOfBedrooms}, {myBungalow.hasGarage},{myBungalow.hasGarden}\n{myApartament.type}, {myApartament.numberOfBedrooms}, {myApartament.hasGarage},{myApartament.hasGarden}");
        }
        public static void ShowPrice(House myFlat,
                                     House myHouse,
                                     House myBungalow,
                                     House myApartament)
        {
            Console.WriteLine(myFlat.CalculateSalePrice(0) + "\t = flat");
            Console.WriteLine(myHouse.CalculateSalePrice(0) + "\t = house");
            Console.WriteLine(myBungalow.CalculateSalePrice(0) + "\t = bungalow");
            Console.WriteLine(myApartament.CalculateSalePrice(0) + "\t = apartament");
        }
        public static void ShowResidence(out House myFlat, out House myHouse, out House myBungalow, out House myApartament)
        {
            myFlat = new House(ResidenceType.Flat, 3) { hasGarden = true };
            myHouse = new House(ResidenceType.House, 5, false);
            myBungalow = new House(ResidenceType.Bungalow, 4, false, true);
            myApartament = new House(ResidenceType.Apartment, 8, true, true);
        }
    }
}
