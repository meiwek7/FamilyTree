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

        static public void Show(Type ChildViewModel)
        {
            Type NewWindowType = RegTypes[ChildViewModel];
            //VMContexts.Add(NewWindowType, RegTypes[NewWindowType].);
            var NewWindow = Activator.CreateInstance(NewWindowType);
            VMContexts.Add((Activator.CreateInstance(ChildViewModel) as ViewModelBase), NewWindow as Window);
            (NewWindow as Window).Show();
        }

        static public object getContext(Type WindowViewModelType)
        {
            var tmp = VMContexts.Keys.Where(x => x.GetType() == WindowViewModelType).First();
            return tmp;
        }
    }
}
