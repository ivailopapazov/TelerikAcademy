namespace KittyCraft.Data
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
    using System.Data.Entity;
    using KittyCraft.Models;
    using KittyCraft.Data.Migrations;
	
    public class KittyCraftDbContext : DbContext, IKittyCraftDbContext
    {

        public KittyCraftDbContext()
            : base("KittyCraftConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<KittyCraftDbContext, Configuration>());
        }

        public virtual IDbSet<Kitty> Kittys { get; set; }

        public virtual IDbSet<AirCraft> AirCrafts { get; set; }


        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
