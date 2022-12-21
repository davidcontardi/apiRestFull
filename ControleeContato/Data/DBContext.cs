using Microsoft.EntityFrameworkCore;

namespace ControleeContato.Data
{
    public class DBContext
    {
        private DbContextOptions<BancoContext> options;

        public DBContext(DbContextOptions<BancoContext> options)
        {
            this.options = options;
        }
    }
}