using BillingManagement.Business;
using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    class InvoiceViewModel :BaseViewModel
    {
        readonly InvoiceDataService invoiceDataService = new InvoiceDataService();

        private ObservableCollection<Invoice> invoices;
        private Invoice selectedInvoice;

        public ObservableCollection<Invoice> Invoices
        {
            get => invoices;
            private set
            {
               invoices= value;
                OnPropertyChanged();
            }
        }

        public Invoice SelectedInvoice
        {
            get => selectedInvoice;
            set
            {
                selectedInvoice = value;
                OnPropertyChanged();
            }
        }

        public InvoiceViewModel()
        {
            InitValues();
        }

        private void InitValues()
        {
            Invoices = new ObservableCollection<Invoice>(invoiceDataService.GetAll());
            Debug.WriteLine(invoices.Count);
        }


    }
}
