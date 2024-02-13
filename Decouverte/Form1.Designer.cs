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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionslist = new System.Windows.Forms.ListBox();
            this.nbactions = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.portefeuille = new System.Windows.Forms.ListBox();
            this.valportefeuille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // actionslist
            // 
            this.actionslist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionslist.FormattingEnabled = true;
            this.actionslist.Location = new System.Drawing.Point(12, 38);
            this.actionslist.Name = "actionslist";
            this.actionslist.Size = new System.Drawing.Size(115, 121);
            this.actionslist.TabIndex = 1;
            this.actionslist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nbactions
            // 
            this.nbactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nbactions.Location = new System.Drawing.Point(12, 7);
            this.nbactions.Name = "nbactions";
            this.nbactions.Size = new System.Drawing.Size(115, 20);
            this.nbactions.TabIndex = 2;
            this.nbactions.TextChanged += new System.EventHandler(this.nbactions_TextChanged);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Location = new System.Drawing.Point(141, 7);
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
            this.portefeuille.Location = new System.Drawing.Point(213, 38);
            this.portefeuille.Name = "portefeuille";
            this.portefeuille.Size = new System.Drawing.Size(179, 121);
            this.portefeuille.TabIndex = 4;
            this.portefeuille.SelectedIndexChanged += new System.EventHandler(this.portefeuille_SelectedIndexChanged);
            // 
            // valportefeuille
            // 
            this.valportefeuille.AutoSize = true;
            this.valportefeuille.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valportefeuille.Location = new System.Drawing.Point(458, 38);
            this.valportefeuille.Name = "valportefeuille";
            this.valportefeuille.Size = new System.Drawing.Size(124, 42);
            this.valportefeuille.TabIndex = 5;
            this.valportefeuille.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 597);
            this.Controls.Add(this.valportefeuille);
            this.Controls.Add(this.portefeuille);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nbactions);
            this.Controls.Add(this.actionslist);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox actionslist;
        private System.Windows.Forms.TextBox nbactions;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox portefeuille;
        private System.Windows.Forms.Label valportefeuille;
    }
}

