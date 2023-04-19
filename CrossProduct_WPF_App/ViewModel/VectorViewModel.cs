using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Vector3D_AlgebraOperation;
using System.Text.RegularExpressions;

namespace CrossProduct_WPF_App.ViewModel
{
    public class VectorViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        //Dictionary to add error to list
        private readonly Dictionary<string, List<string>> _PropertyErrors = new Dictionary<string, List<string>>();


        string pattern = "^[0-9.]+$";// string pattern consists of 0-9 and "."


        //calling vector3D objects in vectorviewmodel
        private Vector3D _vector1;
        private Vector3D _vector2;
        private Vector3D _CrossProduct;


        //public getter setter to bound them to input controls
        public Vector3D Vector1
        {
            get { return _vector1; }
            set
            {
                _vector1 = value;

                /*To check if user entered data other than string pattern. */
                string input=_vector1.X.ToString();
                if(input!=pattern)
                {
                    //AddError(nameof(Vector1),"Input Not Valid");
                }

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


       

        //Function to compute cross product
        private Vector3D ComputeCrossProduct()
        {
            return Vector3D.CrossProduct(Vector1, Vector2);//Calling function from Vector library 

        }

        //Button click event directs to this internal function 
        internal Vector3D Compute()
        {
           return ComputeCrossProduct();
        }

        //
        public event PropertyChangedEventHandler? PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// Data Validation code
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        /// 

        public bool HasErrors => _PropertyErrors.Any();

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            return _PropertyErrors.GetValueOrDefault(propertyName, null);
        }

        private void AddError(string PropertyName, string errorMessage)
        {
            if (!_PropertyErrors.ContainsKey(PropertyName))
            {
                _PropertyErrors.Add(errorMessage, new List<string>());
            }

            _PropertyErrors[PropertyName].Add(errorMessage);
            OnErrorsChanged(PropertyName);
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
