using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Category:Entity<Guid>
    {
        public string Name { get; set; }
    }
}
