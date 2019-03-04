using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using ValidationResult = System.Windows.Controls.ValidationResult;

namespace ValidationDemo.ViewModels
{
    public class ValidatableBindableBase : BindableBase, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _validationErrors = new Dictionary<string, List<string>>();

        public IEnumerable GetErrors(string propertyName)
        {
            if (_validationErrors.ContainsKey(propertyName))
                return _validationErrors[propertyName];
            return null;
        }


        public bool HasErrors => _validationErrors.Count > 0;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        protected override void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            base.SetProperty(ref member, val, propertyName);
            ValidateProperty(propertyName, val);
        }

        private void ValidateProperty<T>(string propertyName, T val)
        {
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            ValidationContext context = new ValidationContext(this);
            context.MemberName = propertyName;
            Validator.TryValidateProperty(val, context, results);
            if (results.Any())
            {
                _validationErrors[propertyName] = results.Select(c => c.ErrorMessage).ToList(); 
            }
            else
            {
                _validationErrors.Remove(propertyName);
            }
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}