using System;
namespace Design_Patterns
{
	public class Item
	{
		//props
		public string Name { get; set; }
		public decimal Price { get; set; }

		//Constructors
		public Item(string _name, decimal _price)
		{
			Name = _name;
			Price = _price;
		}



	}
}

