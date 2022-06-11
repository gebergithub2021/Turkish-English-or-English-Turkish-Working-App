
namespace Englishworking.BookUI
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Reverser = new System.Windows.Forms.Button();
            this.lbl_Card = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_getTurkishWord = new System.Windows.Forms.Button();
            this.lbl_englishWord = new System.Windows.Forms.Label();
            this.btn_getEnglishWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_englishDescription = new System.Windows.Forms.TextBox();
            this.txt_englishWord = new System.Windows.Forms.TextBox();
            this.txt_turkishDescription = new System.Windows.Forms.TextBox();
            this.txt_turkishWord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(53, 113);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(192, 48);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Başla ve İlerle";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Reverser
            // 
            this.btn_Reverser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reverser.Location = new System.Drawing.Point(53, 254);
            this.btn_Reverser.Name = "btn_Reverser";
            this.btn_Reverser.Size = new System.Drawing.Size(128, 48);
            this.btn_Reverser.TabIndex = 0;
            this.btn_Reverser.Text = "Kartı Çevir";
            this.btn_Reverser.UseVisualStyleBackColor = true;
            this.btn_Reverser.Click += new System.EventHandler(this.btn_Reverser_Click);
            // 
            // lbl_Card
            // 
            this.lbl_Card.AutoSize = true;
            this.lbl_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Card.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Card.Location = new System.Drawing.Point(53, 180);
            this.lbl_Card.Name = "lbl_Card";
            this.lbl_Card.Size = new System.Drawing.Size(206, 55);
            this.lbl_Card.TabIndex = 1;
            this.lbl_Card.Text = "KELİME";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 407);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Start);
            this.tabPage1.Controls.Add(this.lbl_Card);
            this.tabPage1.Controls.Add(this.btn_Reverser);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TurkishEnglishWorking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bu bölümde eklediğiniz Türkçe \r\nkelimelerin İngilizce karşılılarını \r\nçalışacaksı" +
    "nız.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btn_getTurkishWord);
            this.tabPage2.Controls.Add(this.lbl_englishWord);
            this.tabPage2.Controls.Add(this.btn_getEnglishWord);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EnglishTurkishWorking";
            // 
            // btn_getTurkishWord
            // 
            this.btn_getTurkishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_getTurkishWord.Location = new System.Drawing.Point(61, 264);
            this.btn_getTurkishWord.Name = "btn_getTurkishWord";
            this.btn_getTurkishWord.Size = new System.Drawing.Size(157, 48);
            this.btn_getTurkishWord.TabIndex = 3;
            this.btn_getTurkishWord.Text = "Reverse Card";
            this.btn_getTurkishWord.UseVisualStyleBackColor = true;
            this.btn_getTurkishWord.Click += new System.EventHandler(this.btn_getTurkishWord_Click);
            // 
            // lbl_englishWord
            // 
            this.lbl_englishWord.AutoSize = true;
            this.lbl_englishWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_englishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_englishWord.ForeColor = System.Drawing.Color.Purple;
            this.lbl_englishWord.Location = new System.Drawing.Point(61, 179);
            this.lbl_englishWord.Name = "lbl_englishWord";
            this.lbl_englishWord.Size = new System.Drawing.Size(143, 55);
            this.lbl_englishWord.TabIndex = 2;
            this.lbl_englishWord.Text = "Word";
            // 
            // btn_getEnglishWord
            // 
            this.btn_getEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_getEnglishWord.ForeColor = System.Drawing.Color.Black;
            this.btn_getEnglishWord.Location = new System.Drawing.Point(61, 110);
            this.btn_getEnglishWord.Name = "btn_getEnglishWord";
            this.btn_getEnglishWord.Size = new System.Drawing.Size(206, 48);
            this.btn_getEnglishWord.TabIndex = 1;
            this.btn_getEnglishWord.Text = "Start and Continue";
            this.btn_getEnglishWord.UseVisualStyleBackColor = true;
            this.btn_getEnglishWord.Click += new System.EventHandler(this.btn_getEnglishWord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bu bölümde eklediğiniz İngilizce \r\nkelimelerin Türkçe karşılılarını\r\nçalışacaksın" +
    "ız.";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txt_englishDescription);
            this.tabPage3.Controls.Add(this.txt_englishWord);
            this.tabPage3.Controls.Add(this.txt_turkishDescription);
            this.tabPage3.Controls.Add(this.txt_turkishWord);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(331, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AddWord";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(20, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kelime Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_englishDescription
            // 
            this.txt_englishDescription.Location = new System.Drawing.Point(184, 247);
            this.txt_englishDescription.Name = "txt_englishDescription";
            this.txt_englishDescription.Size = new System.Drawing.Size(100, 23);
            this.txt_englishDescription.TabIndex = 9;
            // 
            // txt_englishWord
            // 
            this.txt_englishWord.Location = new System.Drawing.Point(184, 211);
            this.txt_englishWord.Name = "txt_englishWord";
            this.txt_englishWord.Size = new System.Drawing.Size(100, 23);
            this.txt_englishWord.TabIndex = 8;
            // 
            // txt_turkishDescription
            // 
            this.txt_turkishDescription.Location = new System.Drawing.Point(184, 168);
            this.txt_turkishDescription.Name = "txt_turkishDescription";
            this.txt_turkishDescription.Size = new System.Drawing.Size(100, 23);
            this.txt_turkishDescription.TabIndex = 7;
            // 
            // txt_turkishWord
            // 
            this.txt_turkishWord.Location = new System.Drawing.Point(184, 133);
            this.txt_turkishWord.Name = "txt_turkishWord";
            this.txt_turkishWord.Size = new System.Drawing.Size(100, 23);
            this.txt_turkishWord.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description of EnglisWord";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(15, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "English Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kelimenin Açıklaması:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Türkçe Kelime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(46, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lütfen tüm alanları \r\nDOLDURUNUZ.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklemek istediğiniz kelime için \r\nistenen bilgiler aşağıdadır. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(359, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TurkishEnglishWorkingBookApp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Reverser;
        private System.Windows.Forms.Label lbl_Card;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getTurkishWord;
        private System.Windows.Forms.Label lbl_englishWord;
        private System.Windows.Forms.Button btn_getEnglishWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_englishDescription;
        private System.Windows.Forms.TextBox txt_englishWord;
        private System.Windows.Forms.TextBox txt_turkishDescription;
        private System.Windows.Forms.TextBox txt_turkishWord;
        private System.Windows.Forms.Button button1;
    }
}

