using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliveryApp
{
    public class arrayItems
    {
        private ItemClass[] itemsArray = new ItemClass[52];
        private int index;

        public void inicializarArray()
        {
            itemsArray = new ItemClass[52];
        }

        public void addItem(ItemClass itemAdd, int index)
        {
            itemsArray[index] = itemAdd;
        }

        public int getSize()
        {
            return itemsArray.Length;
        }

    }
}
