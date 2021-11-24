
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wyslijbtn = new System.Windows.Forms.Button();
            this.imieBox = new System.Windows.Forms.MaskedTextBox();
            this.nazwiskoBox = new System.Windows.Forms.MaskedTextBox();
            this.dataBox = new System.Windows.Forms.MaskedTextBox();
            this.peselBox = new System.Windows.Forms.MaskedTextBox();
            this.telBox = new System.Windows.Forms.MaskedTextBox();
            this.mailBox = new System.Windows.Forms.MaskedTextBox();
            this.errorlbl = new System.Windows.Forms.Label();
            this.danelbl = new System.Windows.Forms.Label();
            this.dane2lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imieerrorlbl = new System.Windows.Forms.Label();
            this.nazwiskoerrorlbl = new System.Windows.Forms.Label();
            this.dataerrorlbl = new System.Windows.Forms.Label();
            this.peselerrorlbl = new System.Windows.Forms.Label();
            this.telerrorlbl = new System.Windows.Forms.Label();
            this.mailerrorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wyslijbtn
            // 
            this.wyslijbtn.Location = new System.Drawing.Point(192, 399);
            this.wyslijbtn.Name = "wyslijbtn";
            this.wyslijbtn.Size = new System.Drawing.Size(115, 23);
            this.wyslijbtn.TabIndex = 0;
            this.wyslijbtn.Text = "Wyslij";
            this.wyslijbtn.UseVisualStyleBackColor = true;
            this.wyslijbtn.Click += new System.EventHandler(this.wyslijbtn_Click);
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(257, 64);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(100, 20);
            this.imieBox.TabIndex = 7;
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(257, 101);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoBox.TabIndex = 8;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(257, 139);
            this.dataBox.Mask = "00/00/0000";
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(100, 20);
            this.dataBox.TabIndex = 9;
            this.dataBox.ValidatingType = typeof(System.DateTime);
            // 
            // peselBox
            // 
            this.peselBox.Location = new System.Drawing.Point(257, 175);
            this.peselBox.Mask = "00000000000";
            this.peselBox.Name = "peselBox";
            this.peselBox.Size = new System.Drawing.Size(100, 20);
            this.peselBox.TabIndex = 10;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(257, 256);
            this.telBox.Mask = "(+00) 000-000-000";
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(100, 20);
            this.telBox.TabIndex = 11;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(257, 293);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(100, 20);
            this.mailBox.TabIndex = 12;
            // 
            // errorlbl
            // 
            this.errorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlbl.Location = new System.Drawing.Point(142, 373);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(215, 23);
            this.errorlbl.TabIndex = 13;
            this.errorlbl.Text = "Formularz nieprawidłowo wypełniony";
            this.errorlbl.Visible = false;
            // 
            // danelbl
            // 
            this.danelbl.Location = new System.Drawing.Point(98, 30);
            this.danelbl.Name = "danelbl";
            this.danelbl.Size = new System.Drawing.Size(100, 23);
            this.danelbl.TabIndex = 14;
            this.danelbl.Text = "Dane Podstawowe";
            // 
            // dane2lbl
            // 
            this.dane2lbl.Location = new System.Drawing.Point(98, 218);
            this.dane2lbl.Name = "dane2lbl";
            this.dane2lbl.Size = new System.Drawing.Size(100, 23);
            this.dane2lbl.TabIndex = 15;
            this.dane2lbl.Text = "Dane kontaktowe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PESEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Numer telefonu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "e-mail";
            // 
            // imieerrorlbl
            // 
            this.imieerrorlbl.AutoSize = true;
            this.imieerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.imieerrorlbl.Location = new System.Drawing.Point(157, 64);
            this.imieerrorlbl.Name = "imieerrorlbl";
            this.imieerrorlbl.Size = new System.Drawing.Size(11, 13);
            this.imieerrorlbl.TabIndex = 22;
            this.imieerrorlbl.Text = "*";
            this.imieerrorlbl.Visible = false;
            // 
            // nazwiskoerrorlbl
            // 
            this.nazwiskoerrorlbl.AutoSize = true;
            this.nazwiskoerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.nazwiskoerrorlbl.Location = new System.Drawing.Point(187, 104);
            this.nazwiskoerrorlbl.Name = "nazwiskoerrorlbl";
            this.nazwiskoerrorlbl.Size = new System.Drawing.Size(11, 13);
            this.nazwiskoerrorlbl.TabIndex = 23;
            this.nazwiskoerrorlbl.Text = "*";
            this.nazwiskoerrorlbl.Visible = false;
            // 
            // dataerrorlbl
            // 
            this.dataerrorlbl.AutoSize = true;
            this.dataerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.dataerrorlbl.Location = new System.Drawing.Point(219, 142);
            this.dataerrorlbl.Name = "dataerrorlbl";
            this.dataerrorlbl.Size = new System.Drawing.Size(11, 13);
            this.dataerrorlbl.TabIndex = 24;
            this.dataerrorlbl.Text = "*";
            this.dataerrorlbl.Visible = false;
            // 
            // peselerrorlbl
            // 
            this.peselerrorlbl.AutoSize = true;
            this.peselerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.peselerrorlbl.Location = new System.Drawing.Point(181, 178);
            this.peselerrorlbl.Name = "peselerrorlbl";
            this.peselerrorlbl.Size = new System.Drawing.Size(11, 13);
            this.peselerrorlbl.TabIndex = 25;
            this.peselerrorlbl.Text = "*";
            this.peselerrorlbl.Visible = false;
            // 
            // telerrorlbl
            // 
            this.telerrorlbl.AutoSize = true;
            this.telerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.telerrorlbl.Location = new System.Drawing.Point(219, 259);
            this.telerrorlbl.Name = "telerrorlbl";
            this.telerrorlbl.Size = new System.Drawing.Size(11, 13);
            this.telerrorlbl.TabIndex = 26;
            this.telerrorlbl.Text = "*";
            this.telerrorlbl.Visible = false;
            // 
            // mailerrorlbl
            // 
            this.mailerrorlbl.AutoSize = true;
            this.mailerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.mailerrorlbl.Location = new System.Drawing.Point(174, 296);
            this.mailerrorlbl.Name = "mailerrorlbl";
            this.mailerrorlbl.Size = new System.Drawing.Size(11, 13);
            this.mailerrorlbl.TabIndex = 27;
            this.mailerrorlbl.Text = "*";
            this.mailerrorlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 535);
            this.Controls.Add(this.mailerrorlbl);
            this.Controls.Add(this.telerrorlbl);
            this.Controls.Add(this.peselerrorlbl);
            this.Controls.Add(this.dataerrorlbl);
            this.Controls.Add(this.nazwiskoerrorlbl);
            this.Controls.Add(this.imieerrorlbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dane2lbl);
            this.Controls.Add(this.danelbl);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.peselBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.nazwiskoBox);
            this.Controls.Add(this.imieBox);
            this.Controls.Add(this.wyslijbtn);
            this.Name = "Form1";
            this.Text = "Formularz osobowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wyslijbtn;
        private System.Windows.Forms.MaskedTextBox imieBox;
        private System.Windows.Forms.MaskedTextBox nazwiskoBox;
        private System.Windows.Forms.MaskedTextBox dataBox;
        private System.Windows.Forms.MaskedTextBox peselBox;
        private System.Windows.Forms.MaskedTextBox telBox;
        private System.Windows.Forms.MaskedTextBox mailBox;
        private System.Windows.Forms.Label errorlbl;
        private System.Windows.Forms.Label danelbl;
        private System.Windows.Forms.Label dane2lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label imieerrorlbl;
        private System.Windows.Forms.Label nazwiskoerrorlbl;
        private System.Windows.Forms.Label dataerrorlbl;
        private System.Windows.Forms.Label peselerrorlbl;
        private System.Windows.Forms.Label telerrorlbl;
        private System.Windows.Forms.Label mailerrorlbl;
    }
}

