using Empeek.Api.Contracts.DTO;
using Empeek.Api.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.Api.Contracts.Interfaces.Services
{
    public interface IItemService
    {
        //Task<ItemDTO> GetItemByIdAsync(long id);
        Task<ItemsViewModel> GetItemsAsync();
        //Task CreateItemAsync(ItemDTO board);
        //Task UpdateItemAsync(ItemDTO board);
        //Task DeleteItemAsync(long id);
    }
}
