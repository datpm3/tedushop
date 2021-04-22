using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
        TeduShopDBContext dBContext;
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
