
namespace DJIKPA_Daniel_Elie_TP2_ST2TRD
{
    partial class FormTP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTP2));
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxDecryption = new System.Windows.Forms.TextBox();
            this.textBoxEncryption = new System.Windows.Forms.TextBox();
            this.panelKey = new System.Windows.Forms.Panel();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.panelEncryption = new System.Windows.Forms.Panel();
            this.comboBoxChooseEncryptionMode = new System.Windows.Forms.ComboBox();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonArrowEncryptToDecrypt = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonArrowDecryptToEncrypt = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelKey.SuspendLayout();
            this.panelEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonArrowDecryptToEncrypt);
            this.panelMain.Controls.Add(this.buttonArrowEncryptToDecrypt);
            this.panelMain.Controls.Add(this.textBoxDecryption);
            this.panelMain.Controls.Add(this.textBoxEncryption);
            this.panelMain.Controls.Add(this.panelKey);
            this.panelMain.Controls.Add(this.panelEncryption);
            this.panelMain.Location = new System.Drawing.Point(1, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(835, 418);
            this.panelMain.TabIndex = 0;
            // 
            // textBoxDecryption
            // 
            this.textBoxDecryption.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDecryption.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDecryption.Location = new System.Drawing.Point(499, 46);
            this.textBoxDecryption.Multiline = true;
            this.textBoxDecryption.Name = "textBoxDecryption";
            this.textBoxDecryption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecryption.Size = new System.Drawing.Size(336, 372);
            this.textBoxDecryption.TabIndex = 3;
            this.textBoxDecryption.Text = "Text Decrypted";
            this.textBoxDecryption.Enter += new System.EventHandler(this.textBoxDecryption_Enter);
            this.textBoxDecryption.Leave += new System.EventHandler(this.textBoxDecryption_Leave);
            // 
            // textBoxEncryption
            // 
            this.textBoxEncryption.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEncryption.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxEncryption.Location = new System.Drawing.Point(137, 46);
            this.textBoxEncryption.Multiline = true;
            this.textBoxEncryption.Name = "textBoxEncryption";
            this.textBoxEncryption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncryption.Size = new System.Drawing.Size(316, 372);
            this.textBoxEncryption.TabIndex = 2;
            this.textBoxEncryption.Text = "Text to Encrypt";
            this.textBoxEncryption.Enter += new System.EventHandler(this.textBoxEncryption_Enter);
            this.textBoxEncryption.Leave += new System.EventHandler(this.textBoxEncryption_Leave);
            // 
            // panelKey
            // 
            this.panelKey.BackColor = System.Drawing.Color.DarkBlue;
            this.panelKey.Controls.Add(this.textBoxKey);
            this.panelKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKey.Location = new System.Drawing.Point(137, 0);
            this.panelKey.Name = "panelKey";
            this.panelKey.Size = new System.Drawing.Size(698, 46);
            this.panelKey.TabIndex = 1;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxKey.Location = new System.Drawing.Point(260, 10);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(164, 22);
            this.textBoxKey.TabIndex = 1;
            this.textBoxKey.Text = "Enter Your Key";
            this.textBoxKey.Enter += new System.EventHandler(this.textBoxKey_Enter);
            this.textBoxKey.Leave += new System.EventHandler(this.textBoxKey_Leave);
            // 
            // panelEncryption
            // 
            this.panelEncryption.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelEncryption.Controls.Add(this.buttonClear);
            this.panelEncryption.Controls.Add(this.label1);
            this.panelEncryption.Controls.Add(this.comboBoxChooseEncryptionMode);
            this.panelEncryption.Controls.Add(this.buttonDecryption);
            this.panelEncryption.Controls.Add(this.buttonEncryption);
            this.panelEncryption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEncryption.Location = new System.Drawing.Point(0, 0);
            this.panelEncryption.Name = "panelEncryption";
            this.panelEncryption.Size = new System.Drawing.Size(137, 418);
            this.panelEncryption.TabIndex = 0;
            // 
            // comboBoxChooseEncryptionMode
            // 
            this.comboBoxChooseEncryptionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseEncryptionMode.FormattingEnabled = true;
            this.comboBoxChooseEncryptionMode.Items.AddRange(new object[] {
            "Binary",
            "Caesar",
            "Vignere"});
            this.comboBoxChooseEncryptionMode.Location = new System.Drawing.Point(10, 25);
            this.comboBoxChooseEncryptionMode.Name = "comboBoxChooseEncryptionMode";
            this.comboBoxChooseEncryptionMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseEncryptionMode.TabIndex = 2;
            this.comboBoxChooseEncryptionMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseEncryptionMode_SelectedIndexChanged);
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecryption.Location = new System.Drawing.Point(14, 317);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(108, 33);
            this.buttonDecryption.TabIndex = 1;
            this.buttonDecryption.Text = "Decryption";
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.buttonDecryption_Click);
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncryption.Location = new System.Drawing.Point(14, 238);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(108, 33);
            this.buttonEncryption.TabIndex = 0;
            this.buttonEncryption.Text = "Encryption";
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.buttonEncryption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encryption Mode";
            // 
            // buttonArrowEncryptToDecrypt
            // 
            this.buttonArrowEncryptToDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonArrowEncryptToDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonArrowEncryptToDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrowEncryptToDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("buttonArrowEncryptToDecrypt.Image")));
            this.buttonArrowEncryptToDecrypt.Location = new System.Drawing.Point(466, 188);
            this.buttonArrowEncryptToDecrypt.Name = "buttonArrowEncryptToDecrypt";
            this.buttonArrowEncryptToDecrypt.Size = new System.Drawing.Size(27, 23);
            this.buttonArrowEncryptToDecrypt.TabIndex = 4;
            this.buttonArrowEncryptToDecrypt.UseVisualStyleBackColor = false;
            this.buttonArrowEncryptToDecrypt.Click += new System.EventHandler(this.buttonArrowEncryptToDecrypt_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Image = global::DJIKPA_Daniel_Elie_TP2_ST2TRD.Properties.Resources.icons8_broom_32px_1;
            this.buttonClear.Location = new System.Drawing.Point(84, 368);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 47);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonArrowDecryptToEncrypt
            // 
            this.buttonArrowDecryptToEncrypt.FlatAppearance.BorderSize = 0;
            this.buttonArrowDecryptToEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrowDecryptToEncrypt.Image = global::DJIKPA_Daniel_Elie_TP2_ST2TRD.Properties.Resources.icons8_arrow_pointing_left_32px;
            this.buttonArrowDecryptToEncrypt.Location = new System.Drawing.Point(459, 217);
            this.buttonArrowDecryptToEncrypt.Name = "buttonArrowDecryptToEncrypt";
            this.buttonArrowDecryptToEncrypt.Size = new System.Drawing.Size(34, 23);
            this.buttonArrowDecryptToEncrypt.TabIndex = 5;
            this.buttonArrowDecryptToEncrypt.UseVisualStyleBackColor = true;
            this.buttonArrowDecryptToEncrypt.Click += new System.EventHandler(this.buttonArrowDecryptToEncrypt_Click);
            // 
            // FormTP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 424);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTP2";
            this.Text = "TP2 Encryption-Decryption";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelKey.ResumeLayout(false);
            this.panelKey.PerformLayout();
            this.panelEncryption.ResumeLayout(false);
            this.panelEncryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxDecryption;
        private System.Windows.Forms.TextBox textBoxEncryption;
        private System.Windows.Forms.Panel panelKey;
        private System.Windows.Forms.Panel panelEncryption;
        private System.Windows.Forms.Button buttonDecryption;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonArrowEncryptToDecrypt;
        private System.Windows.Forms.ComboBox comboBoxChooseEncryptionMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonArrowDecryptToEncrypt;
    }
}

