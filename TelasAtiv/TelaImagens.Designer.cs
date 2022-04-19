
namespace TelasAtiv
{
    partial class TelaImagens
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.PictureBox();
            this.pnl2 = new System.Windows.Forms.PictureBox();
            this.pnl1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(99, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Botão 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pnl3);
            this.panel1.Controls.Add(this.pnl2);
            this.panel1.Controls.Add(this.pnl1);
            this.panel1.Location = new System.Drawing.Point(23, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 223);
            this.panel1.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Location = new System.Drawing.Point(541, 45);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(159, 122);
            this.pnl3.TabIndex = 2;
            this.pnl3.TabStop = false;
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Location = new System.Drawing.Point(293, 45);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(173, 122);
            this.pnl2.TabIndex = 1;
            this.pnl2.TabStop = false;
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Location = new System.Drawing.Point(49, 45);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(175, 122);
            this.pnl1.TabIndex = 0;
            this.pnl1.TabStop = false;
            this.pnl1.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(355, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Botão 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(627, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Botão 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TelaImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "TelaImagens";
            this.Text = "TelaImagens";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pnl3;
        private System.Windows.Forms.PictureBox pnl2;
        private System.Windows.Forms.PictureBox pnl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}