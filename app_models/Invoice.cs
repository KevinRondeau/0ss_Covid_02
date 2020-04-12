using app_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BillingManagement.Models
{
    public class Invoice:INotifyPropertyChanged
    {
        //        1. Ajoutez le modèle « Invoice » avec les propriétés qui suivent :

        //a. int InvoiceId : Identifiant autoincrémenté.i.Voir la première partie de la réponse ici.

        //b.DateTime CreationDateTime : Propriété en lecture seule

        //c.Customer Customer : Doit notifier les changements pour lui-même.Il s’agit du propriétaire de la facture

        //d.Double SubTotal : Doit notifier les changements pour lui-même et les propriétés FedTax, ProvTax et Total

        //e. Double FedTax : Retourne la multiplication de SubTotal par 5%

        //f.Double ProvTax : Retourne la multiplication de SubTotal par 9.975%

        //g.Double Total : Retourne la somme de SubTotal, FedTax et ProvTax.

        private static List<bool> UsedCounter = new List<bool>();
        private int invoiceId;
        private Customer customer;
        private double subTotal;
        private double fedTax;
        private double provTax;
        private double total;

        public int InvoiceId { get => invoiceId; private set => invoiceId = value; }
        public readonly DateTime CreationDateTime;

        public Customer Customer { get=>Customer;
            set
            {
                customer = value;
                OnPropertyChanged();
            }
        }
        public double SubTotal
        {
            get => subTotal;
            set
            {
                subTotal = value;
                OnPropertyChanged();
            }
        }

        public double FedTax
        {
           get=> SubTotal*0.05;
        }
        public double ProvTax
        {
            get => SubTotal * 0.09975;
        }
        public double Total
        {
            get => (SubTotal+FedTax+ProvTax);
        }
        private int GetAvailableIndex()
        {
            bool found = false;
            int i = 0;
            while (found != true)
            {
                if (UsedCounter[i] != true)
                {
                    found = true;
                }
                else
                    i++;
            }
            return i;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //2. Dans le modèle « Invoice », ajoutez les constructeurs qui suivent :

        //a.Un constructeur de base qui instancie CreationDateTime avec le moment de la création.

        //b.Un constructeur avec un Customer en paramètre qui associe la propriété Customer avec le customer fournit en paramètre et ne pas oublier la CreationDatetime.
        public Invoice()
        {
            CreationDateTime = DateTime.Now;
        }
        public Invoice(Customer cust)
        {
            CreationDateTime = DateTime.Now;
            Customer = cust;
        }
    }
}
