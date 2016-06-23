using System.ComponentModel;

namespace Bootverhuur__t_Sloepke
{
    partial class HuurAanmaken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuurAanmaken));
            this.cbBoot = new System.Windows.Forms.ComboBox();
            this.LblBoot = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVerhuurder = new System.Windows.Forms.TextBox();
            this.tbHuurder = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnToon = new System.Windows.Forms.Button();
            this.listBoot = new System.Windows.Forms.ListBox();
            this.listVaarwater = new System.Windows.Forms.ListBox();
            this.listMateriaal = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMeren = new System.Windows.Forms.Label();
            this.btnExporteerContract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBoot
            // 
            this.cbBoot.FormattingEnabled = true;
            this.cbBoot.Location = new System.Drawing.Point(121, 32);
            this.cbBoot.Name = "cbBoot";
            this.cbBoot.Size = new System.Drawing.Size(121, 21);
            this.cbBoot.TabIndex = 0;
            this.cbBoot.SelectedIndexChanged += new System.EventHandler(this.cbBoot_SelectedIndexChanged);
            // 
            // LblBoot
            // 
            this.LblBoot.AutoSize = true;
            this.LblBoot.Location = new System.Drawing.Point(22, 35);
            this.LblBoot.Name = "LblBoot";
            this.LblBoot.Size = new System.Drawing.Size(52, 13);
            this.LblBoot.TabIndex = 1;
            this.LblBoot.Text = "Boottype:";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(121, 74);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 2;
            this.dtpBegin.Value = new System.DateTime(2016, 6, 23, 10, 4, 53, 0);
            // 
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(121, 118);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(200, 20);
            this.dtpEind.TabIndex = 3;
            this.dtpEind.Value = new System.DateTime(2016, 6, 23, 10, 4, 53, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Begindatum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Einddatum:";
            // 
            // nudBudget
            // 
            this.nudBudget.Location = new System.Drawing.Point(121, 165);
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(120, 20);
            this.nudBudget.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Budget:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Naam verhuurder:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naam huurder: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email huurder: ";
            // 
            // tbVerhuurder
            // 
            this.tbVerhuurder.Location = new System.Drawing.Point(121, 211);
            this.tbVerhuurder.Name = "tbVerhuurder";
            this.tbVerhuurder.Size = new System.Drawing.Size(200, 20);
            this.tbVerhuurder.TabIndex = 11;
            // 
            // tbHuurder
            // 
            this.tbHuurder.Location = new System.Drawing.Point(121, 246);
            this.tbHuurder.Name = "tbHuurder";
            this.tbHuurder.Size = new System.Drawing.Size(200, 20);
            this.tbHuurder.TabIndex = 12;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(121, 278);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(25, 355);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(97, 23);
            this.btnBereken.TabIndex = 14;
            this.btnBereken.Text = "Bereken meren";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(166, 355);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(155, 23);
            this.btnOpslaan.TabIndex = 15;
            this.btnOpslaan.Text = "Huurcontract aanmaken";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(27, 408);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(87, 56);
            this.btnToon.TabIndex = 16;
            this.btnToon.Text = "Toon huurcontracten";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // listBoot
            // 
            this.listBoot.FormattingEnabled = true;
            this.listBoot.Location = new System.Drawing.Point(345, 32);
            this.listBoot.Name = "listBoot";
            this.listBoot.Size = new System.Drawing.Size(255, 459);
            this.listBoot.TabIndex = 17;
            // 
            // listVaarwater
            // 
            this.listVaarwater.FormattingEnabled = true;
            this.listVaarwater.Location = new System.Drawing.Point(664, 32);
            this.listVaarwater.Name = "listVaarwater";
            this.listVaarwater.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listVaarwater.Size = new System.Drawing.Size(114, 459);
            this.listVaarwater.TabIndex = 18;
            // 
            // listMateriaal
            // 
            this.listMateriaal.FormattingEnabled = true;
            this.listMateriaal.Location = new System.Drawing.Point(833, 32);
            this.listMateriaal.Name = "listMateriaal";
            this.listMateriaal.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listMateriaal.Size = new System.Drawing.Size(364, 459);
            this.listMateriaal.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aantal Friese meren: ";
            // 
            // lblMeren
            // 
            this.lblMeren.AutoSize = true;
            this.lblMeren.Location = new System.Drawing.Point(137, 314);
            this.lblMeren.Name = "lblMeren";
            this.lblMeren.Size = new System.Drawing.Size(0, 13);
            this.lblMeren.TabIndex = 21;
            // 
            // btnExporteerContract
            // 
            this.btnExporteerContract.Location = new System.Drawing.Point(166, 408);
            this.btnExporteerContract.Name = "btnExporteerContract";
            this.btnExporteerContract.Size = new System.Drawing.Size(87, 56);
            this.btnExporteerContract.TabIndex = 22;
            this.btnExporteerContract.Text = "Exporteer huurcontract";
            this.btnExporteerContract.UseVisualStyleBackColor = true;
            this.btnExporteerContract.Click += new System.EventHandler(this.btnExporteerContract_Click);
            // 
            // HuurAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 528);
            this.Controls.Add(this.btnExporteerContract);
            this.Controls.Add(this.lblMeren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listMateriaal);
            this.Controls.Add(this.listVaarwater);
            this.Controls.Add(this.listBoot);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbHuurder);
            this.Controls.Add(this.tbVerhuurder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEind);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.LblBoot);
            this.Controls.Add(this.cbBoot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HuurAanmaken";
            this.Text = "Huur aanmaken";
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoot;
        private System.Windows.Forms.Label LblBoot;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVerhuurder;
        private System.Windows.Forms.TextBox tbHuurder;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.ListBox listBoot;
        private System.Windows.Forms.ListBox listVaarwater;
        private System.Windows.Forms.ListBox listMateriaal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMeren;
        private System.Windows.Forms.Button btnExporteerContract;
    }
}

