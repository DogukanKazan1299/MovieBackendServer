using Movie.Core.DataAccess.EntityFramework;
using Movie.DataAccess.Abstract;
using Movie.DataAccess.Concrete.Contexts;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,MovieSystemContext> , ICategoryDal
    {
    }
}
