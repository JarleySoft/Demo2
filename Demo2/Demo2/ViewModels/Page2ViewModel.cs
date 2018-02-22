using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Demo2.Infrastructure;

namespace Demo2.ViewModels
{
    public class Page2ViewModel : AppMapViewModelBase
    {


        public Page2ViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
