using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MyLittleBeaconOpgave.Models;

namespace MyLittleBeaconOpgave.Pages
{
    public partial class SelectedCustomer : ContentPage
    {
        public List<Customer> CustomerList { get; set; }
        public SelectedCustomer()
        {
            //BindingContext = new
            InitializeComponent();
        }
    }
}
