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
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BankingSecurityApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new BankingDbContext())
            {
                Customers = new ObservableCollection<Customer>(db.Customers.ToList());
                DataContext = this;
            }
        }
    }
}