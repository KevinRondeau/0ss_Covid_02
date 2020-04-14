﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BillingManagement.UI.Views
{
    /// <summary>
    /// Interaction logic for UserControl_InvoiceView.xaml
    /// </summary>
    public partial class UserControl_InvoiceView : UserControl
    {
        UserControl_InvoiceView _Ivm;
        public UserControl_InvoiceView(UserControl_InvoiceView Ivm)
        {
                _Ivm = Ivm;
                DataContext = _Ivm;
            
        }
    }
}
