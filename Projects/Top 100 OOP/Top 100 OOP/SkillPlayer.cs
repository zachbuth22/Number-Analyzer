using System;
namespace Top_100_OOP
{
	public class SkillPlayer
	{
		//properties
		public string Name { get; set; }
		public int RecYards { get; set; }
		public int Targets { get; set; }
		public int Receptions { get; set; }
		public int TDs { get; set; }
		public int Games {get;set;}

		//constructors
		public SkillPlayer (string _name, int _recYards, int _targets,
			int _receptions, int _tDs, int _games)
		{
			Name = _name;
			RecYards = _recYards;
			Targets = _targets;
			Receptions = _receptions;
			TDs = _tDs;
			Games = _games;
		}
		

	}
}

