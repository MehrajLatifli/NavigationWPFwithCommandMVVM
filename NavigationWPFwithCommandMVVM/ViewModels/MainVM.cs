using NavigationWPFwithCommandMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationWPFwithCommandMVVM.ViewModels
{
    class MainVM : BaseViewModel
    {
        public ICommand GotoAcommand { get; set; }
        public ICommand GotoBcommand { get; set; }


        private object selectedViewModel;
        private object selectedViewModel2;

        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public object SelectedViewModel2
        {
            get { return selectedViewModel2; }
            set
            {
                selectedViewModel2 = value;
                OnPropertyChanged(nameof(SelectedViewModel2));
            }
        }


        public MainVM()
        {
            GotoAcommand = new NavigationCommand(NavigateToA);
            GotoBcommand = new NavigationCommand(NavigateToB);
        }
        private void NavigateToA(object obj)
        {
            SelectedViewModel = new A_VM();
        }

        private void NavigateToB(object obj)
        {
            SelectedViewModel2 = new B_VM();
        }
    }
}
