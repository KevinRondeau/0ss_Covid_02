using BillingManagement.UI.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    class MainViewModel:BaseViewModel
    {
		private BaseViewModel leftViewModel;

		public BaseViewModel LeftViewModel
		{
			get { return leftViewModel; }
			set
			{
				leftViewModel = value;
				OnPropertyChanged();
			}
		}

		private BaseViewModel centralViewModel;

		public BaseViewModel CentralViewModel
		{
			get { return centralViewModel; }
			set
			{
				centralViewModel = value;
				OnPropertyChanged();
			}
		}

		CustomersListViewModel customerListViewModel;
		CustomerViewModel customerViewModel;

		InvoiceListViewModel invoiceListViewModel;
		InvoiceViewModel invoiceViewModel;

		public ChangeViewCommand ChangeViewCommand { get; set; }


		public MainViewModel()
		{
			//ChangeViewCommand = new ChangeViewCommand(ChangeView);

			customerViewModel = new CustomerViewModel();
			customerListViewModel = new CustomersListViewModel(customerViewModel);

			invoiceViewModel = new InvoiceViewModel();
			invoiceListViewModel = new InvoiceListViewModel(invoiceViewModel);

			LeftViewModel = customerListViewModel;
			CentralViewModel = customerViewModel;

		}
		//private void ChangeView(string vm)
		//{
		//	switch (vm)
		//	{
		//		case "Clients":
		//			LeftViewModel = customerListViewModel;
		//			CentralViewModel = customerViewModel;
		//			break;
		//		case "Factures":
		//			LeftViewModel = invoiceListViewModel;
		//			CentralViewModel = invoiceViewModel;
		//			break;
		//	}
		//}
	}
}
