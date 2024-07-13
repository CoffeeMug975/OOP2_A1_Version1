using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAssignment1
{
    public class Dishwasher : Appliance
    {
        string Feature {  get; set; }
        string SoundRating { get; set; }

        public Dishwasher (int itemNumber, string brand, int quantity, int wattage, string color, double price, string feature, string soundRating)
            :base(itemNumber, brand, quantity, wattage, color, price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            Feature = feature;
            SoundRating = soundRating;
        }

        public override string ToString()
        {
            string obj = ($"ItemNumber: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}" +
                $"\nFeature: {Feature}\nSoundRating: {SoundRating}");
            return obj;
        }
    }
}
