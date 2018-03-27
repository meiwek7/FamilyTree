using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.View;
using System.Windows;

namespace Client.ViewModel
{
    static class WindowViewLoaderService
    {
        static Dictionary<Type, Type> Dictionary = new Dictionary<Type, Type>();
        static public void Register(Type TypeofViewModel, Type TypeofView)
        {
            Dictionary.Add(TypeofView, TypeofViewModel);
        }
        static public void Show(Type ChildViewModel)
        {
            Type NewWindowType = Dictionary[ChildViewModel];
            var NewWindow = Activator.CreateInstance(NewWindowType);
            (NewWindow as Window).ShowDialog();
        }
    }
}
