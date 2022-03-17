using Core.Options;

namespace Core.Interfaces
{
    public interface ITenantService
    {
        string GetDatabaseProvider();
        string GetConnectionString();
        Tenant GetTenant();
    }
}
