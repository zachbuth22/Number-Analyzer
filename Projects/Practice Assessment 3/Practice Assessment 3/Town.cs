using System;
namespace Practice_Assessment_3
{
	internal class Town
	{
		//properties
		public List<Villager> Villagers { get; set; }

		//constructor
		public Town()
		{
			Villagers = new List<Villager>();
			Villagers.Add(new Farmer());
			Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

		//methods
		public int Harvest()
		{
			int result = 0;
			foreach(Villager v in Villagers)
			{
				result += v.Farm();
			}
			return result;
		}


		public int CalcFoodConsumption()
		{
			int result = 0;
			foreach(Villager v in Villagers)
			{
				result += v.Hunger;
			}
			return result;
		}

		public bool SurviveTheWinter()
		{
			int food = Harvest();
			int eaten = CalcFoodConsumption();
			if (food >= eaten)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

