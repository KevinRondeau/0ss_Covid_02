
using BillingManagement.Business;
using BillingManagement.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BillingManagement.UI.ViewModels
{
    class CustomerViewModel : BaseViewModel
    {

        private Customer customer;
 
        public Customer Customer
        {
            get { return customer; }
            set {
                customer = value;
                OnPropertyChanged();
            }
        }

      
    }
}
