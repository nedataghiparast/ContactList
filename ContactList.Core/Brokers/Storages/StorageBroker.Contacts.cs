using ContactList.Core.Models.Contacts;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactList.Core.Brokers.Storages
{
    public partial class StorageBroker
    {
     public DbSet<Contact> Contacts { set; get; }      
        
    }
}
