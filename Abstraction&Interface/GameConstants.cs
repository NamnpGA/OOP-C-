using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface
{
    public static class GameConstants
    {
        public static int[] goldToUpgradeItem = new int[5] { 100, 200, 400, 800, 2000 };

    }

    public enum ItemType
    {
        Sword,
        Bow,
        Armour,
        Staff
    }

    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Legendary,
        Mythical
    }
}
