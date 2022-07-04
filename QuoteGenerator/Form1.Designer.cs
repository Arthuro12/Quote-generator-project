
namespace QuoteGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.myInformationTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientInformationTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neuer Voranschlag";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // myInformationTb
            // 
            this.myInformationTb.Location = new System.Drawing.Point(87, 88);
            this.myInformationTb.Multiline = true;
            this.myInformationTb.Name = "myInformationTb";
            this.myInformationTb.Size = new System.Drawing.Size(166, 68);
            this.myInformationTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meine Kontaktdaten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kundendaten";
            // 
            // clientInformationTb
            // 
            this.clientInformationTb.Location = new System.Drawing.Point(551, 88);
            this.clientInformationTb.Multiline = true;
            this.clientInformationTb.Name = "clientInformationTb";
            this.clientInformationTb.Size = new System.Drawing.Size(166, 68);
            this.clientInformationTb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titel des Voranschlags";
            // 
            // titleTb
            // 
            this.titleTb.Location = new System.Drawing.Point(87, 207);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(504, 23);
            this.titleTb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Produktname";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(87, 281);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(166, 23);
            this.nameTb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Menge";
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(305, 281);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(178, 23);
            this.priceTb.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Preis";
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(531, 281);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(186, 23);
            this.quantityTb.TabIndex = 11;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(256, 336);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(275, 50);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "Voranschlag generien";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientInformationTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myInformationTb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quote Generator v 1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myInformationTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientInformationTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Button generateBtn;
    }
}

