using Movie.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Constants
{
    public static class Messages
    {
        public static string AddPlayer = "new player added";
        public static string DeletePlayer = "player deleted";
        public static string UpdatePlayer = "player updated";

        public static string AddMovie = "new movie added";
        public static string DeleteMovie = "movie deleted";
        public static string UpdateMovie = "movie updated";

        public static string AddCategory = "new category added";
        public static string DeleteCategory = "category deleted";
        public static string UpdateCategory = "category updated";

        public static string AddDirector = "new director added";
        public static string DeleteDirector = "director deleted";
        public static string UpdateDirector = "director updated";

        public static string AddMovieCategory = "new moviecategory added";
        public static string DeleteMovieCategory = "moviecategory deleted";
        public static string UpdateMovieCategory = "moviecategory updated";

        public static string AddMoviePlayer = "new movieplayer added";
        public static string DeleteMoviePlayer = "movieplayer deleted";
        public static string UpdateMoviePlayer = "movieplayer updated";
        public static string AuthorizationDenied = "Yetkiniz yok ";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserRegistered = "Kullanıcı kayıtlı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
