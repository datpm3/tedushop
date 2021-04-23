namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDBContext dBContext;

        public TeduShopDBContext Init()
        {
            return dBContext ?? (dBContext = new TeduShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dBContext != null)
                dBContext.Dispose();
        }
    }
}