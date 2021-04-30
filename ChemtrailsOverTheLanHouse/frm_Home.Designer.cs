namespace ChemtrailsOverTheLanHouse
{
    partial class frm_Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Computador = new System.Windows.Forms.Button();
            this.bt_Notebook = new System.Windows.Forms.Button();
            this.bt_EasterEgg = new System.Windows.Forms.Button();
            this.lbl_AlugaTexto = new System.Windows.Forms.Label();
            this.lb_HomeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Computador
            // 
            this.bt_Computador.Font = new System.Drawing.Font("Pristina", 12F);
            this.bt_Computador.Location = new System.Drawing.Point(387, 484);
            this.bt_Computador.Name = "bt_Computador";
            this.bt_Computador.Size = new System.Drawing.Size(130, 33);
            this.bt_Computador.TabIndex = 1;
            this.bt_Computador.Text = "Computador";
            this.bt_Computador.UseVisualStyleBackColor = true;
            this.bt_Computador.Click += new System.EventHandler(this.bt_Computador_Click);
            // 
            // bt_Notebook
            // 
            this.bt_Notebook.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Notebook.Location = new System.Drawing.Point(604, 484);
            this.bt_Notebook.Name = "bt_Notebook";
            this.bt_Notebook.Size = new System.Drawing.Size(126, 33);
            this.bt_Notebook.TabIndex = 2;
            this.bt_Notebook.Text = "Notebook";
            this.bt_Notebook.UseVisualStyleBackColor = true;
            this.bt_Notebook.Click += new System.EventHandler(this.bt_Notebook_Click);
            // 
            // bt_EasterEgg
            // 
            this.bt_EasterEgg.Font = new System.Drawing.Font("Pristina", 16F);
            this.bt_EasterEgg.Location = new System.Drawing.Point(12, 46);
            this.bt_EasterEgg.Name = "bt_EasterEgg";
            this.bt_EasterEgg.Size = new System.Drawing.Size(75, 33);
            this.bt_EasterEgg.TabIndex = 3;
            this.bt_EasterEgg.Text = "?";
            this.bt_EasterEgg.UseVisualStyleBackColor = true;
            this.bt_EasterEgg.Click += new System.EventHandler(this.bt_EasterEgg_Click);
            // 
            // lbl_AlugaTexto
            // 
            this.lbl_AlugaTexto.AutoSize = true;
            this.lbl_AlugaTexto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AlugaTexto.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlugaTexto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AlugaTexto.Location = new System.Drawing.Point(468, 452);
            this.lbl_AlugaTexto.Name = "lbl_AlugaTexto";
            this.lbl_AlugaTexto.Size = new System.Drawing.Size(182, 29);
            this.lbl_AlugaTexto.TabIndex = 7;
            this.lbl_AlugaTexto.Text = "O que você deseja alugar?";
            // 
            // lb_HomeName
            // 
            this.lb_HomeName.AutoSize = true;
            this.lb_HomeName.Font = new System.Drawing.Font("Viner Hand ITC", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HomeName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_HomeName.Location = new System.Drawing.Point(139, 32);
            this.lb_HomeName.Name = "lb_HomeName";
            this.lb_HomeName.Size = new System.Drawing.Size(882, 57);
            this.lb_HomeName.TabIndex = 8;
            this.lb_HomeName.Text = "Seja bem-vindo(a) à Chemtrails Over the Lan House.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(311, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "A primeira e a melhor lan house delivery.";
            // 
            // ms_Menu
            // 
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(1167, 24);
            this.ms_Menu.TabIndex = 11;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_HomeName);
            this.Controls.Add(this.lbl_AlugaTexto);
            this.Controls.Add(this.bt_EasterEgg);
            this.Controls.Add(this.bt_Notebook);
            this.Controls.Add(this.bt_Computador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ms_Menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "frm_Home";
            this.Text = "Chemtrails Over the Lan House";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Computador;
        private System.Windows.Forms.Button bt_Notebook;
        private System.Windows.Forms.Button bt_EasterEgg;
        private System.Windows.Forms.Label lbl_AlugaTexto;
        private System.Windows.Forms.Label lb_HomeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

