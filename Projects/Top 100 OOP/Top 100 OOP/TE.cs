using System;
namespace Top_100_OOP
{
	public class TE : SkillPlayer
	{
        public double Depth { get; set; }

        public TE(string _name, int _recYards, int _targets, int _receptions, int _tDs,
            int _games, double _depth)
            : base(_name, _recYards, _targets, _receptions, _tDs, _games)
        {
            Depth = _depth;
        }
    }
}

