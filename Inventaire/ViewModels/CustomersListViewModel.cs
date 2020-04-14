using BillingManagement.Business;
using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    class CustomersListViewModel:BaseViewModel
    {
		private ObservableCollection<Customer> customers;

		public ObservableCollection<Customer> Customers
		{
			get { return customers; }
			set
			{
				customers = value;
				OnPropertyChanged();
			}
		}

		private Customer selectedCustomer;

		public Customer SelectedCustomer
		{
			get { return selectedCustomer; }
			set
			{
				selectedCustomer = value;
				customerViewModel.Customer= selectedCustomer;
				OnPropertyChanged();
			}
		}

		public CustomersDataService customersDataService;
		CustomerViewModel customerViewModel;

		public CustomersListViewModel(CustomerViewModel cvm)
		{
			InitValues();

			customerViewModel = cvm;
		}

		private void InitValues()
		{
			customersDataService = new CustomersDataService();
			Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
		}

	}
}

