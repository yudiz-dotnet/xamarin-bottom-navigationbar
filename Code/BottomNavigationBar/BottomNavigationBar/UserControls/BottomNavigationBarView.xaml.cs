using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomNavigationBar.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomNavigationBarView : ContentView, IDisposable
    {
        public BottomNavigationBarView(string active)
        {
            InitializeComponent();
            BindingContext = new ViewModels.BottomNavigationBarViewModel(active);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            stckIconPage1.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(_ =>
                {
                    Application.Current.MainPage = new Views.Page1();
                })
            });
            stckIconPage2.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(_ =>
                {
                    Application.Current.MainPage = new Views.Page2();
                })
            });

            stckIconPage3.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(_ =>
                {
                    Application.Current.MainPage = new Views.Page3();
                })
            });

            stckIconPage4.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(_ =>
                {
                    Application.Current.MainPage = new Views.Page4();
                })
            });

            stckIconPage5.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(_ =>
                {
                    Application.Current.MainPage = new Views.Page5();
                })
            });
        }
    }
}