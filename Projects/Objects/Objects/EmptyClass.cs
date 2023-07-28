using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lecture
{
	internal class Pen
	{
		//properties
		public string Color { get; set; }
		public string Brand { get; set; }
        public string InkType { get; set; }
        public decimal Price { get; set; }
        public float Length { get; set; }

        //constructor
        public Pen(string _color, string _brand, string _inktype, decimal _price, float _length)
        {
            Color = _color;
            Brand = _brand;
            InkType = _inktype;
            Price = _price;
            Length = _length;
        }

        //methods
        public void Draw()
		{
			Console.WriteLine($"The {Color} pen drew a flower");
		}




	}
}

