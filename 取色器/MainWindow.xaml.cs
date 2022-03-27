using System;
using System.Windows;
using 取色器.ModelInfo;
using 取色器.ViewModel;

namespace 取色器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainViewModel();
            this.DataContext = vm;
            
        }
    }
}
