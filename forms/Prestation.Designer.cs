
namespace GestionHotel.forms
{
    partial class Prestation
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
            this.hotelbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelbox
            // 
            this.hotelbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hotelbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotelbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelbox.FormattingEnabled = true;
            this.hotelbox.Items.AddRange(new object[] {
            "",
            "Service de chambre ",
            "Transport",
            "Guide troustique",
            "SPA",
            "Petit déjeuné"});
            this.hotelbox.Location = new System.Drawing.Point(244, 111);
            this.hotelbox.Name = "hotelbox";
            this.hotelbox.Size = new System.Drawing.Size(224, 28);
            this.hotelbox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Préstation                           :";
            // 
            // BoxNom
            // 
            this.BoxNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNom.Location = new System.Drawing.Point(245, 52);
            this.BoxNom.Multiline = true;
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(224, 29);
            this.BoxNom.TabIndex = 39;
            this.BoxNom.TabStop = false;
            this.BoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNom.TextChanged += new System.EventHandler(this.BoxNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Numéro de réservation   :";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(245, 284);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(224, 100);
            this.textDescription.TabIndex = 48;
            this.textDescription.TabStop = false;
            this.textDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Description                        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "MAD";
            // 
            // dateDebut
            // 
            this.dateDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.CustomFormat = "dd-MM-yyyy";
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(244, 166);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(224, 26);
            this.dateDebut.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Date                                     :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(244, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 29);
            this.textBox1.TabIndex = 50;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Prix                                       :";
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(571, 381);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(83, 39);
            this.Valider.TabIndex = 54;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(474, 124);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(240, 150);
            this.grd.TabIndex = 55;
            // 
            // Prestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 442);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hotelbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BoxNom);
            this.Controls.Add(this.label1);
            this.Name = "Prestation";
            this.Text = "Préstation";
            this.Load += new System.EventHandler(this.Prestation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox hotelbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.DataGridView grd;
    }
}