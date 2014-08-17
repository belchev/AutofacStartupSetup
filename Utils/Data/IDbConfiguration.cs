using System.Data.Entity;

namespace AutofacStartupSetup.Utils.Data
{
    public interface IDbConfiguration
    {
        void AddConfiguration(DbModelBuilder modelBuilder);
    }
}
