using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Decouverte
{



    public partial class Form1 : Form
    {

      
        
        
        
        
        public Form1()
        {
            InitializeComponent();
            valportefeuillestr.Text = "0€";
            totversements.Text = "0€";
            aff_benef.Text = "0€";
            actions.Add(Thales);
            actions.Add(Schneider);
            actions.Add(Vinci);
            actions.Add(LVMH);
            actions.Add(TotalEnergies);
            actions.Add(Sanofi);
            tree_actionslist.Nodes.Add("Actions");
            for(int i=0; i<actions.Count; i++)
            {
                tree_actionslist.Nodes[0].Nodes.Add(actions[i].name);
            }
            portf.UpdateConstr();
            info1.Hide();
            info2.Hide();
            info3.Hide();



        }
        public int i = 0;
        public static List<Actions> actions = new List<Actions>();
        public Actions Thales = new Actions("Thales", 134);
        public Actions Schneider = new Actions("Schneider", 195);
        public Actions Vinci = new Actions("Vinci", 116);
        public Actions LVMH = new Actions("LVMH", 822);
        public Actions TotalEnergies = new Actions("TotalEnergies", 60);
        public Actions Sanofi = new Actions("Sanofi", 86);
        public Portefeuille portf = new Portefeuille(actions);



        private void nbactions1_KeyPress(object sender, KeyPressEventArgs e)
        { //gestion des erreurs pour qu'il y a que des entiers en entrées
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {//Iscontrol c'est les touches "spéciales" du clavier, Isdigit c'est les chiffres
               
                e.Handled = true; //empêche d'écrire
            }
        }

        private void nbactions2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nbactions3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            
            if(nbactions1.Text != "") //gère l'erreur d'un ajout vide
            {
                int nb_actions = Convert.ToInt32(nbactions1.Text);
                if (nb_actions != 0) //gère l'erreur du 0 pour la répartition la première fois
                {
                    float montant_ajout = 0;
                    for (int i = 0; i < portf.actions.Count(); i++)
                    {
                        if (nom1.Text == portf.actions[i].name)
                        {
                            montant_ajout = nb_actions * portf.actions[i].price;
                        }
                    }
                    DialogResult reponse = MessageBox.Show("Voulez-vous ajoutez " + nb_actions + " actions " + nom1.Text + " à votre portefeuille pour un montant de " + montant_ajout + "€ ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reponse == DialogResult.Yes)
                    {
                        portf.Addactions(nom1, nb_actions, nb_actifs_portefeuille, portefeuille, portefeuille_prix, valportefeuillestr, totversements, aff_benef, repartactifs);
                    }
                }
                
            }
            
        }
        private void add2_Click(object sender, EventArgs e)
        {
            
            int nb_actions = Convert.ToInt32(nbactions2.Text);
            float montant_ajout = -1;
            for (int i = 0; i < portf.actions.Count(); i++)
            {
                if (nom2.Text == portf.actions[i].name)
                {
                    montant_ajout = nb_actions * portf.actions[i].price;
                }
            }
            DialogResult reponse = MessageBox.Show("Voulez-vous ajoutez " + nb_actions + " actions " + nom2.Text + " à votre portefeuille pour un montant de " + montant_ajout + "€ ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                portf.Addactions(nom2, nb_actions,nb_actifs_portefeuille, portefeuille, portefeuille_prix, valportefeuillestr, totversements, aff_benef, repartactifs);
            }
        }

        private void add3_Click(object sender, EventArgs e)
        {
            int nb_actions = Convert.ToInt32(nbactions3.Text);
            float montant_ajout = -1;
            for (int i = 0; i < portf.actions.Count(); i++)
            {
                if (nom3.Text == portf.actions[i].name)
                {
                    montant_ajout = nb_actions * portf.actions[i].price;
                }
            }
            DialogResult reponse = MessageBox.Show("Voulez-vous ajoutez " + nb_actions + " actions " + nom3.Text + " à votre portefeuille pour un montant de " + montant_ajout + "€ ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                portf.Addactions(nom3, nb_actions,nb_actifs_portefeuille, portefeuille, portefeuille_prix, valportefeuillestr, totversements, aff_benef, repartactifs);
            }
        }

        private void Portefeuille_DoubleClick(object sender, EventArgs e)
        {
            
            for(int i = 0;i < portf.actions.Count(); i++)
            {
                if (actions[i].name == portefeuille.SelectedItem.ToString() && actions[i].name != nom1.Text && actions[i].name != nom2.Text && actions[i].name != nom3.Text)
                {
                    info1.Show();
                    nom1.Text = portf.actions[i].name;
                    prix1.Text = portf.actions[i].price.ToString() + "€";
                }
            }
        }

      
       

        private void Tree_actionslist_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int actpan = 0; //création d'un code binaire comme pour chmod pour faire un switch après
            if (info1.Visible)
            {
                actpan += 1;
            }
            if (info2.Visible)
            {
                actpan += 2;
            }
            if (info3.Visible)
            {
                actpan += 4;
            }
            portf.AffichageActif(actpan, nbactions1, nbactions2, nbactions3, tree_actionslist, info1, info2, info3, nom1, prix1, nom2, prix2, nom3, prix3);
        }

     

        private void exit_info1_Click(object sender, EventArgs e)
        {
            info1.Hide();
        }

        private void exit_info2_Click(object sender, EventArgs e)
        {
            info2.Hide();
        }

        private void exit_info3_Click(object sender, EventArgs e)
        {
            info3.Hide();
        }

 

    }








    


    




}
