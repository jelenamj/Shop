using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Repositories;

namespace Shop.Services
{
    class ItemService
    {
        private ItemRepository itemRepository;

        public ItemService(ItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        internal void Insert(Item item)
        {
            itemRepository.Insert(item);

        }
    }
}
