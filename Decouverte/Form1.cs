using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decouverte
{



    public partial class Form1 : Form
    {

      
        
        
        
        
        public Form1()
        {
            InitializeComponent();
            List<Actions> actions = new List<Actions>();
            Actions Thales = new Actions("Thales", 134);
            actions.Add(Thales);
            actionslist.Items.Add(Thales.name);
            Actions Schneider = new Actions("Schneider", 195);
            actions.Add(Schneider);
            actionslist.Items.Add(Schneider.name);
            Actions Vinci = new Actions("Vinci", 116);
            actions.Add(Vinci);
            actionslist.Items.Add(Vinci.name);
            Actions LVMH = new Actions("LVMH", 822);
            actions.Add(LVMH);
            actionslist.Items.Add(LVMH.name);
            Actions TotalEnergies = new Actions("TotalEnergies", 60);
            actions.Add(TotalEnergies);
            actionslist.Items.Add(TotalEnergies.name);
            Actions Sanofi = new Actions("Sanofi", 86);
            actions.Add(Sanofi);
            actionslist.Items.Add(Sanofi.name);
            Portefeuille portf = new Portefeuille(0, actions);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void nbactions_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strnombres_actions = nbactions.Text;
            int nb_actions = (int)strnombres_actions;
            string nom_actions = actionslist.SelectedItem.ToString();
            portefeuille.Items.Add(nombres_actions + " " + nom_actions);
            
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void portefeuille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }








    public class Actions
    {
        public string name;
        public float price;
        public Actions(string nom, float prix)
        {
            name = nom;
            price = prix;
        }
        public void Updateprice(float prix)
        {
            price = prix;
        }

    }


    public class Portefeuille
    {
        public float total;
        public List<int> nbactions;
        public List<Actions> actions;

        public Portefeuille(float tot,List<Actions> acts)
        {
            total = tot;
            nbactions = new List<int>(6);
            actions = acts;

        }

        public void Ajoutnbactions(int pos,int nb)
        {
            nbactions.Insert(pos, nb);
        }
    }




}
