using Movie.Business.Abstract;
using Movie.Business.BusinessAspect.Autofac;
using Movie.Business.Constants;
using Movie.Business.ValidationRules.FluentValidation;
using Movie.Core.Aspects.Autofac.Caching;
using Movie.Core.Aspects.Autofac.Performance;
using Movie.Core.Aspects.Autofac.Validation;
using Movie.Core.Utilities.Results;
using Movie.DataAccess.Abstract;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        [ValidationAspect(typeof(CategoryValidator))]
        [SecuredOperation("Team.Add,Admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.AddCategory);
        }
        [SecuredOperation("Team.Delete,Admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.DeleteCategory);
        }
        [CacheAspect]
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.Id == categoryId));
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }
        [SecuredOperation("Team.Update,Admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.UpdateCategory);
        }
    }
}
