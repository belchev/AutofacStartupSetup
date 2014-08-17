using AutofacStartupSetup.Models;
using AutofacStartupSetup.Utils.Data;
using System.Data.Entity;

namespace AutofacStartupSetup.Utils
{
    public class DbConfiguration : IDbConfiguration
    {
        public void AddConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}