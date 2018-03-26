using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using Client.Infrastructure;
using System.Windows.Input;

namespace Client.ViewModel
{
    class AuthorizationViewModel : ViewModelBase
    {
        User user;
        RelayCommand _enterCommand;

        public AuthorizationViewModel()
        {
            user = new User();
        }
        //public RelayCommand Enter
        //{
        //    get
        //    {
        //        return enter ?? (enter = new RelayCommand(obj => {
        //            //Запихиваем в базу
        //            TeacherDAO.InsertStudent(new Student
        //            {
        //                Name = StudentName,
        //                Surname = StudentSurname,
        //                Teacherid = CurrentTeacher.Id
        //            });
        //            //(Запихиваем) Обновляем (к) учителю (в) коллекцию в ЮзерИнтерфейсе
        //            //ContextMWVM.CurrentCollectionTeachers.ToList().Find(x => x.Id == CurrentTeacher.Id).StudentsCollection.Add(new Student
        //            //{
        //            //    Name = StudentName,
        //            //    Surname = StudentSurname,
        //            //    Teacherid = CurrentTeacher.Id
        //            //});
        //            ContextMWVM.CurrentCollectionTeachers.ToList().Find(x => x.Id == CurrentTeacher.Id).StudentsCollection = null;
        //            //Закрываем
        //            (obj as View.AddWindowStudent).Close();
        //        }, obj => {
        //            if (CurrentTeacher != null && StudentName != null && StudentName != "" && StudentSurname != null && StudentSurname != "")
        //                return true;
        //            return false;
        //        }));
        //    }
        //}
        #region Enter
        public ICommand EnterCommand { get {
                if(_enterCommand==null)
                {
                    _enterCommand = new RelayCommand(ExecuteEnterCommand, CanExecuteEnterCommand);
                }
                return _enterCommand;
            } }
        private void ExecuteEnterCommand(object param)
        {
            //var result = ConLogic.Channel.Auth(user);
            var result = ConLogic.Proxy.Auth(user);
        }
        private bool CanExecuteEnterCommand(object param)
        {
            return true;
        }
        #endregion
        public User User { get => user; set => user = value; }
    }
}
