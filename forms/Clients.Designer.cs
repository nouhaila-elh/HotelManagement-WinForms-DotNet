
namespace GestionHotel.forms
{
    partial class Clients
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
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.BoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxVille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxPays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxCodePostale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM         :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BoxNom
            // 
            this.BoxNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNom.Location = new System.Drawing.Point(131, 79);
            this.BoxNom.Multiline = true;
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(164, 29);
            this.BoxNom.TabIndex = 1;
            this.BoxNom.TabStop = false;
            this.BoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPrenom
            // 
            this.BoxPrenom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxPrenom.Location = new System.Drawing.Point(554, 83);
            this.BoxPrenom.Multiline = true;
            this.BoxPrenom.Name = "BoxPrenom";
            this.BoxPrenom.Size = new System.Drawing.Size(164, 29);
            this.BoxPrenom.TabIndex = 3;
            this.BoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRENOM                :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BoxVille
            // 
            this.BoxVille.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxVille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxVille.Location = new System.Drawing.Point(135, 223);
            this.BoxVille.Multiline = true;
            this.BoxVille.Name = "BoxVille";
            this.BoxVille.Size = new System.Drawing.Size(164, 29);
            this.BoxVille.TabIndex = 7;
            this.BoxVille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "VILLE          :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BoxAdresse
            // 
            this.BoxAdresse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxAdresse.Location = new System.Drawing.Point(131, 157);
            this.BoxAdresse.Multiline = true;
            this.BoxAdresse.Name = "BoxAdresse";
            this.BoxAdresse.Size = new System.Drawing.Size(164, 29);
            this.BoxAdresse.TabIndex = 5;
            this.BoxAdresse.TabStop = false;
            this.BoxAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADRESSE   :";
            // 
            // BoxTel
            // 
            this.BoxTel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxTel.Location = new System.Drawing.Point(554, 294);
            this.BoxTel.Multiline = true;
            this.BoxTel.Name = "BoxTel";
            this.BoxTel.Size = new System.Drawing.Size(164, 29);
            this.BoxTel.TabIndex = 13;
            this.BoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "TELEPHONE            :";
            // 
            // BoxPays
            // 
            this.BoxPays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxPays.Location = new System.Drawing.Point(554, 148);
            this.BoxPays.Multiline = true;
            this.BoxPays.Name = "BoxPays";
            this.BoxPays.Size = new System.Drawing.Size(164, 29);
            this.BoxPays.TabIndex = 11;
            this.BoxPays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "PAYS                        :";
            // 
            // BoxCodePostale
            // 
            this.BoxCodePostale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxCodePostale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxCodePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxCodePostale.Location = new System.Drawing.Point(554, 223);
            this.BoxCodePostale.Multiline = true;
            this.BoxCodePostale.Name = "BoxCodePostale";
            this.BoxCodePostale.Size = new System.Drawing.Size(164, 29);
            this.BoxCodePostale.TabIndex = 9;
            this.BoxCodePostale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxCodePostale.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "CODE POSTALE     :";
            // 
            // BoxEmail
            // 
            this.BoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxEmail.Location = new System.Drawing.Point(131, 294);
            this.BoxEmail.Multiline = true;
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(164, 29);
            this.BoxEmail.TabIndex = 15;
            this.BoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "E-MAIL       :";
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.Valider.FlatAppearance.BorderSize = 0;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Valider.Location = new System.Drawing.Point(272, 358);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(180, 39);
            this.Valider.TabIndex = 16;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.BoxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxPays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BoxCodePostale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BoxVille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNom);
            this.Controls.Add(this.label1);
            this.Name = "Clients";
            this.Text = "Enregistrer le Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.TextBox BoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxPays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BoxCodePostale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Valider;
    }
}