using System;
namespace Design_Patterns
{
	public class ItemListView
	{
		//prop
		public List<Item> AllItems { get; set; }

		//con
		public ItemListView(List<Item> _allItems)
		{
			AllItems = _allItems;
		}

		//methods

		public void Display()
		{
			for (int i = 0; i< AllItems.Count; i++)
			{
				Console.WriteLine($"{i}. {AllItems[i].Name}");
			}
		}

	}
}

