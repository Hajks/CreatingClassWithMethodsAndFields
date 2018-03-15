namespace CreatingClassWithMethodsAndFields
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
            this.bobLabel = new System.Windows.Forms.Label();
            this.joeLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.bobGivesButton = new System.Windows.Forms.Button();
            this.joeGivesButton = new System.Windows.Forms.Button();
            this.bankTakesButton = new System.Windows.Forms.Button();
            this.bankGivesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bobLabel
            // 
            this.bobLabel.AutoSize = true;
            this.bobLabel.Location = new System.Drawing.Point(37, 47);
            this.bobLabel.Name = "bobLabel";
            this.bobLabel.Size = new System.Drawing.Size(51, 20);
            this.bobLabel.TabIndex = 0;
            this.bobLabel.Text = "label1";
            // 
            // joeLabel
            // 
            this.joeLabel.AutoSize = true;
            this.joeLabel.Location = new System.Drawing.Point(37, 86);
            this.joeLabel.Name = "joeLabel";
            this.joeLabel.Size = new System.Drawing.Size(51, 20);
            this.joeLabel.TabIndex = 1;
            this.joeLabel.Text = "label2";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(37, 125);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(51, 20);
            this.bankLabel.TabIndex = 2;
            this.bankLabel.Text = "label3";
            // 
            // bobGivesButton
            // 
            this.bobGivesButton.Location = new System.Drawing.Point(102, 167);
            this.bobGivesButton.Name = "bobGivesButton";
            this.bobGivesButton.Size = new System.Drawing.Size(125, 55);
            this.bobGivesButton.TabIndex = 3;
            this.bobGivesButton.Text = "Bob daje 5 zł Joe";
            this.bobGivesButton.UseVisualStyleBackColor = true;
            this.bobGivesButton.Click += new System.EventHandler(this.bobGivesButton_Click);
            // 
            // joeGivesButton
            // 
            this.joeGivesButton.Location = new System.Drawing.Point(257, 167);
            this.joeGivesButton.Name = "joeGivesButton";
            this.joeGivesButton.Size = new System.Drawing.Size(125, 55);
            this.joeGivesButton.TabIndex = 4;
            this.joeGivesButton.Text = "Joe daje 5 zł Bobowi";
            this.joeGivesButton.UseVisualStyleBackColor = true;
            this.joeGivesButton.Click += new System.EventHandler(this.joeGivesButton_Click);
            // 
            // bankTakesButton
            // 
            this.bankTakesButton.Location = new System.Drawing.Point(102, 231);
            this.bankTakesButton.Name = "bankTakesButton";
            this.bankTakesButton.Size = new System.Drawing.Size(125, 55);
            this.bankTakesButton.TabIndex = 5;
            this.bankTakesButton.Text = "Bank zabiera po 10 zł";
            this.bankTakesButton.UseVisualStyleBackColor = true;
            this.bankTakesButton.Click += new System.EventHandler(this.bankTakesButton_Click);
            // 
            // bankGivesButton
            // 
            this.bankGivesButton.Location = new System.Drawing.Point(257, 231);
            this.bankGivesButton.Name = "bankGivesButton";
            this.bankGivesButton.Size = new System.Drawing.Size(125, 55);
            this.bankGivesButton.TabIndex = 6;
            this.bankGivesButton.Text = "Bank daje po 10 zł";
            this.bankGivesButton.UseVisualStyleBackColor = true;
            this.bankGivesButton.Click += new System.EventHandler(this.bankGivesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 315);
            this.Controls.Add(this.bankGivesButton);
            this.Controls.Add(this.bankTakesButton);
            this.Controls.Add(this.joeGivesButton);
            this.Controls.Add(this.bobGivesButton);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.joeLabel);
            this.Controls.Add(this.bobLabel);
            this.Name = "Form1";
            this.Text = "Panowie w banku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bobLabel;
        private System.Windows.Forms.Label joeLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Button bobGivesButton;
        private System.Windows.Forms.Button joeGivesButton;
        private System.Windows.Forms.Button bankTakesButton;
        private System.Windows.Forms.Button bankGivesButton;
    }
}

