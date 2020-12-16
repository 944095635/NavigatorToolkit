using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace NavigatorToolkit.Samples.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {

        }
        
        /// <summary>
        /// 登录
        /// </summary>
        public ICommand LoginCommand => new RelayCommand(() =>
        {
            //验证用户名密码是否正确

            //跳转至首页
            Navigator.Navigat("home");//Navigator.Navigat("home");
        });
    }
}