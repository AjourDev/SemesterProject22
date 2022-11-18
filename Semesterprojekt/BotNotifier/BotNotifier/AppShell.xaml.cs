using System;
using System.Collections.Generic;
using BotNotifier.ViewModels;
using BotNotifier.Views;
using Xamarin.Forms;

namespace BotNotifier
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

