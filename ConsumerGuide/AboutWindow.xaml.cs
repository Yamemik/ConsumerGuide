using System.Windows;

namespace ConsumerGuide
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            ManagerOleDB managerOleDB = new ManagerOleDB();
            int row = ManagerOleDB.row;
            txtName.Text = managerOleDB.DataBaseTable("Select * from Service",1);
            txtAdress.Text = managerOleDB.DataBaseTable("Select * from Service", 2);
            txtPhone.Text = managerOleDB.DataBaseTable("Select * from Service", 3);
            txtMode.Text = managerOleDB.DataBaseTable("Select * from Service", 4);
            txtCategory.Text = managerOleDB.DataBaseTable("Select * from Service", 5);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
