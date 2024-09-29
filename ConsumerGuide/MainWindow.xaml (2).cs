using System.Data;
using System.Windows;

namespace ConsumerGuide
{
    public partial class MainWindow : Window
    {
        int k;
        public MainWindow()
        {
            InitializeComponent();
            ManagerOleDB managerOleDB = new ManagerOleDB();
            dgService.ItemsSource = managerOleDB.BindGrid("Select * from Service");
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dgService.SelectedItems[0];

            k = (int)row["S_ID"]-1;
            ManagerOleDB.row = k;

            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void btnExit_Close(object sender, RoutedEventArgs e)
        {
            var ee = MessageBox.Show("Выйти?", "exit", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
            if(ee == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            string s = txtFind.Text;

            ManagerOleDB managerOleDB = new ManagerOleDB();
            dgService.ItemsSource = managerOleDB.BindGrid("Select * from Service where S_Name = '" + s +"'" );
        }

        private void btnInfp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Справочник потребителя (служба быта)\nКунгурова Дарья");
        }
    }
}
