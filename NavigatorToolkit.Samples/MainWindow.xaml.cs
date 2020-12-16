using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigatorToolkit.Samples
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 绑定回调
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Navigator.RegisterCallback += RegisterCallback;
            Navigator.Navigat("login");
        }

        /// <summary>
        /// 注册回调事件
        /// </summary>
        private void RegisterCallback(object sender, object e)
        {
            Uri u = (Uri)e;
            MainFrame.Navigate(u);
        }
    }
}
