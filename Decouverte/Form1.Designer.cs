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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionslist = new System.Windows.Forms.ListBox();
            this.nbactions = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.portefeuille = new System.Windows.Forms.ListBox();
            this.valportefeuillestr = new System.Windows.Forms.Label();
            this.repartactifs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.repartactifs)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // actionslist
            // 
            this.actionslist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionslist.FormattingEnabled = true;
            this.actionslist.ItemHeight = 16;
            this.actionslist.Location = new System.Drawing.Point(16, 47);
            this.actionslist.Margin = new System.Windows.Forms.Padding(4);
            this.actionslist.Name = "actionslist";
            this.actionslist.Size = new System.Drawing.Size(152, 148);
            this.actionslist.TabIndex = 1;
            this.actionslist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nbactions
            // 
            this.nbactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nbactions.Location = new System.Drawing.Point(16, 9);
            this.nbactions.Margin = new System.Windows.Forms.Padding(4);
            this.nbactions.Name = "nbactions";
            this.nbactions.Size = new System.Drawing.Size(152, 22);
            this.nbactions.TabIndex = 2;
            this.nbactions.TextChanged += new System.EventHandler(this.nbactions_TextChanged);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Location = new System.Drawing.Point(188, 9);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 25);
            this.add.TabIndex = 3;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // portefeuille
            // 
            this.portefeuille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portefeuille.FormattingEnabled = true;
            this.portefeuille.ItemHeight = 16;
            this.portefeuille.Location = new System.Drawing.Point(284, 47);
            this.portefeuille.Margin = new System.Windows.Forms.Padding(4);
            this.portefeuille.Name = "portefeuille";
            this.portefeuille.Size = new System.Drawing.Size(237, 148);
            this.portefeuille.TabIndex = 4;
            this.portefeuille.SelectedIndexChanged += new System.EventHandler(this.portefeuille_SelectedIndexChanged);
            // 
            // valportefeuillestr
            // 
            this.valportefeuillestr.AutoSize = true;
            this.valportefeuillestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valportefeuillestr.Location = new System.Drawing.Point(611, 47);
            this.valportefeuillestr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valportefeuillestr.Name = "valportefeuillestr";
            this.valportefeuillestr.Size = new System.Drawing.Size(153, 54);
            this.valportefeuillestr.TabIndex = 5;
            this.valportefeuillestr.Text = "label1";
            // 
            // repartactifs
            // 
            this.repartactifs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.repartactifs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.repartactifs.Legends.Add(legend1);
            this.repartactifs.Location = new System.Drawing.Point(553, 104);
            this.repartactifs.Margin = new System.Windows.Forms.Padding(2);
            this.repartactifs.Name = "repartactifs";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.repartactifs.Series.Add(series1);
            this.repartactifs.Size = new System.Drawing.Size(291, 206);
            this.repartactifs.TabIndex = 6;
            this.repartactifs.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 735);
            this.Controls.Add(this.repartactifs);
            this.Controls.Add(this.valportefeuillestr);
            this.Controls.Add(this.portefeuille);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nbactions);
            this.Controls.Add(this.actionslist);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repartactifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox actionslist;
        private System.Windows.Forms.TextBox nbactions;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox portefeuille;
        private System.Windows.Forms.Label valportefeuillestr;
        private System.Windows.Forms.DataVisualization.Charting.Chart repartactifs;
    }
}

