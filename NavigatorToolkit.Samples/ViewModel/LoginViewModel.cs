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
        /// ��¼
        /// </summary>
        public ICommand LoginCommand => new RelayCommand(() =>
        {
            //��֤�û��������Ƿ���ȷ

            //��ת����ҳ
            Navigator.Navigat("home");//Navigator.Navigat("home");
        });
    }
}