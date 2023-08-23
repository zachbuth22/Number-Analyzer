using System;
namespace Top_100_OOP
{
	public class WR : SkillPlayer
	{
		public double QBQual { get; set; }

        public WR(string _name, int _recYards, int _targets, int _receptions, int _tDs,
            int _games, double _qBQual)
            : base(_name, _recYards, _targets, _receptions, _tDs, _games)

        {
            QBQual = _qBQual;
        }
    }
}

