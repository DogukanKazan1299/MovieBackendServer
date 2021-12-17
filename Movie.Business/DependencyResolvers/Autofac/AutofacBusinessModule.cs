using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Movie.Business.Abstract;
using Movie.Business.Concrete;
using Movie.Core.Utilities.Interceptors;
using Movie.Core.Utilities.Security.Jwt;
using Movie.DataAccess.Abstract;
using Movie.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieeManager>().As<IMovieeService>();
            builder.RegisterType<EfMovieeDal>().As<IMovieDal>();

            builder.RegisterType<PlayerManager>().As<IPlayerService>();
            builder.RegisterType<EfPlayerDal>().As<IPlayerDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<DirectorManager>().As<IDirectorService>();
            builder.RegisterType<EfDirectorDal>().As<IDirectorDal>();

            builder.RegisterType<MovieCategoryManager>().As<IMovieCategoryService>();
            builder.RegisterType<EfMovieCategoryDal>().As<IMovieCategoryDal>();

            builder.RegisterType<MoviePlayerManager>().As<IMoviePlayerService>();
            builder.RegisterType<EfMoviePlayerDal>().As<IMoviePlayerDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()//Aspect var mı kontrolü 
                }).SingleInstance();
        }
    }
}
