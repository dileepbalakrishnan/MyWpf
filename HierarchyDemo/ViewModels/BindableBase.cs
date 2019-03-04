using System.ComponentModel;
using System.Runtime.CompilerServices;
using HierarchyDemo.Annotations;

namespace HierarchyDemo.ViewModels
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            if (Equals(member, val)) return;
            member = val;
            OnPropertyChanged(propertyName);
        }
    }
}