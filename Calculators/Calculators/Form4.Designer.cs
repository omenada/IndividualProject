namespace Calculators
{
    partial class Form4
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.rdPoundsKls = new System.Windows.Forms.RadioButton();
            this.rdKilosPound = new System.Windows.Forms.RadioButton();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(360, 188);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Converted Value :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insert your value :";
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(111, 152);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.ReadOnly = true;
            this.txtConverted.Size = new System.Drawing.Size(218, 20);
            this.txtConverted.TabIndex = 10;
            // 
            // rdPoundsKls
            // 
            this.rdPoundsKls.AutoSize = true;
            this.rdPoundsKls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPoundsKls.Location = new System.Drawing.Point(252, 77);
            this.rdPoundsKls.Name = "rdPoundsKls";
            this.rdPoundsKls.Size = new System.Drawing.Size(110, 19);
            this.rdPoundsKls.TabIndex = 9;
            this.rdPoundsKls.TabStop = true;
            this.rdPoundsKls.Text = "Pounds to Kilos";
            this.rdPoundsKls.UseVisualStyleBackColor = true;
            this.rdPoundsKls.CheckedChanged += new System.EventHandler(this.Convertion);
            // 
            // rdKilosPound
            // 
            this.rdKilosPound.AutoSize = true;
            this.rdKilosPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKilosPound.Location = new System.Drawing.Point(56, 77);
            this.rdKilosPound.Name = "rdKilosPound";
            this.rdKilosPound.Size = new System.Drawing.Size(110, 19);
            this.rdKilosPound.TabIndex = 8;
            this.rdKilosPound.TabStop = true;
            this.rdKilosPound.Text = "Kilos to Pounds";
            this.rdKilosPound.UseVisualStyleBackColor = true;
            this.rdKilosPound.CheckedChanged += new System.EventHandler(this.Convertion);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(102, 35);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(218, 20);
            this.txtinput.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 223);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.rdPoundsKls);
            this.Controls.Add(this.rdKilosPound);
            this.Controls.Add(this.txtinput);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Weight Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.RadioButton rdPoundsKls;
        private System.Windows.Forms.RadioButton rdKilosPound;
        private System.Windows.Forms.TextBox txtinput;
    }
}