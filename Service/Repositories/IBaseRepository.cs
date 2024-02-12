using Service.Models;
using Service.Models.Filters;

namespace Service.Repositories
{
    public interface IBaseRepository
    {
        public int Add(IEntity entity);
        public int Update(IEntity entity);
        public void Delete(int Id);
        public IEnumerable<IEntity> GetAll();
        public IEnumerable<IEntity> FindByFilter(IFilter filter);
    }
}
