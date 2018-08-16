using System;
using System.Collections.Generic;
using System.Text;

namespace BottomNavigationBar.ViewModels
{
    public class BottomNavigationBarViewModel : BaseViewModel
    {
        private string _IconPage1, _IconPage2, _IconPage3, _IconPage4, _IconPage5;

        public string IconPage1
        {
            get { return _IconPage1; }
            set { _IconPage1 = value; NotifyPropertyChanged("IconPage1"); }
        }

        public string IconPage2
        {
            get { return _IconPage2; }
            set { _IconPage2 = value; NotifyPropertyChanged("IconPage2"); }
        }

        public string IconPage3
        {
            get { return _IconPage3; }
            set { _IconPage3 = value; NotifyPropertyChanged("IconPage3"); }
        }

        public string IconPage4
        {
            get { return _IconPage4; }
            set { _IconPage4 = value; NotifyPropertyChanged("IconPage4"); }
        }

        public string IconPage5
        {
            get { return _IconPage5; }
            set { _IconPage5 = value; NotifyPropertyChanged("IconPage5"); }
        }

        public BottomNavigationBarViewModel(string active)
        {
            SetMenu(active);
        }

        private void SetMenu(string active)
        {
            // Set all unselected icons to all tabs 
            IconPage1 = "ic_page_deselected.png";
            IconPage2 = "ic_page_deselected.png";
            IconPage3 = "ic_page_deselected.png";
            IconPage4 = "ic_page_deselected.png";
            IconPage5 = "ic_page_deselected.png";

            // active only one which is active in bottom navigation bar
            switch (active)
            {
                case Constants.MenuConst.MenuPage1:
                    IconPage1 = "ic_page_selected.png";
                    break;

                case Constants.MenuConst.MenuPage2:
                    IconPage2 = "ic_page_selected.png";
                    break;

                case Constants.MenuConst.MenuPage3:
                    IconPage3 = "ic_page_selected.png";
                    break;

                case Constants.MenuConst.MenuPage4:
                    IconPage4 = "ic_page_selected.png";
                    break;

                case Constants.MenuConst.MenuPage5:
                    IconPage5 = "ic_page_selected.png";
                    break;
            }
        }
    }
}
