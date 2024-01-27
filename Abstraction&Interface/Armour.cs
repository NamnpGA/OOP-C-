using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface
{
    public class Armour : Item
    {
        public override void DoUpgradeItem(Rarity rarityToUpgrade)
        {
            rarity = (Rarity)((int)rarity + 1);
        }

        public override void Decompose()
        {
            base.Decompose();
        }

        public override void RarityUp()
        {
            base.RarityUp();
        }
    }
}
