using TeduShop.Data.Infrastructure;
using TeduShop.Model;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
        //add something Method
    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}