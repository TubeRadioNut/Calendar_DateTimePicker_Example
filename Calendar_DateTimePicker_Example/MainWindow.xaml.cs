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

namespace Calendar_DateTimePicker_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//Don't delete this and keep at the top of MainWindow()

            

        }//end of MainWindow()

        private void btnDispayDate_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = DateTime.Now;
            bool dtpHasValue = dtpDate.SelectedDate != null;
            bool calHasValue = calDate.SelectedDate != null;
            if (dtpHasValue)
            {
                selectedDate = (DateTime)dtpDate.SelectedDate;
                MessageBox.Show($"{selectedDate}\n");
            }
            else if(calHasValue)
            {
                selectedDate = (DateTime)calDate.SelectedDate;
                MessageBox.Show($"{selectedDate}\n");
            }
            else
            {
                MessageBox.Show($"{dtpHasValue}\n{calHasValue}");
            }
            
        }
    }//end of class

}//end of namespace