namespace _4lr
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
            this.number_labo = new System.Windows.Forms.Label();
            this.bytesLabo = new System.Windows.Forms.Label();
            this.pmLabo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.bytes = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roundsTB = new System.Windows.Forms.TextBox();
            this.fermaViewTB = new System.Windows.Forms.TextBox();
            this.fermaTimeTB = new System.Windows.Forms.TextBox();
            this.rabinViewTB = new System.Windows.Forms.TextBox();
            this.rabinTimeTB = new System.Windows.Forms.TextBox();
            this.detViewTB = new System.Windows.Forms.TextBox();
            this.detTimeTB = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number_labo
            // 
            this.number_labo.AutoSize = true;
            this.number_labo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_labo.Location = new System.Drawing.Point(193, 88);
            this.number_labo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.number_labo.Name = "number_labo";
            this.number_labo.Size = new System.Drawing.Size(87, 35);
            this.number_labo.TabIndex = 0;
            this.number_labo.Text = "Число";
            // 
            // bytesLabo
            // 
            this.bytesLabo.AutoSize = true;
            this.bytesLabo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bytesLabo.Location = new System.Drawing.Point(962, 113);
            this.bytesLabo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bytesLabo.Name = "bytesLabo";
            this.bytesLabo.Size = new System.Drawing.Size(85, 35);
            this.bytesLabo.TabIndex = 1;
            this.bytesLabo.Text = "Байты";
            // 
            // pmLabo
            // 
            this.pmLabo.AutoSize = true;
            this.pmLabo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pmLabo.Location = new System.Drawing.Point(563, 113);
            this.pmLabo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pmLabo.Name = "pmLabo";
            this.pmLabo.Size = new System.Drawing.Size(215, 35);
            this.pmLabo.TabIndex = 2;
            this.pmLabo.Text = "Кол-во проверок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тест Ферма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 489);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тест Рабина-Миллера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 562);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тест теории делимости";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(904, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Время";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(503, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 35);
            this.label8.TabIndex = 7;
            this.label8.Text = "Вид Числа";
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(26, 128);
            this.numberTB.Margin = new System.Windows.Forms.Padding(5);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(471, 41);
            this.numberTB.TabIndex = 8;
            // 
            // bytes
            // 
            this.bytes.Location = new System.Drawing.Point(839, 153);
            this.bytes.Margin = new System.Windows.Forms.Padding(5);
            this.bytes.Name = "bytes";
            this.bytes.Size = new System.Drawing.Size(331, 41);
            this.bytes.TabIndex = 8;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(282, 206);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(215, 59);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Генерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(26, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundsTB
            // 
            this.roundsTB.Location = new System.Drawing.Point(545, 153);
            this.roundsTB.Margin = new System.Windows.Forms.Padding(5);
            this.roundsTB.Name = "roundsTB";
            this.roundsTB.Size = new System.Drawing.Size(275, 41);
            this.roundsTB.TabIndex = 8;
            // 
            // fermaViewTB
            // 
            this.fermaViewTB.Location = new System.Drawing.Point(415, 410);
            this.fermaViewTB.Name = "fermaViewTB";
            this.fermaViewTB.Size = new System.Drawing.Size(326, 41);
            this.fermaViewTB.TabIndex = 10;
            this.fermaViewTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fermaTimeTB
            // 
            this.fermaTimeTB.Location = new System.Drawing.Point(797, 410);
            this.fermaTimeTB.Name = "fermaTimeTB";
            this.fermaTimeTB.Size = new System.Drawing.Size(304, 41);
            this.fermaTimeTB.TabIndex = 10;
            // 
            // rabinViewTB
            // 
            this.rabinViewTB.Location = new System.Drawing.Point(415, 480);
            this.rabinViewTB.Name = "rabinViewTB";
            this.rabinViewTB.Size = new System.Drawing.Size(326, 41);
            this.rabinViewTB.TabIndex = 10;
            this.rabinViewTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rabinTimeTB
            // 
            this.rabinTimeTB.Location = new System.Drawing.Point(797, 483);
            this.rabinTimeTB.Name = "rabinTimeTB";
            this.rabinTimeTB.Size = new System.Drawing.Size(304, 41);
            this.rabinTimeTB.TabIndex = 10;
            // 
            // detViewTB
            // 
            this.detViewTB.Location = new System.Drawing.Point(415, 562);
            this.detViewTB.Name = "detViewTB";
            this.detViewTB.Size = new System.Drawing.Size(326, 41);
            this.detViewTB.TabIndex = 10;
            this.detViewTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detTimeTB
            // 
            this.detTimeTB.Location = new System.Drawing.Point(797, 565);
            this.detTimeTB.Name = "detTimeTB";
            this.detTimeTB.Size = new System.Drawing.Size(304, 41);
            this.detTimeTB.TabIndex = 10;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warning.ForeColor = System.Drawing.Color.Maroon;
            this.warning.Location = new System.Drawing.Point(42, 627);
            this.warning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 35);
            this.warning.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 748);
            this.Controls.Add(this.detTimeTB);
            this.Controls.Add(this.rabinTimeTB);
            this.Controls.Add(this.fermaTimeTB);
            this.Controls.Add(this.detViewTB);
            this.Controls.Add(this.rabinViewTB);
            this.Controls.Add(this.fermaViewTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.bytes);
            this.Controls.Add(this.roundsTB);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.pmLabo);
            this.Controls.Add(this.bytesLabo);
            this.Controls.Add(this.number_labo);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label number_labo;
        private Label bytesLabo;
        private Label pmLabo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox numberTB;
        private TextBox bytes;
        private Button generateButton;
        private Button button1;
        private TextBox roundsTB;
        private TextBox fermaViewTB;
        private TextBox fermaTimeTB;
        private TextBox rabinViewTB;
        private TextBox rabinTimeTB;
        private TextBox detViewTB;
        private TextBox detTimeTB;
        private Label warning;
    }
}