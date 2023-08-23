using System;
namespace Top_100_OOP
{
	public class RB : SkillPlayer
	{
		//prop
		public int RushYards { get; set; }
		public int Carries { get; set; }
		public double Healthy { get; set; }
		//constructors
		public RB(string _name, int _recYards, int _targets, int _receptions, int _tDs,
			int _games, int _rushYards, int _carries, double _healthy)
			: base(_name, _recYards, _targets, _receptions, _tDs, _games)

		{
			RushYards = _rushYards;
			Carries = _carries;
			Healthy = _healthy;
		}

    }
}

