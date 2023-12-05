namespace DmScreen1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dicebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Nonlabel1 = new System.Windows.Forms.Label();
            this.Nonlabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Damagebox = new System.Windows.Forms.TextBox();
            this.Nonlabel3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAdvantage = new System.Windows.Forms.CheckBox();
            this.checkBoxDisadvantage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vairable data";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dalelands Uncial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(780, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Roll!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dicebox
            // 
            this.Dicebox.Location = new System.Drawing.Point(175, 68);
            this.Dicebox.Margin = new System.Windows.Forms.Padding(4);
            this.Dicebox.Name = "Dicebox";
            this.Dicebox.Size = new System.Drawing.Size(132, 22);
            this.Dicebox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roll Result";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBox1.Location = new System.Drawing.Point(377, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Nonlabel1
            // 
            this.Nonlabel1.AutoSize = true;
            this.Nonlabel1.Font = new System.Drawing.Font("Dalelands Uncial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nonlabel1.Location = new System.Drawing.Point(5, 69);
            this.Nonlabel1.Name = "Nonlabel1";
            this.Nonlabel1.Size = new System.Drawing.Size(148, 21);
            this.Nonlabel1.TabIndex = 5;
            this.Nonlabel1.Text = "Roll to Hit!";
            // 
            // Nonlabel2
            // 
            this.Nonlabel2.AutoSize = true;
            this.Nonlabel2.Font = new System.Drawing.Font("Dalelands Uncial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nonlabel2.Location = new System.Drawing.Point(325, 69);
            this.Nonlabel2.Name = "Nonlabel2";
            this.Nonlabel2.Size = new System.Drawing.Size(43, 21);
            this.Nonlabel2.TabIndex = 6;
            this.Nonlabel2.Text = "AC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hit or Miss";
            // 
            // Damagebox
            // 
            this.Damagebox.Location = new System.Drawing.Point(641, 68);
            this.Damagebox.Name = "Damagebox";
            this.Damagebox.Size = new System.Drawing.Size(132, 22);
            this.Damagebox.TabIndex = 8;
            // 
            // Nonlabel3
            // 
            this.Nonlabel3.AutoSize = true;
            this.Nonlabel3.Font = new System.Drawing.Font("Dalelands Uncial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nonlabel3.Location = new System.Drawing.Point(513, 67);
            this.Nonlabel3.Name = "Nonlabel3";
            this.Nonlabel3.Size = new System.Drawing.Size(107, 21);
            this.Nonlabel3.TabIndex = 9;
            this.Nonlabel3.Text = "Damage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Damage";
            // 
            // checkBoxAdvantage
            // 
            this.checkBoxAdvantage.AutoSize = true;
            this.checkBoxAdvantage.Location = new System.Drawing.Point(896, 73);
            this.checkBoxAdvantage.Name = "checkBoxAdvantage";
            this.checkBoxAdvantage.Size = new System.Drawing.Size(95, 20);
            this.checkBoxAdvantage.TabIndex = 11;
            this.checkBoxAdvantage.Text = "Advantage";
            this.checkBoxAdvantage.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisadvantage
            // 
            this.checkBoxDisadvantage.AutoSize = true;
            this.checkBoxDisadvantage.Location = new System.Drawing.Point(997, 73);
            this.checkBoxDisadvantage.Name = "checkBoxDisadvantage";
            this.checkBoxDisadvantage.Size = new System.Drawing.Size(114, 20);
            this.checkBoxDisadvantage.TabIndex = 12;
            this.checkBoxDisadvantage.Text = "Disadvantage";
            this.checkBoxDisadvantage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 671);
            this.Controls.Add(this.checkBoxDisadvantage);
            this.Controls.Add(this.checkBoxAdvantage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nonlabel3);
            this.Controls.Add(this.Damagebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nonlabel2);
            this.Controls.Add(this.Nonlabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dicebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DM screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Dicebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Nonlabel1;
        private System.Windows.Forms.Label Nonlabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Damagebox;
        private System.Windows.Forms.Label Nonlabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAdvantage;
        private System.Windows.Forms.CheckBox checkBoxDisadvantage;
    }
}

