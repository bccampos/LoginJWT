using SmartStore.Model.View;
using System.Threading.Tasks;

namespace SmartStore.WebApp.MVC.Services.Interface
{
    public interface IAuthService
    {
        Task<UserResponseLogin> Login(UserLogin userLogin);

        Task<UserResponseLogin> Register(UserRegister userRegister);
    }
}
