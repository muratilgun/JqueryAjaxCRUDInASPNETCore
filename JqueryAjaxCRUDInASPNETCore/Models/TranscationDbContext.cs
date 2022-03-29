using Microsoft.EntityFrameworkCore;

namespace JqueryAjaxCRUDInASPNETCore.Models
{
    public class TranscationDbContext : DbContext
    {
        public TranscationDbContext(DbContextOptions<TranscationDbContext> options) : base(options)
        {
        }
    }
}
