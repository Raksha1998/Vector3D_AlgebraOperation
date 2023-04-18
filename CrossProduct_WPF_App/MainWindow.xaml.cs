using CrossProduct_WPF_App.ViewModel;
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
using Vector3D_AlgebraOperation;

namespace CrossProduct_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //calling vectorviewmodel and vector3D objects in mainwindow
        private VectorViewModel _view;
        private Vector3D _viewVector1;
        private Vector3D _viewVector2;

        public MainWindow()
        {
            InitializeComponent();
            _viewVector1 = new Vector3D();
            _viewVector2 = new Vector3D();
            DataContext = new VectorViewModel();
        }


    }
}
