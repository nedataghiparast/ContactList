using System.Threading.Tasks;
using ContactList.Core.Models.Contacts;

namespace ContactList.Core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Contact> InsertContactAsync(Contact contact);
    }
}
