using System;
namespace Design_Patterns
{
	public class Item_Controller
	{
        public List<Item> itemDB = new List<Item>()
        {
            new Item("Keyboard", 25.99m),
            new Item("Monitor", 225.99m),
            new Item("Motherboard", 100),
            new Item("Gaming Chair", 249.99m),
            new Item("Web Cam", 100.00m),
            new Item("Mouse", 15.99m),
            new Item("USB cable", 14.99m)
        };

        public void RunProgram()
        {
            ItemListView listView = new ItemListView(itemDB);
            listView.Display();

            //ask for input
            Console.WriteLine("Please pick an item number");
            int itemChoice = int.Parse(Console.ReadLine());

            Item i = itemDB[itemChoice];
            ItemView view = new ItemView(i);
            view.Display();

        }
    }
}

