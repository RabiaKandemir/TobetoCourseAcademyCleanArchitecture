using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services.Repositories
{
    public interface ICategoryRepository : IRepository<Category, Guid>,IAsyncRepository<Category,Guid>
    {
    }
}
