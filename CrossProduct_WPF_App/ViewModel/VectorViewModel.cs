using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vector3D_AlgebraOperation;

namespace CrossProduct_WPF_App.ViewModel
{
    public class VectorViewModel : INotifyPropertyChanged
    {
        private Vector3D _vector1;
        private Vector3D _vector2;
        private Vector3D _CrossProduct;

        public Vector3D Vector1
        {
            get { return _vector1; }
            set
            {
                _vector1 = value;
                OnPropertyChanged("Vector1");

            }
        }
        public Vector3D Vector2
        {
            get { return _vector2; }
            set
            {
                _vector2 = value;
                OnPropertyChanged("Vector2");

            }
        }

        public Vector3D CrossProduct
        {
            get { return _CrossProduct; }
            set
            {
                _CrossProduct = value;
                OnPropertyChanged("CrossProduct");

            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
