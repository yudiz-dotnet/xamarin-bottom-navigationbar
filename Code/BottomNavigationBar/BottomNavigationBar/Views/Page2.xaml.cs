using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomNavigationBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            GridFooter.Children.Add(new UserControls.BottomNavigationBarView(Constants.MenuConst.MenuPage2));
        }
	}
}