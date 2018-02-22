﻿using Prism;
using Prism.Ioc;
using Prism.DryIoc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo2.Views;
using Demo2.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Demo2
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainPage/NavigationPage/Page1");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Page1, Page1ViewModel>();
            containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();
            containerRegistry.RegisterForNavigation<Page3, Page3ViewModel>();
        }
    }
}
