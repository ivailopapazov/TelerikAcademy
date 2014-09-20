namespace KittyCraft.Data
{
    using KittyCraft.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IKittyCraftDbContext
    {
        IDbSet<Kitty> Kittys { get; set; }

        IDbSet<AirCraft> AirCrafts { get; set; }

        void SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
