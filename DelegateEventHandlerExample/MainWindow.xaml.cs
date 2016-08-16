using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/* This is a delegate and event handler example with two examples.
 * One example is of custom delegate and event handler. 
 * The other is of in-built delegate and event handler.
 * */
namespace DelegateEventHandlerExample
{
    
    /// Interaction logic for MainWindow.xaml
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //delegate calling sumdel handler
            NumDelegate sumDel = new NumDelegate(CustomDelegate.sumOfNumbers);
           txtSum.Text=( sumDel(4, 5)).ToString();
            //delegate calling proddel handler
            NumDelegate prodDel = new NumDelegate(CustomDelegate.prodOfNumbers);
            txtProduct.Text = (prodDel(4, 5)).ToString();
        }
    }
}
