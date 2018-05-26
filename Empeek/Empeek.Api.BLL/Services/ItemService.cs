using Empeek.Api.Contracts.DTO;
using Empeek.Api.Contracts.Interfaces.Services;
using Empeek.Api.Contracts.ViewModels;
using Empeek.Api.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.Api.BLL.Services
{
    public class ItemService :IItemService
    {
        private EmpeekDbContext _dbContext;
        public ItemService(EmpeekDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Task<ItemDTO> GetItemByIdAsync(long id);
        public async Task<ItemsViewModel> GetItemsAsync()
        {
           var items = await _dbContext.ItemNames.ToListAsync();
            var result = new ItemsViewModel()
            {
                Items = items.Select(x => new ItemDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.ItemType.Type
                }).ToList()
            };
            return result;
        }
        //Task CreateItemAsync(ItemDTO board);
        //{
        
        //}
        //Task UpdateItemAsync(ItemDTO board);
        //Task DeleteItemAsync(long id);
    }
}
