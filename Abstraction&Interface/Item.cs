using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface
{
    public abstract class Item : IItem, IDecompose
    {
        public ItemType itemType;
        public Rarity rarity;

        public float value 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }

        public Item()
        {
            
        }

        public Item(ItemType itemType, Rarity rarity)
        {
            this.itemType = itemType;
            this.rarity = rarity;
        }

        public bool CanUpgrade(Rarity rarityToUpgrade)
        {
            return CurencyManager.currentGold >= GameConstants.goldToUpgradeItem[(int)rarityToUpgrade];
        }

        public void OnUpgradeItem(Rarity rarityToUpgrade)
        {
            if (!CanUpgrade(rarityToUpgrade))
                return;
            DoUpgradeItem(rarityToUpgrade);
        }

        public abstract void DoUpgradeItem(Rarity rarityToUpgrade);

        public virtual void RarityUp()
        {
            
        }

        public virtual void Decompose()
        {
            
        }
    }
}
