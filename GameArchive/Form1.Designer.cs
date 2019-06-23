namespace GameArchive
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.gamelocBox = new System.Windows.Forms.TextBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.ogfbutton = new System.Windows.Forms.Button();
            this.fbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamenameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(476, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 420);
            this.listBox1.TabIndex = 0;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(12, 172);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(142, 50);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gamelocBox
            // 
            this.gamelocBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamelocBox.Location = new System.Drawing.Point(12, 118);
            this.gamelocBox.Name = "gamelocBox";
            this.gamelocBox.Size = new System.Drawing.Size(399, 31);
            this.gamelocBox.TabIndex = 2;
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(12, 228);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(142, 50);
            this.removebutton.TabIndex = 3;
            this.removebutton.Text = "REMOVE";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // ogfbutton
            // 
            this.ogfbutton.Location = new System.Drawing.Point(12, 284);
            this.ogfbutton.Name = "ogfbutton";
            this.ogfbutton.Size = new System.Drawing.Size(142, 50);
            this.ogfbutton.TabIndex = 4;
            this.ogfbutton.Text = "OPEN GAME FOLDER";
            this.ogfbutton.UseVisualStyleBackColor = true;
            this.ogfbutton.Click += new System.EventHandler(this.Ogfbutton_Click);
            // 
            // fbutton
            // 
            this.fbutton.Location = new System.Drawing.Point(417, 118);
            this.fbutton.Name = "fbutton";
            this.fbutton.Size = new System.Drawing.Size(36, 31);
            this.fbutton.TabIndex = 5;
            this.fbutton.Text = "...";
            this.fbutton.UseVisualStyleBackColor = true;
            this.fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game Name:";
            // 
            // gamenameBox
            // 
            this.gamenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamenameBox.Location = new System.Drawing.Point(12, 61);
            this.gamenameBox.Name = "gamenameBox";
            this.gamenameBox.Size = new System.Drawing.Size(399, 31);
            this.gamenameBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamenameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbutton);
            this.Controls.Add(this.ogfbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.gamelocBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "GameArchive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox gamelocBox;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button ogfbutton;
        private System.Windows.Forms.Button fbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gamenameBox;
    }
}

