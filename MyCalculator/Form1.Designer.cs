
namespace MyCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.jam = new System.Windows.Forms.Button();
            this.menha = new System.Windows.Forms.Button();
            this.zarb = new System.Windows.Forms.Button();
            this.taghsim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second number :";
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(36, 52);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(354, 23);
            this.numeric1.TabIndex = 2;
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(36, 104);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(354, 23);
            this.numeric2.TabIndex = 3;
            // 
            // jam
            // 
            this.jam.Location = new System.Drawing.Point(36, 157);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(75, 38);
            this.jam.TabIndex = 4;
            this.jam.Text = "+";
            this.jam.UseVisualStyleBackColor = true;
            this.jam.Click += new System.EventHandler(this.jam_Click);
            // 
            // menha
            // 
            this.menha.Location = new System.Drawing.Point(126, 157);
            this.menha.Name = "menha";
            this.menha.Size = new System.Drawing.Size(75, 38);
            this.menha.TabIndex = 5;
            this.menha.Text = "-";
            this.menha.UseVisualStyleBackColor = true;
            this.menha.Click += new System.EventHandler(this.menha_Click);
            // 
            // zarb
            // 
            this.zarb.Location = new System.Drawing.Point(226, 157);
            this.zarb.Name = "zarb";
            this.zarb.Size = new System.Drawing.Size(75, 38);
            this.zarb.TabIndex = 6;
            this.zarb.Text = "*";
            this.zarb.UseVisualStyleBackColor = true;
            this.zarb.Click += new System.EventHandler(this.zarb_Click);
            // 
            // taghsim
            // 
            this.taghsim.Location = new System.Drawing.Point(315, 157);
            this.taghsim.Name = "taghsim";
            this.taghsim.Size = new System.Drawing.Size(75, 38);
            this.taghsim.TabIndex = 7;
            this.taghsim.Text = "/";
            this.taghsim.UseVisualStyleBackColor = true;
            this.taghsim.Click += new System.EventHandler(this.taghsim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 227);
            this.Controls.Add(this.taghsim);
            this.Controls.Add(this.zarb);
            this.Controls.Add(this.menha);
            this.Controls.Add(this.jam);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.Button jam;
        private System.Windows.Forms.Button menha;
        private System.Windows.Forms.Button zarb;
        private System.Windows.Forms.Button taghsim;
    }
}

