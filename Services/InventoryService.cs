using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Repositories;

namespace Shop.Services
{
    class InventoryService
    {
        private InventoryRepository inventoryRepository;

        public InventoryService(InventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        internal void Insert(Inventory inventory)
        {
            inventoryRepository.Insert(inventory);

        }
    }
}
