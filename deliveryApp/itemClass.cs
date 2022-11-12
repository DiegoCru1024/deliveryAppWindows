using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliveryApp
{
    public class ItemClass
    {
        private int itemID;
        private string itemName;
        private float itemPrice;
        private string itemStore;

        public void createItem(int ID, string Name, float Price, string Store)
        {
            this.itemID = ID;
            this.itemName = Name;
            this.itemPrice = Price;
            this.itemStore = Store;
        }
    }
}
