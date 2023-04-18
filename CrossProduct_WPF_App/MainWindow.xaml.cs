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

/// <summary>
/// Button click event
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Btn_ComputeCrossProduct_click(object sender, RoutedEventArgs e)
        {
            _view = new VectorViewModel()//get vector 1 and vector values
            {
                Vector1 = _viewVector1,
                Vector2 = _viewVector2
            };
            if (_view != null)
            {
                _view.CrossProduct = _view.Compute(); // compute and store it to resulting vector
                if (_view.CrossProduct != null)
                {
                    x3.Text = _view.CrossProduct.X.ToString();
                    y3.Text = _view.CrossProduct.Y.ToString();
                    z3.Text = _view.CrossProduct.Z.ToString();
                }
            }
        }


        //Convert data entered by user in string to Double
        private void TBv1x_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewVector1.X = Convert.ToDouble(x1.Text);
        }

        private void TBv1y_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewVector1.Y = Convert.ToDouble(y1.Text);
        }

        private void TBv1z_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewVector1.Z = Convert.ToDouble(z1.Text);
        }

        private void TBv2x_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewVector2.X = Convert.ToDouble(x2.Text);
        }

        private void TBv2y_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewVector2.Y = Convert.ToDouble(y2.Text);
        }

        private void TBv2z_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewVector2.Z = Convert.ToDouble(z2.Text);
        }

        //Convert data compute in double precision floating point to string
        private void TBv3x_TextChanged(object sender, TextChangedEventArgs e)
        {
            x3.Text = _view.CrossProduct.X.ToString();
        }

        private void TBv3y_TextChanged(object sender, TextChangedEventArgs e)
        {
            x3.Text = _view.CrossProduct.Y.ToString();
        }

        private void TBv3z_TextChanged(object sender, TextChangedEventArgs e)
        {
            x3.Text = _view.CrossProduct.Z.ToString();
        }

      
    }
}
