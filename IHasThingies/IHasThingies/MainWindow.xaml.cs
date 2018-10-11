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

namespace IHasThingies {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            SuperHero h = new SuperHero("Super", "Man");
            Citizen c = new Citizen("Clark", "Kent");
            SuperHero b = new SuperHero("Bat", "Man");

            Person[] arrPerson = new Person[5];
            List<Person> lstPerson = new List<Person>();

            for (int i = 0; i < 6; i++) {
                lstPerson.Add(h);
             //  arrPerson[i] = h;
            }

            SuperHero dude = new SuperHero();

            dude.FirstName = "Duder";


            //h.Alias = c;
            //c.SecretIdentity = h;

            //c.FirstName = "Bob";
            //c.SecretIdentity.Alias.FirstName = "Sam";



            //MessageBox.Show(h.FullName); // Super Man
            //MessageBox.Show(c.FullName); // Clark Kent
            //MessageBox.Show(h.Alias.FullName); // Clark Kent
            //MessageBox.Show(h.Alias.SecretIdentity.Alias.FullName); // Clark Kent
            LoadJet(h);
        }

        private void LoadJet(SuperHero h) {
            Jet invisible = new Jet(2);
            invisible.RightWing.Length = invisible.LeftWing.Length = 12;
            string a = invisible + h;

        }
    }
}
