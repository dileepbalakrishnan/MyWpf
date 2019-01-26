using System.ComponentModel;

namespace ChangeNotificationDemo
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                var pc = PropertyChanged;
                pc?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
            }
        }
    }
}