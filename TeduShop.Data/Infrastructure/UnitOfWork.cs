namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TeduShopDBContext dBContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TeduShopDBContext DBContext
        {
            get { return dBContext ?? (dBContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DBContext.SaveChanges();
        }
    }
}