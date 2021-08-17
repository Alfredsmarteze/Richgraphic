using RichyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RichyProject.Services
{
  public  interface IYourMessage
    {
        public Task AddMessage(YourMessage yourMessage);
        public  Task ListMesaages();
    }
}
