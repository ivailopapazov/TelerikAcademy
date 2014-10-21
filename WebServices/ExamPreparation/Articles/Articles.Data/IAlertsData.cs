namespace Articles.Data
{
    using Articles.Data.Repositories;
    using Articles.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAlertsData
    {
        IRepository<Alert> Alerts { get; }

        int SaveChanges();
    }
}
