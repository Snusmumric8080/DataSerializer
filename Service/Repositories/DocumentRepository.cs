using Service.Models;
using Service.Models.Filters;

namespace Service.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        public int Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> FindByFilter(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
