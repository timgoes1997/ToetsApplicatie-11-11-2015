namespace ToetsApplicatie
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNieuweVerhuringTijdstip = new System.Windows.Forms.DateTimePicker();
            this.btnNieuweVerhuringToevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNieuweVerhuringUren = new System.Windows.Forms.NumericUpDown();
            this.cbNieuweVerhuring = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbVerhuringen = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbVerkopen = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNieuweVerkoopToevoegen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNieuweVerkoopAantal = new System.Windows.Forms.NumericUpDown();
            this.cbNieuweVerkoop = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOverzichtExporteer = new System.Windows.Forms.Button();
            this.btnOverzichtDatumbereik = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOverzichtBTW = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpOverzichtTot = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOverzichtVan = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNieuweVerhuringUren)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNieuweVerkoopAantal)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNieuweVerhuringTijdstip);
            this.groupBox1.Controls.Add(this.btnNieuweVerhuringToevoegen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudNieuweVerhuringUren);
            this.groupBox1.Controls.Add(this.cbNieuweVerhuring);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuwe verhuring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Huur voor";
            // 
            // dtpNieuweVerhuringTijdstip
            // 
            this.dtpNieuweVerhuringTijdstip.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpNieuweVerhuringTijdstip.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpNieuweVerhuringTijdstip.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpNieuweVerhuringTijdstip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNieuweVerhuringTijdstip.Location = new System.Drawing.Point(6, 46);
            this.dtpNieuweVerhuringTijdstip.Name = "dtpNieuweVerhuringTijdstip";
            this.dtpNieuweVerhuringTijdstip.Size = new System.Drawing.Size(125, 20);
            this.dtpNieuweVerhuringTijdstip.TabIndex = 1;
            this.dtpNieuweVerhuringTijdstip.Value = new System.DateTime(2015, 11, 4, 14, 30, 0, 0);
            // 
            // btnNieuweVerhuringToevoegen
            // 
            this.btnNieuweVerhuringToevoegen.Location = new System.Drawing.Point(6, 104);
            this.btnNieuweVerhuringToevoegen.Name = "btnNieuweVerhuringToevoegen";
            this.btnNieuweVerhuringToevoegen.Size = new System.Drawing.Size(125, 23);
            this.btnNieuweVerhuringToevoegen.TabIndex = 3;
            this.btnNieuweVerhuringToevoegen.Text = "Toevoegen";
            this.btnNieuweVerhuringToevoegen.UseVisualStyleBackColor = true;
            this.btnNieuweVerhuringToevoegen.Click += new System.EventHandler(this.btnNieuweVerhuringToevoegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "uur";
            // 
            // nudNieuweVerhuringUren
            // 
            this.nudNieuweVerhuringUren.Location = new System.Drawing.Point(66, 72);
            this.nudNieuweVerhuringUren.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNieuweVerhuringUren.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNieuweVerhuringUren.Name = "nudNieuweVerhuringUren";
            this.nudNieuweVerhuringUren.Size = new System.Drawing.Size(31, 20);
            this.nudNieuweVerhuringUren.TabIndex = 2;
            this.nudNieuweVerhuringUren.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbNieuweVerhuring
            // 
            this.cbNieuweVerhuring.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNieuweVerhuring.FormattingEnabled = true;
            this.cbNieuweVerhuring.Items.AddRange(new object[] {
            "Sportzaal",
            "Vergaderzaal",
            "Feestzaal"});
            this.cbNieuweVerhuring.Location = new System.Drawing.Point(6, 19);
            this.cbNieuweVerhuring.Name = "cbNieuweVerhuring";
            this.cbNieuweVerhuring.Size = new System.Drawing.Size(125, 21);
            this.cbNieuweVerhuring.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbVerhuringen);
            this.groupBox2.Location = new System.Drawing.Point(157, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verhuringen";
            // 
            // lbVerhuringen
            // 
            this.lbVerhuringen.FormattingEnabled = true;
            this.lbVerhuringen.Location = new System.Drawing.Point(6, 19);
            this.lbVerhuringen.Name = "lbVerhuringen";
            this.lbVerhuringen.Size = new System.Drawing.Size(300, 108);
            this.lbVerhuringen.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbVerkopen);
            this.groupBox3.Location = new System.Drawing.Point(157, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 133);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verkopen";
            // 
            // lbVerkopen
            // 
            this.lbVerkopen.FormattingEnabled = true;
            this.lbVerkopen.Location = new System.Drawing.Point(6, 19);
            this.lbVerkopen.Name = "lbVerkopen";
            this.lbVerkopen.Size = new System.Drawing.Size(300, 108);
            this.lbVerkopen.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnNieuweVerkoopToevoegen);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudNieuweVerkoopAantal);
            this.groupBox4.Controls.Add(this.cbNieuweVerkoop);
            this.groupBox4.Location = new System.Drawing.Point(12, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 133);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nieuwe verkoop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Verkoop";
            // 
            // btnNieuweVerkoopToevoegen
            // 
            this.btnNieuweVerkoopToevoegen.Location = new System.Drawing.Point(6, 104);
            this.btnNieuweVerkoopToevoegen.Name = "btnNieuweVerkoopToevoegen";
            this.btnNieuweVerkoopToevoegen.Size = new System.Drawing.Size(125, 23);
            this.btnNieuweVerkoopToevoegen.TabIndex = 7;
            this.btnNieuweVerkoopToevoegen.Text = "Toevoegen";
            this.btnNieuweVerkoopToevoegen.UseVisualStyleBackColor = true;
            this.btnNieuweVerkoopToevoegen.Click += new System.EventHandler(this.btnNieuweVerkoopToevoegen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "stuks";
            // 
            // nudNieuweVerkoopAantal
            // 
            this.nudNieuweVerkoopAantal.Location = new System.Drawing.Point(66, 46);
            this.nudNieuweVerkoopAantal.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNieuweVerkoopAantal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNieuweVerkoopAantal.Name = "nudNieuweVerkoopAantal";
            this.nudNieuweVerkoopAantal.Size = new System.Drawing.Size(31, 20);
            this.nudNieuweVerkoopAantal.TabIndex = 6;
            this.nudNieuweVerkoopAantal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbNieuweVerkoop
            // 
            this.cbNieuweVerkoop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNieuweVerkoop.FormattingEnabled = true;
            this.cbNieuweVerkoop.Items.AddRange(new object[] {
            "Frisdrank",
            "Snack",
            "Sterkedrank"});
            this.cbNieuweVerkoop.Location = new System.Drawing.Point(6, 19);
            this.cbNieuweVerkoop.Name = "cbNieuweVerkoop";
            this.cbNieuweVerkoop.Size = new System.Drawing.Size(125, 21);
            this.cbNieuweVerkoop.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOverzichtExporteer);
            this.groupBox5.Controls.Add(this.btnOverzichtDatumbereik);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbOverzichtBTW);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.dtpOverzichtTot);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.dtpOverzichtVan);
            this.groupBox5.Location = new System.Drawing.Point(12, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 88);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Overzichten";
            // 
            // btnOverzichtExporteer
            // 
            this.btnOverzichtExporteer.Location = new System.Drawing.Point(326, 58);
            this.btnOverzichtExporteer.Name = "btnOverzichtExporteer";
            this.btnOverzichtExporteer.Size = new System.Drawing.Size(125, 23);
            this.btnOverzichtExporteer.TabIndex = 13;
            this.btnOverzichtExporteer.Text = "Exporteer";
            this.btnOverzichtExporteer.UseVisualStyleBackColor = true;
            this.btnOverzichtExporteer.Click += new System.EventHandler(this.btnOverzichtExporteer_Click);
            // 
            // btnOverzichtDatumbereik
            // 
            this.btnOverzichtDatumbereik.Location = new System.Drawing.Point(6, 58);
            this.btnOverzichtDatumbereik.Name = "btnOverzichtDatumbereik";
            this.btnOverzichtDatumbereik.Size = new System.Drawing.Size(285, 23);
            this.btnOverzichtDatumbereik.TabIndex = 11;
            this.btnOverzichtDatumbereik.Text = "Toon overzicht voor datumbereik";
            this.btnOverzichtDatumbereik.UseVisualStyleBackColor = true;
            this.btnOverzichtDatumbereik.Click += new System.EventHandler(this.btnOverzichtDatumbereik_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "BTW-tarief";
            // 
            // cbOverzichtBTW
            // 
            this.cbOverzichtBTW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOverzichtBTW.FormattingEnabled = true;
            this.cbOverzichtBTW.Items.AddRange(new object[] {
            "Ongespecificeerd",
            "Laag",
            "Hoog"});
            this.cbOverzichtBTW.Location = new System.Drawing.Point(326, 31);
            this.cbOverzichtBTW.Name = "cbOverzichtBTW";
            this.cbOverzichtBTW.Size = new System.Drawing.Size(125, 21);
            this.cbOverzichtBTW.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tot";
            // 
            // dtpOverzichtTot
            // 
            this.dtpOverzichtTot.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpOverzichtTot.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpOverzichtTot.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpOverzichtTot.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOverzichtTot.Location = new System.Drawing.Point(166, 32);
            this.dtpOverzichtTot.Name = "dtpOverzichtTot";
            this.dtpOverzichtTot.Size = new System.Drawing.Size(125, 20);
            this.dtpOverzichtTot.TabIndex = 10;
            this.dtpOverzichtTot.Value = new System.DateTime(2015, 11, 4, 18, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Van";
            // 
            // dtpOverzichtVan
            // 
            this.dtpOverzichtVan.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpOverzichtVan.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpOverzichtVan.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpOverzichtVan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOverzichtVan.Location = new System.Drawing.Point(6, 32);
            this.dtpOverzichtVan.Name = "dtpOverzichtVan";
            this.dtpOverzichtVan.Size = new System.Drawing.Size(125, 20);
            this.dtpOverzichtVan.TabIndex = 9;
            this.dtpOverzichtVan.Value = new System.DateTime(2015, 11, 4, 14, 30, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 388);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gemaakt door Tim Goes Sporthal De Ploeterende Panda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNieuweVerhuringUren)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNieuweVerkoopAantal)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNieuweVerhuring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNieuweVerhuringUren;
        private System.Windows.Forms.Button btnNieuweVerhuringToevoegen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbVerhuringen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNieuweVerhuringTijdstip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbVerkopen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNieuweVerkoopToevoegen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNieuweVerkoopAantal;
        private System.Windows.Forms.ComboBox cbNieuweVerkoop;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbOverzichtBTW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpOverzichtTot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOverzichtVan;
        private System.Windows.Forms.Button btnOverzichtDatumbereik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOverzichtExporteer;
    }
}

