using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomNavigationBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            GridFooter.Children.Add(new UserControls.BottomNavigationBarView(Constants.MenuConst.MenuPage4));
        }
	}
}