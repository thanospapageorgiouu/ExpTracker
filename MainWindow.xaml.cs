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
using ExpTracker.Models;
using ExpTracker.Services;

namespace ExpTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ExpenseStorageService _storageService = new ExpenseStorageService();
        private List<Expense> _expenses = new List<Expense>();

        private void AddExpense_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add clicked!");
        }


        public List<Expense> Expenses
        {
            get { return _expenses; }
        }


        public MainWindow()
        {
            InitializeComponent();
            _expenses = _storageService.LoadExpenses();
        }
    }
}