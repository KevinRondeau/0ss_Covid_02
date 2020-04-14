using BillingManagement.Business;
using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    public class InvoiceViewModel :BaseViewModel
    {
		private Invoice invoice;

		public Invoice Invoice
		{
			get { return invoice; }
			set
			{
				invoice = value;
				OnPropertyChanged();
			}
		}

	}
}
