using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    //Nuget ortak yapıların olduğu yer
    public class EfProductDal : EfEntityRepositoryBase<Product,NortwindContext>,IProductDal
    {
        
    }
}
