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

namespace Progetto_Personale
{
    /// <summary>
    /// Logica di interazione per Window2.xaml
    /// </summary>
    public partial class Aziendale : Window
    {
        private string[] qualifiche = new string[] { "Dirigente", "Quadro", "Amministrativo", "Operaio" };
        private PersonaleAziendale p;
        public Aziendale(PersonaleAziendale p) // passo le variabili del personale aziendale tramite il costruttore, che serviranno per i parametri dichiarati nel form
        {
            this.p = p;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
