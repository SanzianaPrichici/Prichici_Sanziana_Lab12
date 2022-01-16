using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prichici_Maria_Lab12.Models;

namespace Prichici_Maria_Lab12.Data
{
    interface IRestService
    {
       
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }
    }
}
