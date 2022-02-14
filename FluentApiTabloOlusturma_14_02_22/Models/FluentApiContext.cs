using Microsoft.EntityFrameworkCore;

namespace FluentApiTabloOlusturma_14_02_22.Models
{
    public class FluentApiContext: DbContext
    {
        public FluentApiContext(DbContextOptions<FluentApiContext> options) : base(options)
        {

        }
    }
}
