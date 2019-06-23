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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.gamelocBox = new System.Windows.Forms.TextBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.ogfbutton = new System.Windows.Forms.Button();
            this.fbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gamenameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(697, 108);
            this.listBox1.TabIndex = 0;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Gray;
            this.addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addbutton.FlatAppearance.BorderSize = 3;
            this.addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(321, 365);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(142, 50);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gamelocBox
            // 
            this.gamelocBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gamelocBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamelocBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamelocBox.ForeColor = System.Drawing.Color.White;
            this.gamelocBox.Location = new System.Drawing.Point(191, 261);
            this.gamelocBox.Name = "gamelocBox";
            this.gamelocBox.Size = new System.Drawing.Size(399, 24);
            this.gamelocBox.TabIndex = 2;
            this.gamelocBox.Text = "Game Location";
            // 
            // removebutton
            // 
            this.removebutton.BackColor = System.Drawing.Color.Gray;
            this.removebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removebutton.FlatAppearance.BorderSize = 3;
            this.removebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.removebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removebutton.ForeColor = System.Drawing.Color.White;
            this.removebutton.Location = new System.Drawing.Point(37, 365);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(142, 50);
            this.removebutton.TabIndex = 3;
            this.removebutton.Text = "REMOVE";
            this.removebutton.UseVisualStyleBackColor = false;
            this.removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // ogfbutton
            // 
            this.ogfbutton.BackColor = System.Drawing.Color.Gray;
            this.ogfbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogfbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ogfbutton.FlatAppearance.BorderSize = 3;
            this.ogfbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ogfbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ogfbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ogfbutton.ForeColor = System.Drawing.Color.White;
            this.ogfbutton.Location = new System.Drawing.Point(625, 365);
            this.ogfbutton.Name = "ogfbutton";
            this.ogfbutton.Size = new System.Drawing.Size(142, 50);
            this.ogfbutton.TabIndex = 4;
            this.ogfbutton.Text = "OPEN GAME FOLDER";
            this.ogfbutton.UseVisualStyleBackColor = false;
            this.ogfbutton.Click += new System.EventHandler(this.Ogfbutton_Click);
            // 
            // fbutton
            // 
            this.fbutton.BackColor = System.Drawing.Color.Silver;
            this.fbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fbutton.FlatAppearance.BorderSize = 2;
            this.fbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbutton.Location = new System.Drawing.Point(596, 261);
            this.fbutton.Name = "fbutton";
            this.fbutton.Size = new System.Drawing.Size(36, 31);
            this.fbutton.TabIndex = 5;
            this.fbutton.Text = "...";
            this.fbutton.UseVisualStyleBackColor = false;
            this.fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // gamenameBox
            // 
            this.gamenameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gamenameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamenameBox.ForeColor = System.Drawing.Color.White;
            this.gamenameBox.Location = new System.Drawing.Point(191, 213);
            this.gamenameBox.Name = "gamenameBox";
            this.gamenameBox.Size = new System.Drawing.Size(399, 24);
            this.gamenameBox.TabIndex = 7;
            this.gamenameBox.Text = "Game Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(191, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 4);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(191, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 4);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(37, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 131);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(2, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(56, 47);
            this.panel4.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(757, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamenameBox);
            this.Controls.Add(this.fbutton);
            this.Controls.Add(this.ogfbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.gamelocBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox gamenameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}

