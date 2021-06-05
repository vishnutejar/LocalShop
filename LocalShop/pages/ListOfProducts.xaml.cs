using LocalShop.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalShop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOfProducts : ContentPage
    {
        ObservableCollection<HeaderData> headerDatas { get; set; }
        public ListOfProducts()
        {
            InitializeComponent();
            SetHeaderData();
        }

        void SetHeaderData() {

            headerDatas = new ObservableCollection<HeaderData>();
            headerDatas.Add(new HeaderData {  HeaderName="Enjoy your favouite treats"});
            headerDatas.Add(new HeaderData {  HeaderName="Daily essentailals delivered safely"});
            headerDatas.Add(new HeaderData {  HeaderName="Anything your need delivered"});
            headerDatas.Add(new HeaderData {  HeaderName="Fresh meet & Sea food"});
            headerDatas.Add(new HeaderData {  HeaderName="Care Corner"});
            headerDatas.Add(new HeaderData {  HeaderName="Hearth Hub"});
            listOfProductsInHorizantal.ItemsSource = headerDatas;
            carouselviewlistdata.ItemsSource = headerDatas;
            listOfProductsinvertical.ItemsSource = headerDatas;
            listOfProductsinverticalgrid.ItemsSource = headerDatas;
            listOfProductsinhorizatalgrid.ItemsSource = headerDatas;
            carouselviewlistdata.BackgroundColor = Color.LightBlue;
        }

        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string previous = (e.PreviousSelection.FirstOrDefault() as HeaderData)?.HeaderName;
            var current = e.CurrentSelection;

          //  DisplayAlert("",current,"ok");
        }
        double totalHeight = 0;

        private void ViewCell_SizeChanged(object sender, EventArgs e)
        {
            if (sender is Grid)
            {
                Grid grid = (Grid)sender;

                totalHeight += grid.Height;
                totalHeight += grid.Margin.Top;
                totalHeight += grid.Margin.Bottom;
            }
        }
    }
}