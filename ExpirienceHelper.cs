using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF
{
    internal static class ExpirienceHelper
    {
        private static Dictionary<int, int> TotalExpDictionary = new Dictionary<int, int>() { {1, 0} };

        private static int NeededExpToLevel(int level)
        {
            return (level-1) * 1000;
        }

        public static int TotalExpForNextLvl(this ICharacter character)
        {
            return TotalExpForLvl(character.Level + 1);
        }

        public static int TotalExpForLvl(int level)
        {
            if (TotalExpDictionary.Keys.Contains(level))
            {
                return TotalExpDictionary[level];
            }
            else
            {
                int Exp = NeededExpToLevel(level) + TotalExpForLvl(level - 1);
                TotalExpDictionary[level] = Exp;
                return Exp;
            }
        }
    }
}
