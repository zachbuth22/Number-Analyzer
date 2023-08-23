using System;
namespace Top_100_OOP
{
	public class QB
	{
		public string Name { get; set; }
		public int PassYards { get; set; }
		public int Completions { get; set; }
		public int PassAttempts { get; set; }
		public int PassTDs { get; set; }
		public int INTs { get; set; }
		public int RushYards { get; set; }
		public int RushAttempts { get; set; }
		public int RushTDs { get; set; }
		public int Games { get; set; }

		public QB(string _name, int _passYards, int _completions, int _passAttempts, int _passTDs,
		int _iNTs, int _rushYards, int _rushAttempts, int _rushTDs, int _games)

		{
			Name = _name;
			PassYards = _passYards;
			Completions = _completions;
			PassAttempts = _passAttempts;
			PassTDs = _passTDs;
			INTs = _iNTs;
			RushYards = _rushYards;
			RushAttempts = _rushAttempts;
			RushTDs = _rushTDs;
			Games = _games;
		}
	}
}

