using System;
using System.ComponentModel;
using System.Collections.Generic;
using MyLittleBeaconOpgave.Models;
using MyLittleBeaconOpgave.Data;
namespace MyLittleBeaconOpgave.ViewModel
{
    public class SelectedCustomerViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        List<Customer> customerList;
        private Customer _selectedValue;
        List<SalesOrder> salesOrderList;
        List<Item> itemList;


        public List<Customer> CustomerList
        {
            get
            {
                return customerList;
            }
            set
            {
                customerList = value;
                OnPropertyChanged("CustomerList");
            }
        }

        public List<SalesOrder> SalesOrderList
        {
            get
            {
                return salesOrderList;
            }
            set
            {
                salesOrderList = value;
                OnPropertyChanged("SalesOrderList");
            }
        }

        public List<Item> ItemList
        {
            get
            {
                return itemList;
            }
            set
            {
                itemList = value;
                OnPropertyChanged("ItemList");
            }
        }

        public Customer SelectedValue
        {
            get
            {
                return _selectedValue;
            }
            set
            {
                _selectedValue = value;
                OnPropertyChanged("SelectedValue");
            }
        }

        public void GetDbList()
        {
            App.CustomerController.GetCustomer();
            CustomerList = App.CustomerController.tableList;

            App.salesOrderController.GetSalesOrder();
            SalesOrderList = App.SalesOrderController.tableListSalesOrder;

            App.itemController.GetItems();
            ItemList = App.ItemController.tableListItem;

        }



        public SelectedCustomerViewModel()
        {
        }
    }
}
