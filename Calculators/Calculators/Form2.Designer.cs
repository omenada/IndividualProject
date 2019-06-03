namespace Calculators
{
    partial class Form2
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.rbMilestoKil = new System.Windows.Forms.RadioButton();
            this.rbKiltoMiles = new System.Windows.Forms.RadioButton();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(102, 40);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(218, 20);
            this.txtinput.TabIndex = 0;
          
            // 
            // rbMilestoKil
            // 
            this.rbMilestoKil.AutoSize = true;
            this.rbMilestoKil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMilestoKil.Location = new System.Drawing.Point(62, 82);
            this.rbMilestoKil.Name = "rbMilestoKil";
            this.rbMilestoKil.Size = new System.Drawing.Size(130, 19);
            this.rbMilestoKil.TabIndex = 1;
            this.rbMilestoKil.TabStop = true;
            this.rbMilestoKil.Text = "Miles to Kilometers";
            this.rbMilestoKil.UseVisualStyleBackColor = true;
            this.rbMilestoKil.CheckedChanged += new System.EventHandler(this.Convertion);
            // 
            // rbKiltoMiles
            // 
            this.rbKiltoMiles.AutoSize = true;
            this.rbKiltoMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKiltoMiles.Location = new System.Drawing.Point(258, 82);
            this.rbKiltoMiles.Name = "rbKiltoMiles";
            this.rbKiltoMiles.Size = new System.Drawing.Size(130, 19);
            this.rbKiltoMiles.TabIndex = 2;
            this.rbKiltoMiles.TabStop = true;
            this.rbKiltoMiles.Text = "Kilometers to Miles";
            this.rbKiltoMiles.UseVisualStyleBackColor = true;
            this.rbKiltoMiles.CheckedChanged += new System.EventHandler(this.Convertion);
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(104, 148);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.ReadOnly = true;
            this.txtConverted.Size = new System.Drawing.Size(218, 20);
            this.txtConverted.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert your value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Converted Value :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(354, 191);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 230);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.rbKiltoMiles);
            this.Controls.Add(this.rbMilestoKil);
            this.Controls.Add(this.txtinput);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.RadioButton rbMilestoKil;
        private System.Windows.Forms.RadioButton rbKiltoMiles;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}