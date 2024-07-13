using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAssignment1
{
    public class Refrigerator : Appliance
    {
        int NumberOfDoors { get; set; }
        int Height { get; set; }
        int Width { get; set; }

        public Refrigerator(int itemNumber, string brand, int quantity, int wattage, string color, double price, int numberOfDoors,
            int height, int width) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            NumberOfDoors = numberOfDoors;
            Height = height;
            Width = width;

        }

        public override string ToString()
        {
            string obj = ($"ItemNumber: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}" +
                $"\nNumber of Doors: {NumberOfDoors}\nHeight: {Height}\nWidth: {Width}");
            return obj;
        }
    }
}
