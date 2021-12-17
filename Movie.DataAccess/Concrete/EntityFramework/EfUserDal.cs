using Movie.Core.DataAccess.EntityFramework;
using Movie.Core.Entities.Concrete;
using Movie.DataAccess.Abstract;
using Movie.DataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MovieSystemContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MovieSystemContext())
            {
                var result = from OperationClaim in context.OperationClaims
                             join
                             UserOperationClaim in context.UserOperationClaims
                             on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                             where
                             UserOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = OperationClaim.Id,
                                 Name = OperationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
