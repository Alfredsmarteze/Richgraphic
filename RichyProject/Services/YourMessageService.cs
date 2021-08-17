using RichyProject.Data;
using RichyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RichyProject.Services
{
    public class YourMessageService : IYourMessage
    {

        private readonly DataContext _dataContext;

        public YourMessageService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddMessage(YourMessage yourMessage)
        {
            await _dataContext.yourMessages.AddAsync(yourMessage);
            await _dataContext.SaveChangesAsync();

        }

        public async Task ListMesaages()
        {
            _dataContext.yourMessages.ToList();

            
        }
    }
}
