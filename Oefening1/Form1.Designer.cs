namespace Oefening1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.tb_titel = new System.Windows.Forms.TextBox();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.cb_tijdbool = new System.Windows.Forms.CheckBox();
            this.b_add_task = new System.Windows.Forms.Button();
            this.l_tijd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fouteRij = new System.Windows.Forms.TextBox();
            this.b_volgendeTaak = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_zetAchteraan = new System.Windows.Forms.Button();
            this.tb_multiline = new System.Windows.Forms.TextBox();
            this.b_multiline = new System.Windows.Forms.Button();
            this.b_messageBox = new System.Windows.Forms.Button();
            this.b_biep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_date.Location = new System.Drawing.Point(83, 111);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_date.TabIndex = 0;
            // 
            // tb_titel
            // 
            this.tb_titel.Location = new System.Drawing.Point(83, 140);
            this.tb_titel.Name = "tb_titel";
            this.tb_titel.Size = new System.Drawing.Size(100, 23);
            this.tb_titel.TabIndex = 1;
            // 
            // tb_info
            // 
            this.tb_info.Location = new System.Drawing.Point(83, 169);
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(100, 23);
            this.tb_info.TabIndex = 2;
            // 
            // cb_tijdbool
            // 
            this.cb_tijdbool.AutoSize = true;
            this.cb_tijdbool.Location = new System.Drawing.Point(83, 198);
            this.cb_tijdbool.Name = "cb_tijdbool";
            this.cb_tijdbool.Size = new System.Drawing.Size(45, 19);
            this.cb_tijdbool.TabIndex = 3;
            this.cb_tijdbool.Text = "Tijd";
            this.cb_tijdbool.UseVisualStyleBackColor = true;
            this.cb_tijdbool.CheckedChanged += new System.EventHandler(this.cb_tijdbool_CheckedChanged);
            // 
            // b_add_task
            // 
            this.b_add_task.Location = new System.Drawing.Point(83, 223);
            this.b_add_task.Name = "b_add_task";
            this.b_add_task.Size = new System.Drawing.Size(119, 23);
            this.b_add_task.TabIndex = 4;
            this.b_add_task.Text = "Taak Toevegen";
            this.b_add_task.UseVisualStyleBackColor = true;
            this.b_add_task.Click += new System.EventHandler(this.b_add_task_Click);
            // 
            // l_tijd
            // 
            this.l_tijd.AutoSize = true;
            this.l_tijd.Location = new System.Drawing.Point(13, 117);
            this.l_tijd.Name = "l_tijd";
            this.l_tijd.Size = new System.Drawing.Size(29, 15);
            this.l_tijd.TabIndex = 5;
            this.l_tijd.Text = "Tijd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informatie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "FouteRij<TeDoen>";
            // 
            // tb_fouteRij
            // 
            this.tb_fouteRij.Location = new System.Drawing.Point(38, 36);
            this.tb_fouteRij.Name = "tb_fouteRij";
            this.tb_fouteRij.ReadOnly = true;
            this.tb_fouteRij.Size = new System.Drawing.Size(750, 23);
            this.tb_fouteRij.TabIndex = 9;
            // 
            // b_volgendeTaak
            // 
            this.b_volgendeTaak.Location = new System.Drawing.Point(208, 223);
            this.b_volgendeTaak.Name = "b_volgendeTaak";
            this.b_volgendeTaak.Size = new System.Drawing.Size(110, 23);
            this.b_volgendeTaak.TabIndex = 10;
            this.b_volgendeTaak.Text = "Volgende Taak";
            this.b_volgendeTaak.UseVisualStyleBackColor = true;
            this.b_volgendeTaak.Click += new System.EventHandler(this.b_volgendeTaak_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Taak is afgewerkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_zetAchteraan
            // 
            this.b_zetAchteraan.Location = new System.Drawing.Point(208, 252);
            this.b_zetAchteraan.Name = "b_zetAchteraan";
            this.b_zetAchteraan.Size = new System.Drawing.Size(110, 23);
            this.b_zetAchteraan.TabIndex = 12;
            this.b_zetAchteraan.Text = "Zet Achteraan";
            this.b_zetAchteraan.UseVisualStyleBackColor = true;
            this.b_zetAchteraan.Click += new System.EventHandler(this.b_zetAchteraan_Click);
            // 
            // tb_multiline
            // 
            this.tb_multiline.Location = new System.Drawing.Point(369, 111);
            this.tb_multiline.Multiline = true;
            this.tb_multiline.Name = "tb_multiline";
            this.tb_multiline.Size = new System.Drawing.Size(391, 164);
            this.tb_multiline.TabIndex = 13;
            // 
            // b_multiline
            // 
            this.b_multiline.Location = new System.Drawing.Point(83, 281);
            this.b_multiline.Name = "b_multiline";
            this.b_multiline.Size = new System.Drawing.Size(119, 23);
            this.b_multiline.TabIndex = 14;
            this.b_multiline.Text = "textBox";
            this.b_multiline.UseVisualStyleBackColor = true;
            this.b_multiline.Click += new System.EventHandler(this.b_multiline_Click);
            // 
            // b_messageBox
            // 
            this.b_messageBox.Location = new System.Drawing.Point(208, 281);
            this.b_messageBox.Name = "b_messageBox";
            this.b_messageBox.Size = new System.Drawing.Size(110, 23);
            this.b_messageBox.TabIndex = 15;
            this.b_messageBox.Text = "MessageBox";
            this.b_messageBox.UseVisualStyleBackColor = true;
            this.b_messageBox.Click += new System.EventHandler(this.b_messageBox_Click);
            // 
            // b_biep
            // 
            this.b_biep.Location = new System.Drawing.Point(83, 310);
            this.b_biep.Name = "b_biep";
            this.b_biep.Size = new System.Drawing.Size(235, 23);
            this.b_biep.TabIndex = 16;
            this.b_biep.Text = "Biep";
            this.b_biep.UseVisualStyleBackColor = true;
            this.b_biep.Click += new System.EventHandler(this.b_biep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_biep);
            this.Controls.Add(this.b_messageBox);
            this.Controls.Add(this.b_multiline);
            this.Controls.Add(this.tb_multiline);
            this.Controls.Add(this.b_zetAchteraan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_volgendeTaak);
            this.Controls.Add(this.tb_fouteRij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_tijd);
            this.Controls.Add(this.b_add_task);
            this.Controls.Add(this.cb_tijdbool);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.tb_titel);
            this.Controls.Add(this.dtp_date);
            this.Name = "Form1";
            this.Text = "OPDRACHT 4: \"TeDoen\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_date;
        private TextBox tb_titel;
        private TextBox tb_info;
        private CheckBox cb_tijdbool;
        private Button b_add_task;
        private Label l_tijd;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox tb_fouteRij;
        private Button b_volgendeTaak;
        private Button button1;
        private Button b_zetAchteraan;
        private TextBox tb_multiline;
        private Button b_multiline;
        private Button b_messageBox;
        private Button b_biep;
    }
}