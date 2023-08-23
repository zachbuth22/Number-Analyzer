using System;
namespace Design_Patterns
{
	public class ItemView
	{
		//props
		public Item DisplayItem { get; set; }

		//Constructor
		public ItemView(Item _item)
		{
			DisplayItem = _item;
		}

		//methods
		public void Display()
		{
			Console.WriteLine($"Name: {DisplayItem.Name} ${DisplayItem.Price}");
		}

	}
}

