using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Log.xaml
    /// </summary>
    public partial class Log : Window
    {
        public ObservableCollection<Group> Groups = new ObservableCollection<Group>();
        public Log()
        {
            InitializeComponent();
            using (var db = new DBContext())
            {
                
                List<Group> GroupList = db.Groups.ToList();
                foreach(Group group in GroupList)
                {
                    groups.Items.Add(group);
                }
            }
        }
    }
}
