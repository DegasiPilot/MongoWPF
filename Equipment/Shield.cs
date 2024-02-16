using System;
namespace MongoWPF.Equipment
{
    internal class Shield : Equipment
    {
        public override string Name => "Shield";
        public int level;
        public int ChanseOfBlock => Math.Max(25, level * 5);

        public override int Armor => 4 * level;
        public override int Dexterity => -5;

        public override int RequirementStrength => 15 * level;
    }
}