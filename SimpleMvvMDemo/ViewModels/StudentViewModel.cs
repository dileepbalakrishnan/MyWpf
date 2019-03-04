using System.Collections.ObjectModel;
using SimpleMvvMDemo.Commands;
using SimpleMvvMDemo.Models;

namespace SimpleMvvMDemo.ViewModels
{
    public class StudentViewModel
    {
        private StudentModel _selectedStudent;

        public StudentViewModel()
        {
            Students = new ObservableCollection<StudentModel>();
            DeleteCommand = new DeleteCommand(OnDelete, CanDelete);
            LoadStudents();
        }

        public DeleteCommand DeleteCommand { get; set; }

        public StudentModel SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<StudentModel> Students { get; set; }

        private bool CanDelete()
        {
            return _selectedStudent != null;
        }

        private void OnDelete()
        {
            Students.Remove(_selectedStudent);
        }

        private void LoadStudents()
        {
            Students.Add(new StudentModel {FirstName = "Dileep", LastName = "Balakrishnan"});
            Students.Add(new StudentModel {FirstName = "John", LastName = "Honai"});
            Students.Add(new StudentModel {FirstName = "James", LastName = "Bond"});
            Students.Add(new StudentModel {FirstName = "Ethan", LastName = "Hunt"});
        }
    }
}