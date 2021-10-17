using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Services;
using Shop.Repositories;


namespace Shop
{
    class Controller
    {
        internal static void AddStore(Store store)
        {
            //var storeRepository = new StoreRepository();
            var storeService = new StoreService(new StoreRepository());
            storeService.Insert(store);
        }

        internal static void AddItem(Item item)
        {

            var itemServices = new ItemService(new ItemRepository());
            itemServices.Insert(item);
        }

        internal static void AddToInventory(Inventory inventory)
        {

            var inventoryService = new InventoryService(new InventoryRepository());
            inventoryService.Insert(inventory);
        }
    }
}
