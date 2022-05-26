using System.Threading.Tasks;
using ContactList.Core.Models.Contacts;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace ContactList.Core.Brokers.Storages
{
    public partial class StorageBroker
    {
     public DbSet<Contact> Contacts { set; get; } 
       
        public async ValueTask<Contact> InsertContactAsync(Contact contact)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Contact> contactEntityEntry =
                await broker.Contacts.AddAsync(contact); 
            
            await broker.SaveChangesAsync();

            return contactEntityEntry.Entity;
        }
        
    }
}
