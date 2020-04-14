using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingManagement.Business
{
    //3. Ajoutez une classe InvoicesDataService qui implémente la bonne interface avec le bon type.

    //o Dans le constructeur InvoicesDataService et en vous fiant sur le code précédent, ajoutez du code pour générer des Invoices pour chaque client.
    public class InvoiceDataService : IDataService<Invoice>
    {
        List<Customer> Customers = new CustomersDataService().GetAll().ToList();
        readonly  List<Invoice> invoices= new List<Invoice>();
        

        public InvoiceDataService()
        {

            Random rdm = new Random();

            for(int i = 0; i< 150; i++)
            {
                int rando = rdm.Next(20, 2000);
                int randoC=rdm.Next(Customers.Count);
                Customer C = Customers[randoC];
                Invoice invoicee = new Invoice() { SubTotal = rando,Customer=C };
               
                invoices.Add(invoicee);
            }
        }

        public IEnumerable<Invoice> GetAll()
        {
            foreach (Invoice i in invoices)
            {
                yield return i;
            }
        }
    }
}
