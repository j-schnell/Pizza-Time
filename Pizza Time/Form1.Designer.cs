namespace Pizza_Time
{
	partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.radCrust4 = new System.Windows.Forms.RadioButton();
            this.radCrust3 = new System.Windows.Forms.RadioButton();
            this.radCrust2 = new System.Windows.Forms.RadioButton();
            this.radCrust1 = new System.Windows.Forms.RadioButton();
            this.grpCooked = new System.Windows.Forms.GroupBox();
            this.radCooked4 = new System.Windows.Forms.RadioButton();
            this.radCooked3 = new System.Windows.Forms.RadioButton();
            this.radCooked2 = new System.Windows.Forms.RadioButton();
            this.radCooked1 = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radSize4 = new System.Windows.Forms.RadioButton();
            this.radSize3 = new System.Windows.Forms.RadioButton();
            this.radSize2 = new System.Windows.Forms.RadioButton();
            this.radSize1 = new System.Windows.Forms.RadioButton();
            this.btnSplit = new System.Windows.Forms.Button();
            this.updQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.txtReceipt = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.grpCrust.SuspendLayout();
            this.grpCooked.SuspendLayout();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.radCrust4);
            this.grpCrust.Controls.Add(this.radCrust3);
            this.grpCrust.Controls.Add(this.radCrust2);
            this.grpCrust.Controls.Add(this.radCrust1);
            this.grpCrust.Location = new System.Drawing.Point(12, 12);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(150, 71);
            this.grpCrust.TabIndex = 0;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Croûte";
            this.ttpInfo.SetToolTip(this.grpCrust, "La type de croûte pour la pizza");
            // 
            // radCrust4
            // 
            this.radCrust4.AutoSize = true;
            this.radCrust4.Location = new System.Drawing.Point(84, 42);
            this.radCrust4.Name = "radCrust4";
            this.radCrust4.Size = new System.Drawing.Size(54, 17);
            this.radCrust4.TabIndex = 3;
            this.radCrust4.Text = "Farcie";
            this.radCrust4.UseVisualStyleBackColor = true;
            this.radCrust4.CheckedChanged += new System.EventHandler(this.RadCrust4_CheckedChanged);
            // 
            // radCrust3
            // 
            this.radCrust3.AutoSize = true;
            this.radCrust3.Location = new System.Drawing.Point(6, 42);
            this.radCrust3.Name = "radCrust3";
            this.radCrust3.Size = new System.Drawing.Size(51, 17);
            this.radCrust3.TabIndex = 2;
            this.radCrust3.Text = "Épais";
            this.radCrust3.UseVisualStyleBackColor = true;
            // 
            // radCrust2
            // 
            this.radCrust2.AutoSize = true;
            this.radCrust2.Location = new System.Drawing.Point(84, 19);
            this.radCrust2.Name = "radCrust2";
            this.radCrust2.Size = new System.Drawing.Size(58, 17);
            this.radCrust2.TabIndex = 1;
            this.radCrust2.Text = "Normal";
            this.radCrust2.UseVisualStyleBackColor = true;
            // 
            // radCrust1
            // 
            this.radCrust1.AutoSize = true;
            this.radCrust1.Location = new System.Drawing.Point(6, 19);
            this.radCrust1.Name = "radCrust1";
            this.radCrust1.Size = new System.Drawing.Size(54, 17);
            this.radCrust1.TabIndex = 0;
            this.radCrust1.Text = "Mince";
            this.radCrust1.UseVisualStyleBackColor = true;
            // 
            // grpCooked
            // 
            this.grpCooked.Controls.Add(this.radCooked4);
            this.grpCooked.Controls.Add(this.radCooked3);
            this.grpCooked.Controls.Add(this.radCooked2);
            this.grpCooked.Controls.Add(this.radCooked1);
            this.grpCooked.Location = new System.Drawing.Point(198, 12);
            this.grpCooked.Name = "grpCooked";
            this.grpCooked.Size = new System.Drawing.Size(161, 71);
            this.grpCooked.TabIndex = 1;
            this.grpCooked.TabStop = false;
            this.grpCooked.Text = "Cuisson";
            this.ttpInfo.SetToolTip(this.grpCooked, "Le niveau de cuisson pour la pizza");
            // 
            // radCooked4
            // 
            this.radCooked4.AutoSize = true;
            this.radCooked4.Location = new System.Drawing.Point(84, 42);
            this.radCooked4.Name = "radCooked4";
            this.radCooked4.Size = new System.Drawing.Size(66, 17);
            this.radCooked4.TabIndex = 3;
            this.radCooked4.Text = "Très cuit";
            this.radCooked4.UseVisualStyleBackColor = true;
            // 
            // radCooked3
            // 
            this.radCooked3.AutoSize = true;
            this.radCooked3.Location = new System.Drawing.Point(6, 42);
            this.radCooked3.Name = "radCooked3";
            this.radCooked3.Size = new System.Drawing.Size(58, 17);
            this.radCooked3.TabIndex = 2;
            this.radCooked3.Text = "Normal";
            this.radCooked3.UseVisualStyleBackColor = true;
            // 
            // radCooked2
            // 
            this.radCooked2.AutoSize = true;
            this.radCooked2.Location = new System.Drawing.Point(84, 19);
            this.radCooked2.Name = "radCooked2";
            this.radCooked2.Size = new System.Drawing.Size(65, 17);
            this.radCooked2.TabIndex = 1;
            this.radCooked2.Text = "Peu Cuit";
            this.radCooked2.UseVisualStyleBackColor = true;
            // 
            // radCooked1
            // 
            this.radCooked1.AutoSize = true;
            this.radCooked1.Location = new System.Drawing.Point(6, 19);
            this.radCooked1.Name = "radCooked1";
            this.radCooked1.Size = new System.Drawing.Size(65, 17);
            this.radCooked1.TabIndex = 0;
            this.radCooked1.Text = "Non cuit";
            this.radCooked1.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radSize4);
            this.grpSize.Controls.Add(this.radSize3);
            this.grpSize.Controls.Add(this.radSize2);
            this.grpSize.Controls.Add(this.radSize1);
            this.grpSize.Location = new System.Drawing.Point(395, 12);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(177, 71);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Largeur";
            this.ttpInfo.SetToolTip(this.grpSize, "La largeur de la pizza");
            // 
            // radSize4
            // 
            this.radSize4.AutoSize = true;
            this.radSize4.Location = new System.Drawing.Point(84, 42);
            this.radSize4.Name = "radSize4";
            this.radSize4.Size = new System.Drawing.Size(79, 17);
            this.radSize4.TabIndex = 3;
            this.radSize4.Text = "Extra Large";
            this.radSize4.UseVisualStyleBackColor = true;
            this.radSize4.CheckedChanged += new System.EventHandler(this.RadSize_CheckedChanged);
            // 
            // radSize3
            // 
            this.radSize3.AutoSize = true;
            this.radSize3.Location = new System.Drawing.Point(6, 42);
            this.radSize3.Name = "radSize3";
            this.radSize3.Size = new System.Drawing.Size(52, 17);
            this.radSize3.TabIndex = 2;
            this.radSize3.Text = "Large";
            this.radSize3.UseVisualStyleBackColor = true;
            this.radSize3.CheckedChanged += new System.EventHandler(this.RadSize_CheckedChanged);
            // 
            // radSize2
            // 
            this.radSize2.AutoSize = true;
            this.radSize2.Location = new System.Drawing.Point(84, 19);
            this.radSize2.Name = "radSize2";
            this.radSize2.Size = new System.Drawing.Size(69, 17);
            this.radSize2.TabIndex = 1;
            this.radSize2.Text = "Moyenne";
            this.radSize2.UseVisualStyleBackColor = true;
            this.radSize2.CheckedChanged += new System.EventHandler(this.RadSize_CheckedChanged);
            // 
            // radSize1
            // 
            this.radSize1.AutoSize = true;
            this.radSize1.Location = new System.Drawing.Point(6, 19);
            this.radSize1.Name = "radSize1";
            this.radSize1.Size = new System.Drawing.Size(52, 17);
            this.radSize1.TabIndex = 0;
            this.radSize1.Text = "Petite";
            this.radSize1.UseVisualStyleBackColor = true;
            this.radSize1.CheckedChanged += new System.EventHandler(this.RadSize_CheckedChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(395, 89);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(177, 23);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Divise la pizza";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // updQuantity
            // 
            this.updQuantity.Location = new System.Drawing.Point(245, 291);
            this.updQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updQuantity.Name = "updQuantity";
            this.updQuantity.Size = new System.Drawing.Size(114, 20);
            this.updQuantity.TabIndex = 5;
            this.ttpInfo.SetToolTip(this.updQuantity, "Le nombre de pizzas d\'ajouter à l\'ordre");
            this.updQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter la Pizza";
            this.ttpInfo.SetToolTip(this.btnAdd, "Ajoute la pizza spécifié actuellement à l\'ordre");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Enabled = false;
            this.btnOrder.Location = new System.Drawing.Point(494, 510);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(78, 23);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Commander";
            this.ttpInfo.SetToolTip(this.btnOrder, "Pour commander la pizza");
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(245, 238);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(114, 50);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Quantité de pizzas à ajouter";
            // 
            // lblReceipt
            // 
            this.lblReceipt.Location = new System.Drawing.Point(398, 134);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(174, 13);
            this.lblReceipt.TabIndex = 10;
            this.lblReceipt.Text = "Facture";
            this.lblReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(395, 150);
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(177, 354);
            this.txtReceipt.TabIndex = 11;
            this.txtReceipt.Text = "";
            this.ttpInfo.SetToolTip(this.txtReceipt, "La facture");
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Annuler";
            this.ttpInfo.SetToolTip(this.btnCancel, "Pour annuler l\'ordre et recommencer");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(594, 551);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.updQuantity);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpCooked);
            this.Controls.Add(this.grpCrust);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Pizza";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpCooked.ResumeLayout(false);
            this.grpCooked.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updQuantity)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpCrust;
		private System.Windows.Forms.RadioButton radCrust4;
		private System.Windows.Forms.RadioButton radCrust3;
		private System.Windows.Forms.RadioButton radCrust2;
		private System.Windows.Forms.RadioButton radCrust1;
		private System.Windows.Forms.GroupBox grpCooked;
		private System.Windows.Forms.RadioButton radCooked4;
		private System.Windows.Forms.RadioButton radCooked3;
		private System.Windows.Forms.RadioButton radCooked2;
		private System.Windows.Forms.RadioButton radCooked1;
		private System.Windows.Forms.GroupBox grpSize;
		private System.Windows.Forms.RadioButton radSize4;
		private System.Windows.Forms.RadioButton radSize3;
		private System.Windows.Forms.RadioButton radSize2;
		private System.Windows.Forms.RadioButton radSize1;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.NumericUpDown updQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.RichTextBox txtReceipt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}

