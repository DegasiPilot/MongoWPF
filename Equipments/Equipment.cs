﻿namespace MongoWPF.Equipments
{
    internal class Equipment : Item
    {
        public virtual int RequirementStrength => 0;
        public virtual int RequirementDexterity => 0;
        public virtual int RequirementIntelligence => 0;
        public virtual int RequirementVitality => 0;

        public virtual int RequirementLevel => 0;

        public override string Name => "Нет";
    }
}