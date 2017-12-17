using Ef.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data.Mapping
{
    public abstract class EfEntityTypeConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class 
    {
        protected EfEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
        }
    }
}
