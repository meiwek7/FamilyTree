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
        static public Dictionary<Type, Type> RegTypes = new Dictionary<Type, Type>();
        static public Dictionary<ViewModelBase, Window> VMContexts = new Dictionary<ViewModelBase, Window>();

        static public void Register(Type TypeofViewModel, Type TypeofView)
        {
            RegTypes.Add(TypeofView, TypeofViewModel);
        }

        static public void Show(Type ViewModelType)
        {
            Type NewWindowType = RegTypes[ViewModelType];
            var NewWindow = Activator.CreateInstance(NewWindowType) as Window;
            var tmpContext  = (NewWindow as Window).DataContext as ViewModelBase;
            VMContexts.Add(tmpContext, NewWindow);
            NewWindow.Show();
        }

        static public object getContext(Type WindowViewModelType)
        {
            var tmp = VMContexts.Keys.Where(x => x.GetType() == WindowViewModelType).First();
            return tmp;
        }
    }
}
