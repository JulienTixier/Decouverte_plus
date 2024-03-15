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
namespace Decouverte
{



    public partial class Form1 : Form
    {

      
        
        
        
        
        public Form1()
        {
            InitializeComponent();
            valportefeuillestr.Text = "0€";
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

            

        }

        public static List<Actions> actions = new List<Actions>();
        public Actions Thales = new Actions("Thales", /*134*/10);
        public Actions Schneider = new Actions("Schneider", /*195*/10);
        public Actions Vinci = new Actions("Vinci", /*116*/10);
        public Actions LVMH = new Actions("LVMH", /*822*/10);
        public Actions TotalEnergies = new Actions("TotalEnergies", /*60*/10);
        public Actions Sanofi = new Actions("Sanofi", /*86*/10);
        public Portefeuille portf = new Portefeuille(0, actions);

        private void Form1_Load(object sender, EventArgs e)
        {
         

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
            int nb_actions = Convert.ToInt32(strnombres_actions);
            string nom_actions = "";
            for (int i = 0; i < tree_actionslist.Nodes.Count; i++)
            {
                for (int j =0; j < tree_actionslist.Nodes[i].Nodes.Count; j++)
                
                if (tree_actionslist.Nodes[i].Nodes[j].IsSelected == true)
                {
                        nom_actions = tree_actionslist.Nodes[i].Nodes[j].Text.ToString();
                }
            }
            
            portf.total = 0;
            for (int i =0;i < portf.actions.Count; i++)
            {
                if(nom_actions == portf.actions[i].name)
                {
                    if (portf.nbactions[i] == 0)
                    {
                        portf.nbactions[i] += nb_actions;
                        portefeuille.Items.Add(portf.nbactions[i] + " " + portf.actions[i].name);
                    }
                    else
                    {
                        portefeuille.Items.Remove(portf.nbactions[i] + " " + portf.actions[i].name);
                        portf.nbactions[i] += nb_actions;
                        portefeuille.Items.Add(portf.nbactions[i] + " " + portf.actions[i].name);

                    }

                }
                portf.total += portf.actions[i].price * portf.nbactions[i];
            }
            valportefeuillestr.Text = portf.total.ToString() + "€";
            portf.Updatepercactions();
            portf.Charmaker(repartactifs);




        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void portefeuille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tree_actionslist_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void tree_actionslist_NodeClick(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("Waouh t'as double click sur une action maitenant il faut ouvrir un bloc avec toutes les informations");
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
        public double total;
        public List<int> nbactions;
        public List<Actions> actions;
        public List<double> percactions;

        public Portefeuille(float tot,List<Actions> acts)
        {
            total = tot;
            actions = acts;
        }

        public void UpdateConstr()
        {
            nbactions = new List<int>(actions.Count);
            percactions = new List<double>(actions.Count);
            for (int i = 0; i < actions.Count; i++)
            {
                nbactions.Add(0);
                percactions.Add(0);
            }
            
            



        }

        public void Updatepercactions()
        {
            for(int i = 0; i < actions.Count; i++)
            {
                percactions[i] = (nbactions[i] * actions[i].price) / total * 100;
                //Console.WriteLine(actions[i].name + ": " + percactions[i] + "%");
            }
        }


        public  void Charmaker(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            
            chart.Series["Series1"].Points.Clear();
            for(int i =0; i < actions.Count;i++)
            {
                
                if (percactions[i] != 0)
                {
                    chart.Series["Series1"].Points.AddY(percactions[i].ToString());
                    chart.Series["Series1"].Points[chart.Series["Series1"].Points.Count()-1].Label = actions[i].name;
                }
            }
        
        
        
        }

        

        
    }




}
