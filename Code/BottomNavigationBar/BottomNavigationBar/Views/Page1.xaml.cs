using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomNavigationBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            GridFooter.Children.Add(new UserControls.BottomNavigationBarView(Constants.MenuConst.MenuPage1));
        }
	}
}