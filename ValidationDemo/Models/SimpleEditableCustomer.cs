using System;
using System.ComponentModel.DataAnnotations;
using ValidationDemo.ViewModels;

namespace ValidationDemo.Models
{
    public class SimpleEditableCustomer : ValidatableBindableBase
    {
        private string _email;

        private string _firstName;
        private Guid _id;

        private string _lastName;

        private string _phone;

        public Guid Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Required]

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        [Required]

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        [EmailAddress]

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        [Phone]

        public string Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
        }
    }
}