using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Models;

namespace Template.Repositories
{
    public class ModelRepository<TEntity> : BaseRepository<TEntity>, IDisposable where TEntity : class, IModel
    {
        public override Task<TEntity> GetById(string id) => All().SingleOrDefaultAsync(m => m.Id.Equals(id));

        public override Task InsertOrUpdateAsync(TEntity model)
        {
            if (model.RowVersion == null)
            {
                // ensure id is set
                if (model.Id == null) model.Id = Guid.NewGuid().ToString();
                // add to set
                Context.Set<TEntity>().Add(model);
            }
            else
            {
                Context.Entry(model).State = EntityState.Modified;
            }
            return Task.FromResult(0);
        }
    }
}
