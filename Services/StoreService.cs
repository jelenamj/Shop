using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Repositories;

namespace Shop.Services
{
    class StoreService
    {
        private StoreRepository storeRepository { get; set; }

        public StoreService(StoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        internal void Insert(Store store)
        {
            storeRepository.Insert(store);
        }
    }
}
