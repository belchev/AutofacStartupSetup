using System.Data.Entity;

namespace AutofacStartupSetup.Utils.Data
{
    public interface IDbContextInitializer
    {
        void InitializeContext(DbContext context);
    }
}
