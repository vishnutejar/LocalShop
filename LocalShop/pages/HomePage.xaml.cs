using LocalShop.model;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalShop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        ObservableCollection<MenuItems> menuItems{ get; set; }
        public HomePage()
        {
            InitializeComponent();
            MenuData();
        }

        void MenuData() {

            menuItems = new ObservableCollection<MenuItems>();
            menuItems.Add(new MenuItems { Title="Settings",MenuIcon="icon.png" });
            menuItems.Add(new MenuItems { Title = "Help & Support", MenuIcon = "icon.png" });
            menuItems.Add(new MenuItems { Title = "About Us", MenuIcon = "icon.png" });

            listOfMenus.ItemsSource = menuItems;
        }
    }
}