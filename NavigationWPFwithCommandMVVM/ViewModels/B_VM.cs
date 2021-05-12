using NavigationWPFwithCommandMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationWPFwithCommandMVVM.ViewModels
{
    class B_VM : BaseViewModel
    {
        public ICommand GotoAcommand { get; set; }
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

        public B_VM()
        {
            GotoAcommand = new NavigationCommand(NavigateToA);
        }
        private void NavigateToA(object obj)
        {
            SelectedViewModel = new A_VM();
        }
    }
}
