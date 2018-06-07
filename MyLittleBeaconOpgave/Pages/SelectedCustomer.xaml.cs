using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MyLittleBeaconOpgave.Models;
using MyLittleBeaconOpgave.ViewModel;

namespace MyLittleBeaconOpgave.Pages
{
    public partial class SelectedCustomer : ContentPage
    {
        public List<Customer> CustomerList { get; set; }
        public SelectedCustomer(Customer customer)
        {
            BindingContext = new SelectedCustomerViewModel(customer);
            InitializeComponent();
        }
    }
}
