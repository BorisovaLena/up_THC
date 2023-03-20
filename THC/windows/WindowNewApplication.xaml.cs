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
using System.Windows.Shapes;

namespace THC.windows
{
    /// <summary>
    /// Логика взаимодействия для WindowNewApplication.xaml
    /// </summary>
    public partial class WindowNewApplication : Window
    {
        public WindowNewApplication( TableClient client)
        {
            InitializeComponent();
            tbNumberAppl.Text = client.TableTreaty.TreatyPersonalAccount + "/" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            dpDate.SelectedDate = DateTime.Now;
            tbNumberClient.Text = client.ClientID;
            tbNumberLC.Text = client.TableTreaty.TreatyPersonalAccount.ToString();
            cmbServices.Items.Add("Выберите услугу");
            List<TableServiceTreaty> tableServiceTreaties = clasess.ClassBase.Base.TableServiceTreaty.Where(z => z.ServiceTreatyTreatyID == client.TableTreaty.TreatyNumber).ToList();
            foreach (TableServiceTreaty treaty in tableServiceTreaties)
            {
                cmbServices.Items.Add(treaty.TableService.ServiceName);
            }
            cmbServices.SelectedIndex = 0;

        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
