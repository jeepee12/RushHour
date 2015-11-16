namespace RushHour
{
    partial class FormRushHour
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
            this.tlpRushHour = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.difficultéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débutantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermédiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAutoEnCours = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutoEnCours)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRushHour
            // 
            this.tlpRushHour.ColumnCount = 8;
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.Location = new System.Drawing.Point(12, 46);
            this.tlpRushHour.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRushHour.Name = "tlpRushHour";
            this.tlpRushHour.RowCount = 8;
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpRushHour.Size = new System.Drawing.Size(352, 352);
            this.tlpRushHour.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // difficultéToolStripMenuItem
            // 
            this.difficultéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.débutantToolStripMenuItem,
            this.intermédiaireToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.difficultéToolStripMenuItem.Name = "difficultéToolStripMenuItem";
            this.difficultéToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.difficultéToolStripMenuItem.Text = "Difficulté";
            // 
            // débutantToolStripMenuItem
            // 
            this.débutantToolStripMenuItem.Name = "débutantToolStripMenuItem";
            this.débutantToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.débutantToolStripMenuItem.Text = "Débutant";
            this.débutantToolStripMenuItem.Click += new System.EventHandler(this.débutantToolStripMenuItem_Click);
            // 
            // intermédiaireToolStripMenuItem
            // 
            this.intermédiaireToolStripMenuItem.Name = "intermédiaireToolStripMenuItem";
            this.intermédiaireToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intermédiaireToolStripMenuItem.Text = "Intermédiaire";
            this.intermédiaireToolStripMenuItem.Click += new System.EventHandler(this.intermédiaireToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(290, 441);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliquer sur le carré le plus a gauche ou en haut de l\'auto pour la déplacer.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auto selectionné :";
            // 
            // pbAutoEnCours
            // 
            this.pbAutoEnCours.Location = new System.Drawing.Point(107, 441);
            this.pbAutoEnCours.Margin = new System.Windows.Forms.Padding(0);
            this.pbAutoEnCours.Name = "pbAutoEnCours";
            this.pbAutoEnCours.Size = new System.Drawing.Size(33, 33);
            this.pbAutoEnCours.TabIndex = 5;
            this.pbAutoEnCours.TabStop = false;
            // 
            // FormRushHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 476);
            this.Controls.Add(this.pbAutoEnCours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.tlpRushHour);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRushHour";
            this.Text = "Rush Hour";
            this.Load += new System.EventHandler(this.FormRushHour_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutoEnCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRushHour;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem difficultéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débutantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermédiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAutoEnCours;
    }
}

