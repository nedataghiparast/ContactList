using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactList.Core.Brokers.Storages
{
    public partial class StorageBroker: EFxceptionsContext,IStorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration) 
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conectionString =
                this.configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(conectionString);        
        }
    }
}
