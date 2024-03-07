using System.Threading.Tasks;

namespace TheBao.AbpEcommerce.Data;

public interface IAbpEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
