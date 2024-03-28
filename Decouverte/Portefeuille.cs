using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Decouverte
{
    public class Portefeuille
    {
        public double total;
        public double versements;
        public double benefices;
        public List<int> nbactions;
        public List<Actions> actions;
        public List<double> percactions;

        public Portefeuille(List<Actions> acts, double tot = 0)
        {
            versements = tot;
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

        public void Addactions(Label nomactif, int inputnbactif,ListBox nb_actifs_portf, ListBox portefeuille, ListBox portefeuille_prix, Label labtot, Label labvers, Label labbenef, Chart camembert)
        {

            for (int i = 0; i < actions.Count; i++)
            {
                if (nomactif.Text == actions[i].name)
                {
                    if (nbactions[i] == 0)
                    {
                        nbactions[i] += inputnbactif;
                        portefeuille.Items.Add(actions[i].name);
                        portefeuille_prix.Items.Add(actions[i].price * nbactions[i] + "€");
                        nb_actifs_portf.Items.Add(nbactions[i]);
                    }
                    else
                    {
                        portefeuille.Items.Remove(actions[i].name);
                        portefeuille_prix.Items.Remove(actions[i].price * nbactions[i] + "€");
                        nb_actifs_portf.Items.Remove(nbactions[i]);
                        nbactions[i] += inputnbactif;
                        portefeuille.Items.Add(actions[i].name);
                        portefeuille_prix.Items.Add(actions[i].price * nbactions[i] + "€");
                        nb_actifs_portf.Items.Add(nbactions[i]);

                    }
                    versements += inputnbactif * actions[i].price;
                }

            }
            Updateactifs(portefeuille,portefeuille_prix);
            labtot.Text = total.ToString() + "€";
            labvers.Text = versements.ToString() + "€";
            labbenef.Text = benefices.ToString() + "€";
            Charmaker(camembert);
            if (benefices >= 0)
            {
                labbenef.ForeColor = Color.ForestGreen;
            }
            else
            {
                labbenef.ForeColor = Color.DarkRed;
            }
        }

        public void Updateactifs(ListBox actif, ListBox prix)
        {
            total = 0;
            benefices = 0;
            for (int i = 0; i < actions.Count; i++)
            {
                total += nbactions[i] * actions[i].price;
                
            }
            for (int j = 0; j < actions.Count; j++)
            {
                percactions[j] = (nbactions[j] * actions[j].price) / total * 100;
                
            }
            benefices = total - versements;
            
        }


        public void Charmaker(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {

            chart.Series["Series1"].Points.Clear();
            for (int i = 0; i < actions.Count; i++)
            {

                if (percactions[i] != 0)
                {
                    chart.Series["Series1"].Points.AddY(percactions[i]);
                    chart.Series["Series1"].Points[chart.Series["Series1"].Points.Count() - 1].Label = actions[i].name;
                }
            }
 
        }

        public void AffichageActif(int val,TextBox textbox1, TextBox textbox2, TextBox textbox3, TreeView listactifs,Panel panel1,Panel panel2,Panel panel3,Label nom1,Label prix1,Label nom2,Label prix2,Label nom3,Label prix3)
        {
            switch (val)
            {
                case 0:
                    textbox1.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel1.Show();
                                nom1.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom1.Text == actions[i].name)
                        {
                            prix1.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                case 1:
                    textbox2.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel2.Show();
                                nom2.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom2.Text == actions[i].name)
                        {
                            prix2.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                case 2:
                    textbox1.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel1.Show();
                                nom1.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom1.Text == actions[i].name)
                        {
                            prix1.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                case 3:
                    textbox3.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel3.Show();
                                nom3.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom3.Text == actions[i].name)
                        {
                            prix3.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                case 4:
                    textbox1.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel1.Show();
                                nom1.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom1.Text == actions[i].name)
                        {
                            prix1.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                case 5:
                    textbox2.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel2.Show();
                                nom2.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom2.Text == actions[i].name)
                        {
                            prix2.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                case 6:
                    textbox1.Clear();
                    for (int i = 0; i < listactifs.Nodes.Count; i++)
                    {
                        for (int j = 0; j < listactifs.Nodes[i].Nodes.Count; j++)
                        {

                            if (listactifs.Nodes[i].Nodes[j].IsSelected == true)
                            {
                                panel1.Show();
                                nom1.Text = listactifs.Nodes[i].Nodes[j].Text.ToString();
                            }
                        }
                    }
                    for (int i = 0; i < actions.Count; i++)
                    {
                        if (nom1.Text == actions[i].name)
                        {
                            prix1.Text = actions[i].price.ToString() + "€";
                        }
                    }
                    break;

                default: break;
            }
        }
    }
}
