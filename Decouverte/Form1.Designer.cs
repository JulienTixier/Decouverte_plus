namespace Decouverte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nbactions = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.portefeuille = new System.Windows.Forms.ListBox();
            this.valportefeuillestr = new System.Windows.Forms.Label();
            this.repartactifs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tree_actionslist = new System.Windows.Forms.TreeView();
            this.info1 = new System.Windows.Forms.Panel();
            this.nom = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exit_info1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.repartactifs)).BeginInit();
            this.panel1.SuspendLayout();
            this.info1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nbactions
            // 
            this.nbactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nbactions.Location = new System.Drawing.Point(13, 75);
            this.nbactions.Name = "nbactions";
            this.nbactions.Size = new System.Drawing.Size(89, 20);
            this.nbactions.TabIndex = 2;
            this.nbactions.TextChanged += new System.EventHandler(this.nbactions_TextChanged);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Location = new System.Drawing.Point(124, 75);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 20);
            this.add.TabIndex = 3;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // portefeuille
            // 
            this.portefeuille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portefeuille.FormattingEnabled = true;
            this.portefeuille.Location = new System.Drawing.Point(402, 84);
            this.portefeuille.Name = "portefeuille";
            this.portefeuille.Size = new System.Drawing.Size(138, 160);
            this.portefeuille.TabIndex = 4;
            this.portefeuille.SelectedIndexChanged += new System.EventHandler(this.portefeuille_SelectedIndexChanged);
            // 
            // valportefeuillestr
            // 
            this.valportefeuillestr.AutoSize = true;
            this.valportefeuillestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valportefeuillestr.Location = new System.Drawing.Point(224, 9);
            this.valportefeuillestr.Name = "valportefeuillestr";
            this.valportefeuillestr.Size = new System.Drawing.Size(124, 42);
            this.valportefeuillestr.TabIndex = 5;
            this.valportefeuillestr.Text = "label1";
            this.valportefeuillestr.Click += new System.EventHandler(this.valportefeuillestr_Click);
            // 
            // repartactifs
            // 
            chartArea1.Name = "ChartArea1";
            this.repartactifs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.repartactifs.Legends.Add(legend1);
            this.repartactifs.Location = new System.Drawing.Point(179, 84);
            this.repartactifs.Margin = new System.Windows.Forms.Padding(2);
            this.repartactifs.Name = "repartactifs";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.repartactifs.Series.Add(series1);
            this.repartactifs.Size = new System.Drawing.Size(218, 167);
            this.repartactifs.TabIndex = 6;
            this.repartactifs.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.tree_actionslist);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 589);
            this.panel1.TabIndex = 7;
            // 
            // tree_actionslist
            // 
            this.tree_actionslist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree_actionslist.Location = new System.Drawing.Point(5, 3);
            this.tree_actionslist.Name = "tree_actionslist";
            this.tree_actionslist.Size = new System.Drawing.Size(121, 579);
            this.tree_actionslist.TabIndex = 0;
            this.tree_actionslist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_actionslist_AfterSelect);
            // 
            // info1
            // 
            this.info1.Controls.Add(this.exit_info1);
            this.info1.Controls.Add(this.nom);
            this.info1.Controls.Add(this.prix);
            this.info1.Controls.Add(this.chart1);
            this.info1.Controls.Add(this.nbactions);
            this.info1.Controls.Add(this.add);
            this.info1.Location = new System.Drawing.Point(546, 18);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(395, 288);
            this.info1.TabIndex = 8;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(7, 12);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(86, 31);
            this.nom.TabIndex = 2;
            this.nom.Text = "label1";
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Location = new System.Drawing.Point(150, 12);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(86, 31);
            this.prix.TabIndex = 1;
            this.prix.Text = "label1";
            this.prix.Click += new System.EventHandler(this.prix_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 101);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(282, 175);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // exit_info1
            // 
            this.exit_info1.Location = new System.Drawing.Point(371, 3);
            this.exit_info1.Name = "exit_info1";
            this.exit_info1.Size = new System.Drawing.Size(21, 19);
            this.exit_info1.TabIndex = 9;
            this.exit_info1.Text = "X";
            this.exit_info1.UseVisualStyleBackColor = true;
            this.exit_info1.Click += new System.EventHandler(this.exit_info1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 597);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.repartactifs);
            this.Controls.Add(this.valportefeuillestr);
            this.Controls.Add(this.portefeuille);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repartactifs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.info1.ResumeLayout(false);
            this.info1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nbactions;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox portefeuille;
        private System.Windows.Forms.Label valportefeuillestr;
        private System.Windows.Forms.DataVisualization.Charting.Chart repartactifs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tree_actionslist;
        private System.Windows.Forms.Panel info1;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button exit_info1;
    }
}

