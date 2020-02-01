namespace Pizza_Time
{
    partial class frmDelivery
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
            this.components = new System.ComponentModel.Container();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtName1
            // 
            this.txtName1.AccessibleDescription = "Prénom";
            this.txtName1.Location = new System.Drawing.Point(12, 12);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 20);
            this.txtName1.TabIndex = 2;
            this.txtName1.Text = "Prénom";
            this.ttpInfo.SetToolTip(this.txtName1, "Ton prénom");
            this.txtName1.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtName1.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtName2
            // 
            this.txtName2.AccessibleDescription = "Nom";
            this.txtName2.Location = new System.Drawing.Point(139, 12);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(149, 20);
            this.txtName2.TabIndex = 3;
            this.txtName2.Text = "Nom";
            this.ttpInfo.SetToolTip(this.txtName2, "Ton nom de famille");
            this.txtName2.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtName2.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtAddress1
            // 
            this.txtAddress1.AccessibleDescription = "Addresse 1";
            this.txtAddress1.Location = new System.Drawing.Point(12, 68);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(276, 20);
            this.txtAddress1.TabIndex = 4;
            this.txtAddress1.Text = "Addresse 1";
            this.ttpInfo.SetToolTip(this.txtAddress1, "Ton addresse, la rue et le numéro");
            this.txtAddress1.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtAddress1.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtAddress2
            // 
            this.txtAddress2.AccessibleDescription = "Addresse 2 (numéro d\'unité)";
            this.txtAddress2.Location = new System.Drawing.Point(12, 109);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(276, 20);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.Text = "Addresse 2 (numéro d\'unité)";
            this.ttpInfo.SetToolTip(this.txtAddress2, "Ta deuxième addresse, le numéro d\'unité par example");
            this.txtAddress2.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtAddress2.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtCity
            // 
            this.txtCity.AccessibleDescription = "Ville";
            this.txtCity.Location = new System.Drawing.Point(139, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(149, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.Text = "Ville";
            this.ttpInfo.SetToolTip(this.txtCity, "La ville où tu habite");
            this.txtCity.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtCity.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // cmbProvince
            // 
            this.cmbProvince.AccessibleDescription = "Province";
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cmbProvince.Location = new System.Drawing.Point(12, 200);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(100, 21);
            this.cmbProvince.TabIndex = 8;
            this.cmbProvince.Text = "Province";
            this.ttpInfo.SetToolTip(this.cmbProvince, "La province où tu habite");
            this.cmbProvince.Enter += new System.EventHandler(this.CmbProvince_Enter);
            this.cmbProvince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbProvince_KeyPress);
            this.cmbProvince.Leave += new System.EventHandler(this.CmbProvince_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.ttpInfo.SetToolTip(this.btnCancel, "Annuler la livraison");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(139, 264);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(149, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Commander";
            this.ttpInfo.SetToolTip(this.btnConfirm, "Placer l\'ordre pour la livraison");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Code Postale";
            this.textBox1.Location = new System.Drawing.Point(12, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Code Postale";
            this.ttpInfo.SetToolTip(this.textBox1, "Ton code postale");
            this.textBox1.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // frmDelivery
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(309, 299);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDelivery";
            this.Text = "Bon de commande de livraison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}