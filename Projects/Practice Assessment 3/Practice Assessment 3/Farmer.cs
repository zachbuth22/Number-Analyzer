using System;
namespace Practice_Assessment_3
{
    internal class Farmer : Villager
    {
        public Farmer()
        {
            Hunger =1 ;
        }
        public override int Farm()
        {
            return 2;
        }
    }
}

