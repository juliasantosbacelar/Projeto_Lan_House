namespace ChemtrailsOverTheLanHouse
{
    partial class frm_NotebookOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NotebookOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CPFPagBoleto = new System.Windows.Forms.TextBox();
            this.tb_NomePagBoleto = new System.Windows.Forms.TextBox();
            this.lb_NomePag = new System.Windows.Forms.Label();
            this.lb_CPFPag = new System.Windows.Forms.Label();
            this.gb_Pag = new System.Windows.Forms.GroupBox();
            this.rb_Card = new System.Windows.Forms.RadioButton();
            this.rb_Boleto = new System.Windows.Forms.RadioButton();
            this.gp_PCType = new System.Windows.Forms.GroupBox();
            this.rb_HighNB = new System.Windows.Forms.RadioButton();
            this.rb_MedNB = new System.Windows.Forms.RadioButton();
            this.rb_EntryNB = new System.Windows.Forms.RadioButton();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_CPFPagCard = new System.Windows.Forms.TextBox();
            this.tb_NomePagCard = new System.Windows.Forms.TextBox();
            this.lb_NamePagCard = new System.Windows.Forms.Label();
            this.lb_CPFPagCard = new System.Windows.Forms.Label();
            this.tb_CVV = new System.Windows.Forms.TextBox();
            this.tb_CardNumber = new System.Windows.Forms.TextBox();
            this.lb_CVV = new System.Windows.Forms.Label();
            this.lb_CardNumber = new System.Windows.Forms.Label();
            this.btn_SendBoleto = new System.Windows.Forms.Button();
            this.btn_SendCard = new System.Windows.Forms.Button();
            this.lb_qtDaysBol = new System.Windows.Forms.Label();
            this.lb_qtDays = new System.Windows.Forms.Label();
            this.num_QtdDaysCard = new System.Windows.Forms.NumericUpDown();
            this.num_QtdDaysBol = new System.Windows.Forms.NumericUpDown();
            this.num_Parc = new System.Windows.Forms.NumericUpDown();
            this.lb_Parc = new System.Windows.Forms.Label();
            this.gb_Pag.SuspendLayout();
            this.gp_PCType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_QtdDaysCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QtdDaysBol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Parc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tb_CPFPagBoleto
            // 
            this.tb_CPFPagBoleto.Location = new System.Drawing.Point(593, 48);
            this.tb_CPFPagBoleto.Name = "tb_CPFPagBoleto";
            this.tb_CPFPagBoleto.Size = new System.Drawing.Size(134, 20);
            this.tb_CPFPagBoleto.TabIndex = 21;
            this.tb_CPFPagBoleto.Visible = false;
            // 
            // tb_NomePagBoleto
            // 
            this.tb_NomePagBoleto.Location = new System.Drawing.Point(593, 22);
            this.tb_NomePagBoleto.Name = "tb_NomePagBoleto";
            this.tb_NomePagBoleto.Size = new System.Drawing.Size(134, 20);
            this.tb_NomePagBoleto.TabIndex = 20;
            this.tb_NomePagBoleto.Visible = false;
            // 
            // lb_NomePag
            // 
            this.lb_NomePag.AutoSize = true;
            this.lb_NomePag.BackColor = System.Drawing.Color.Transparent;
            this.lb_NomePag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomePag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NomePag.Location = new System.Drawing.Point(433, 20);
            this.lb_NomePag.Name = "lb_NomePag";
            this.lb_NomePag.Size = new System.Drawing.Size(55, 20);
            this.lb_NomePag.TabIndex = 19;
            this.lb_NomePag.Text = "Nome:";
            this.lb_NomePag.Visible = false;
            // 
            // lb_CPFPag
            // 
            this.lb_CPFPag.AutoSize = true;
            this.lb_CPFPag.BackColor = System.Drawing.Color.Transparent;
            this.lb_CPFPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CPFPag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_CPFPag.Location = new System.Drawing.Point(433, 46);
            this.lb_CPFPag.Name = "lb_CPFPag";
            this.lb_CPFPag.Size = new System.Drawing.Size(44, 20);
            this.lb_CPFPag.TabIndex = 18;
            this.lb_CPFPag.Text = "CPF:";
            this.lb_CPFPag.Visible = false;
            // 
            // gb_Pag
            // 
            this.gb_Pag.BackColor = System.Drawing.Color.Transparent;
            this.gb_Pag.Controls.Add(this.rb_Card);
            this.gb_Pag.Controls.Add(this.rb_Boleto);
            this.gb_Pag.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_Pag.Location = new System.Drawing.Point(24, 135);
            this.gb_Pag.Name = "gb_Pag";
            this.gb_Pag.Size = new System.Drawing.Size(148, 66);
            this.gb_Pag.TabIndex = 17;
            this.gb_Pag.TabStop = false;
            this.gb_Pag.Text = "Forma de Pagamento";
            // 
            // rb_Card
            // 
            this.rb_Card.AutoSize = true;
            this.rb_Card.Location = new System.Drawing.Point(7, 43);
            this.rb_Card.Name = "rb_Card";
            this.rb_Card.Size = new System.Drawing.Size(107, 17);
            this.rb_Card.TabIndex = 1;
            this.rb_Card.Text = "Cartão de Crédito";
            this.rb_Card.UseVisualStyleBackColor = true;
            this.rb_Card.CheckedChanged += new System.EventHandler(this.rb_Card_CheckedChanged_1);
            // 
            // rb_Boleto
            // 
            this.rb_Boleto.AutoSize = true;
            this.rb_Boleto.Location = new System.Drawing.Point(7, 20);
            this.rb_Boleto.Name = "rb_Boleto";
            this.rb_Boleto.Size = new System.Drawing.Size(55, 17);
            this.rb_Boleto.TabIndex = 0;
            this.rb_Boleto.Text = "Boleto";
            this.rb_Boleto.UseVisualStyleBackColor = true;
            this.rb_Boleto.CheckedChanged += new System.EventHandler(this.rb_Boleto_CheckedChanged_1);
            // 
            // gp_PCType
            // 
            this.gp_PCType.BackColor = System.Drawing.Color.Transparent;
            this.gp_PCType.Controls.Add(this.rb_HighNB);
            this.gp_PCType.Controls.Add(this.rb_MedNB);
            this.gp_PCType.Controls.Add(this.rb_EntryNB);
            this.gp_PCType.ForeColor = System.Drawing.SystemColors.Control;
            this.gp_PCType.Location = new System.Drawing.Point(24, 207);
            this.gp_PCType.Name = "gp_PCType";
            this.gp_PCType.Size = new System.Drawing.Size(206, 89);
            this.gp_PCType.TabIndex = 16;
            this.gp_PCType.TabStop = false;
            this.gp_PCType.Text = "Tipo de Computador";
            // 
            // rb_HighNB
            // 
            this.rb_HighNB.AutoSize = true;
            this.rb_HighNB.Location = new System.Drawing.Point(6, 63);
            this.rb_HighNB.Name = "rb_HighNB";
            this.rb_HighNB.Size = new System.Drawing.Size(147, 17);
            this.rb_HighNB.TabIndex = 5;
            this.rb_HighNB.TabStop = true;
            this.rb_HighNB.Text = "Entusiasta - R$100 ao dia";
            this.rb_HighNB.UseVisualStyleBackColor = true;
            // 
            // rb_MedNB
            // 
            this.rb_MedNB.AutoSize = true;
            this.rb_MedNB.Location = new System.Drawing.Point(6, 40);
            this.rb_MedNB.Name = "rb_MedNB";
            this.rb_MedNB.Size = new System.Drawing.Size(152, 17);
            this.rb_MedNB.TabIndex = 3;
            this.rb_MedNB.TabStop = true;
            this.rb_MedNB.Text = "Intermediário - R$90 ao dia";
            this.rb_MedNB.UseVisualStyleBackColor = true;
            // 
            // rb_EntryNB
            // 
            this.rb_EntryNB.AutoSize = true;
            this.rb_EntryNB.Location = new System.Drawing.Point(6, 19);
            this.rb_EntryNB.Name = "rb_EntryNB";
            this.rb_EntryNB.Size = new System.Drawing.Size(129, 17);
            this.rb_EntryNB.TabIndex = 2;
            this.rb_EntryNB.TabStop = true;
            this.rb_EntryNB.Text = "Entrada - R$80 ao dia";
            this.rb_EntryNB.UseVisualStyleBackColor = true;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(111, 46);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(193, 20);
            this.tb_Phone.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefone:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(111, 20);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(193, 20);
            this.tb_Name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Endereço:";
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(111, 72);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(193, 20);
            this.tb_Address.TabIndex = 23;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(111, 98);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(193, 20);
            this.tb_Email.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-mail:";
            // 
            // tb_CPFPagCard
            // 
            this.tb_CPFPagCard.Location = new System.Drawing.Point(593, 180);
            this.tb_CPFPagCard.Name = "tb_CPFPagCard";
            this.tb_CPFPagCard.Size = new System.Drawing.Size(134, 20);
            this.tb_CPFPagCard.TabIndex = 29;
            this.tb_CPFPagCard.Visible = false;
            // 
            // tb_NomePagCard
            // 
            this.tb_NomePagCard.Location = new System.Drawing.Point(593, 152);
            this.tb_NomePagCard.Name = "tb_NomePagCard";
            this.tb_NomePagCard.Size = new System.Drawing.Size(134, 20);
            this.tb_NomePagCard.TabIndex = 28;
            this.tb_NomePagCard.Visible = false;
            // 
            // lb_NamePagCard
            // 
            this.lb_NamePagCard.AutoSize = true;
            this.lb_NamePagCard.BackColor = System.Drawing.Color.Transparent;
            this.lb_NamePagCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePagCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePagCard.Location = new System.Drawing.Point(433, 155);
            this.lb_NamePagCard.Name = "lb_NamePagCard";
            this.lb_NamePagCard.Size = new System.Drawing.Size(55, 20);
            this.lb_NamePagCard.TabIndex = 27;
            this.lb_NamePagCard.Text = "Nome:";
            this.lb_NamePagCard.Visible = false;
            // 
            // lb_CPFPagCard
            // 
            this.lb_CPFPagCard.AutoSize = true;
            this.lb_CPFPagCard.BackColor = System.Drawing.Color.Transparent;
            this.lb_CPFPagCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CPFPagCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_CPFPagCard.Location = new System.Drawing.Point(433, 180);
            this.lb_CPFPagCard.Name = "lb_CPFPagCard";
            this.lb_CPFPagCard.Size = new System.Drawing.Size(44, 20);
            this.lb_CPFPagCard.TabIndex = 26;
            this.lb_CPFPagCard.Text = "CPF:";
            this.lb_CPFPagCard.Visible = false;
            // 
            // tb_CVV
            // 
            this.tb_CVV.Location = new System.Drawing.Point(593, 206);
            this.tb_CVV.Name = "tb_CVV";
            this.tb_CVV.Size = new System.Drawing.Size(134, 20);
            this.tb_CVV.TabIndex = 30;
            this.tb_CVV.Visible = false;
            // 
            // tb_CardNumber
            // 
            this.tb_CardNumber.Location = new System.Drawing.Point(593, 232);
            this.tb_CardNumber.Name = "tb_CardNumber";
            this.tb_CardNumber.Size = new System.Drawing.Size(134, 20);
            this.tb_CardNumber.TabIndex = 31;
            this.tb_CardNumber.Visible = false;
            // 
            // lb_CVV
            // 
            this.lb_CVV.AutoSize = true;
            this.lb_CVV.BackColor = System.Drawing.Color.Transparent;
            this.lb_CVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CVV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_CVV.Location = new System.Drawing.Point(433, 207);
            this.lb_CVV.Name = "lb_CVV";
            this.lb_CVV.Size = new System.Drawing.Size(46, 20);
            this.lb_CVV.TabIndex = 32;
            this.lb_CVV.Text = "CVV:";
            this.lb_CVV.Visible = false;
            // 
            // lb_CardNumber
            // 
            this.lb_CardNumber.AutoSize = true;
            this.lb_CardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CardNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_CardNumber.Location = new System.Drawing.Point(433, 232);
            this.lb_CardNumber.Name = "lb_CardNumber";
            this.lb_CardNumber.Size = new System.Drawing.Size(143, 20);
            this.lb_CardNumber.TabIndex = 33;
            this.lb_CardNumber.Text = "Número do Cartão:";
            this.lb_CardNumber.Visible = false;
            // 
            // btn_SendBoleto
            // 
            this.btn_SendBoleto.Location = new System.Drawing.Point(620, 99);
            this.btn_SendBoleto.Name = "btn_SendBoleto";
            this.btn_SendBoleto.Size = new System.Drawing.Size(75, 23);
            this.btn_SendBoleto.TabIndex = 34;
            this.btn_SendBoleto.Text = "Enviar!";
            this.btn_SendBoleto.UseVisualStyleBackColor = true;
            this.btn_SendBoleto.Visible = false;
            this.btn_SendBoleto.Click += new System.EventHandler(this.btn_SendBoleto_Click);
            // 
            // btn_SendCard
            // 
            this.btn_SendCard.Location = new System.Drawing.Point(620, 322);
            this.btn_SendCard.Name = "btn_SendCard";
            this.btn_SendCard.Size = new System.Drawing.Size(75, 23);
            this.btn_SendCard.TabIndex = 35;
            this.btn_SendCard.Text = "Enviar!";
            this.btn_SendCard.UseVisualStyleBackColor = true;
            this.btn_SendCard.Visible = false;
            this.btn_SendCard.Click += new System.EventHandler(this.btn_SendCard_Click);
            // 
            // lb_qtDaysBol
            // 
            this.lb_qtDaysBol.AutoSize = true;
            this.lb_qtDaysBol.BackColor = System.Drawing.Color.Transparent;
            this.lb_qtDaysBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtDaysBol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_qtDaysBol.Location = new System.Drawing.Point(433, 74);
            this.lb_qtDaysBol.Name = "lb_qtDaysBol";
            this.lb_qtDaysBol.Size = new System.Drawing.Size(154, 20);
            this.lb_qtDaysBol.TabIndex = 37;
            this.lb_qtDaysBol.Text = "Quantidade de Dias:";
            this.lb_qtDaysBol.Visible = false;
            // 
            // lb_qtDays
            // 
            this.lb_qtDays.AutoSize = true;
            this.lb_qtDays.BackColor = System.Drawing.Color.Transparent;
            this.lb_qtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtDays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_qtDays.Location = new System.Drawing.Point(433, 258);
            this.lb_qtDays.Name = "lb_qtDays";
            this.lb_qtDays.Size = new System.Drawing.Size(154, 20);
            this.lb_qtDays.TabIndex = 38;
            this.lb_qtDays.Text = "Quantidade de Dias:";
            this.lb_qtDays.Visible = false;
            // 
            // num_QtdDaysCard
            // 
            this.num_QtdDaysCard.Location = new System.Drawing.Point(593, 258);
            this.num_QtdDaysCard.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_QtdDaysCard.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_QtdDaysCard.Name = "num_QtdDaysCard";
            this.num_QtdDaysCard.Size = new System.Drawing.Size(134, 20);
            this.num_QtdDaysCard.TabIndex = 41;
            this.num_QtdDaysCard.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_QtdDaysCard.Visible = false;
            // 
            // num_QtdDaysBol
            // 
            this.num_QtdDaysBol.Location = new System.Drawing.Point(593, 73);
            this.num_QtdDaysBol.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_QtdDaysBol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_QtdDaysBol.Name = "num_QtdDaysBol";
            this.num_QtdDaysBol.Size = new System.Drawing.Size(134, 20);
            this.num_QtdDaysBol.TabIndex = 42;
            this.num_QtdDaysBol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_QtdDaysBol.Visible = false;
            // 
            // num_Parc
            // 
            this.num_Parc.Location = new System.Drawing.Point(593, 284);
            this.num_Parc.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_Parc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Parc.Name = "num_Parc";
            this.num_Parc.Size = new System.Drawing.Size(134, 20);
            this.num_Parc.TabIndex = 43;
            this.num_Parc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Parc.Visible = false;
            // 
            // lb_Parc
            // 
            this.lb_Parc.AutoSize = true;
            this.lb_Parc.BackColor = System.Drawing.Color.Transparent;
            this.lb_Parc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Parc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Parc.Location = new System.Drawing.Point(433, 284);
            this.lb_Parc.Name = "lb_Parc";
            this.lb_Parc.Size = new System.Drawing.Size(115, 20);
            this.lb_Parc.TabIndex = 44;
            this.lb_Parc.Text = "Parcelamento: ";
            this.lb_Parc.Visible = false;
            // 
            // frm_NotebookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Parc);
            this.Controls.Add(this.num_Parc);
            this.Controls.Add(this.num_QtdDaysBol);
            this.Controls.Add(this.num_QtdDaysCard);
            this.Controls.Add(this.lb_qtDays);
            this.Controls.Add(this.lb_qtDaysBol);
            this.Controls.Add(this.btn_SendCard);
            this.Controls.Add(this.btn_SendBoleto);
            this.Controls.Add(this.lb_CardNumber);
            this.Controls.Add(this.lb_CVV);
            this.Controls.Add(this.tb_CardNumber);
            this.Controls.Add(this.tb_CVV);
            this.Controls.Add(this.tb_CPFPagCard);
            this.Controls.Add(this.tb_NomePagCard);
            this.Controls.Add(this.lb_NamePagCard);
            this.Controls.Add(this.lb_CPFPagCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_CPFPagBoleto);
            this.Controls.Add(this.tb_NomePagBoleto);
            this.Controls.Add(this.lb_NomePag);
            this.Controls.Add(this.lb_CPFPag);
            this.Controls.Add(this.gb_Pag);
            this.Controls.Add(this.gp_PCType);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NotebookOrder";
            this.Text = "Pedido do Notebook";
            this.gb_Pag.ResumeLayout(false);
            this.gb_Pag.PerformLayout();
            this.gp_PCType.ResumeLayout(false);
            this.gp_PCType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_QtdDaysCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QtdDaysBol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Parc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CPFPagBoleto;
        private System.Windows.Forms.TextBox tb_NomePagBoleto;
        private System.Windows.Forms.Label lb_NomePag;
        private System.Windows.Forms.Label lb_CPFPag;
        private System.Windows.Forms.GroupBox gb_Pag;
        private System.Windows.Forms.RadioButton rb_Card;
        private System.Windows.Forms.RadioButton rb_Boleto;
        public System.Windows.Forms.GroupBox gp_PCType;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_CPFPagCard;
        private System.Windows.Forms.TextBox tb_NomePagCard;
        private System.Windows.Forms.Label lb_NamePagCard;
        private System.Windows.Forms.Label lb_CPFPagCard;
        private System.Windows.Forms.RadioButton rb_HighNB;
        private System.Windows.Forms.RadioButton rb_MedNB;
        private System.Windows.Forms.RadioButton rb_EntryNB;
        private System.Windows.Forms.TextBox tb_CVV;
        private System.Windows.Forms.TextBox tb_CardNumber;
        private System.Windows.Forms.Label lb_CVV;
        private System.Windows.Forms.Label lb_CardNumber;
        private System.Windows.Forms.Button btn_SendBoleto;
        private System.Windows.Forms.Button btn_SendCard;
        private System.Windows.Forms.Label lb_qtDaysBol;
        private System.Windows.Forms.Label lb_qtDays;
        private System.Windows.Forms.NumericUpDown num_QtdDaysCard;
        private System.Windows.Forms.NumericUpDown num_QtdDaysBol;
        private System.Windows.Forms.NumericUpDown num_Parc;
        private System.Windows.Forms.Label lb_Parc;
    }
}