using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomNavigationBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
            GridFooter.Children.Add(new UserControls.BottomNavigationBarView(Constants.MenuConst.MenuPage5));
        }
    }
}