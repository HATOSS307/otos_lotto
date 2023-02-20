namespace otoslotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.talalt = new System.Windows.Forms.Label();
            this.megjatszott = new System.Windows.Forms.Label();
            this.nyeroszamok = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // talalt
            // 
            this.talalt.AutoSize = true;
            this.talalt.ForeColor = System.Drawing.Color.Red;
            this.talalt.Location = new System.Drawing.Point(402, 401);
            this.talalt.Name = "talalt";
            this.talalt.Size = new System.Drawing.Size(51, 13);
            this.talalt.TabIndex = 0;
            this.talalt.Text = "Találat ->";
            // 
            // megjatszott
            // 
            this.megjatszott.AutoSize = true;
            this.megjatszott.Location = new System.Drawing.Point(402, 375);
            this.megjatszott.Name = "megjatszott";
            this.megjatszott.Size = new System.Drawing.Size(73, 13);
            this.megjatszott.TabIndex = 1;
            this.megjatszott.Text = "Megjátszott ->";
            // 
            // nyeroszamok
            // 
            this.nyeroszamok.AutoSize = true;
            this.nyeroszamok.ForeColor = System.Drawing.Color.Green;
            this.nyeroszamok.Location = new System.Drawing.Point(402, 350);
            this.nyeroszamok.Name = "nyeroszamok";
            this.nyeroszamok.Size = new System.Drawing.Size(83, 13);
            this.nyeroszamok.TabIndex = 2;
            this.nyeroszamok.Text = "Nyerőszámok ->";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(210, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sorsolás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 322);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nyeroszamok);
            this.Controls.Add(this.megjatszott);
            this.Controls.Add(this.talalt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label talalt;
        private System.Windows.Forms.Label megjatszott;
        private System.Windows.Forms.Label nyeroszamok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

