using Ef.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data
{
    public class EfObjectContext : DbContext
    {
        #region Ctor

        public EfObjectContext()
            : base("LocalDb")
        {
            Database.SetInitializer<EfObjectContext>(new CreateDatabaseIfNotExists<EfObjectContext>());
        }

        #endregion

        #region Utilities

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            //dynamically load all configuration
            //System.Type configType = typeof(LanguageMap);   //any of your configuration classes here
            //var typesToRegister = Assembly.GetAssembly(configType).GetTypes()

            //var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
            //    type.BaseType.GetGenericTypeDefinition() == typeof(EfEntityTypeConfiguration<>));
            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.Configurations.Add(configurationInstance);
            //}

            //...or do it manually below. For example,

            // Chapter 02 : Entity Data Modeling Fundamentals
            // 2-1. Creating a Simple Model
            modelBuilder.Configurations.Add(new PersonMap());

            // 2-3. Modeling a Many-to-Many Relationship with No Payload 
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new AlbumMap());

            // Chapter 03 : Querying an Entity Data Model
            // Recipe01
            modelBuilder.Configurations.Add(new AssociateSalaryMap());
            modelBuilder.Configurations.Add(new AssociateMap());

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
