using NavigationWPFwithCommandMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationWPFwithCommandMVVM.ViewModels
{
    class A_VM : BaseViewModel
    {
        public ICommand GotoBcommand { get; set; }
        private object selectedViewModel;
        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public A_VM()
        {
            GotoBcommand = new NavigationCommand(NavigateToB);
        }
        private void NavigateToB(object obj)
        {
            SelectedViewModel = new B_VM();
        }
    }
}
