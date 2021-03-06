﻿using Restaurant.Abstractions.Managers;
using Restaurant.ViewModels;
using Xamarin.Forms;

namespace Restaurant.Pages
{
    public partial class BasketPage : BasketPageXaml
    {
        public BasketPage(IThemeManager themeManager)
        {
            InitializeComponent();

            var theme = themeManager.GetThemeFromColor("green");
            ActionBarBackgroundColor = theme.Primary;
            NavigationBarColor = theme.Dark;
            StatusBarColor = theme.Dark;
            orders.ItemSelected += Orders_ItemSelected;
        }

        private void Orders_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            orders.SelectedItem = null;
        }

        protected override void OnLoaded()
        {
        }

        protected override void UnLoad()
        {
            orders.ItemSelected -= Orders_ItemSelected;
        }
    }

    public abstract class BasketPageXaml : BaseContentPage<OrderViewModel>
    {
    }
}
