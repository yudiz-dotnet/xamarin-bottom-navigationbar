using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomNavigationBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            GridFooter.Children.Add(new UserControls.BottomNavigationBarView(Constants.MenuConst.MenuPage3));
        }
	}
}