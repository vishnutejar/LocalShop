using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalShop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailTabbedPage : TabbedPage
    {
        public DetailTabbedPage()
        {
            InitializeComponent();
        }
    }
}