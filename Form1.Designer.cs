
namespace CSC240_06_02_FiveColors2_bpc
{
    partial class FiveColors2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxSelectionLabel = new System.Windows.Forms.Label();
            this.UxBlueButton = new System.Windows.Forms.RadioButton();
            this.UxRedButton = new System.Windows.Forms.RadioButton();
            this.UxVioletBlueButton = new System.Windows.Forms.RadioButton();
            this.UxPinkButton = new System.Windows.Forms.RadioButton();
            this.UxGreenButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // UxSelectionLabel
            // 
            this.UxSelectionLabel.AutoSize = true;
            this.UxSelectionLabel.Font = new System.Drawing.Font("Broadway", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxSelectionLabel.Location = new System.Drawing.Point(25, 72);
            this.UxSelectionLabel.Name = "UxSelectionLabel";
            this.UxSelectionLabel.Size = new System.Drawing.Size(939, 60);
            this.UxSelectionLabel.TabIndex = 0;
            this.UxSelectionLabel.Text = "Please, help yourself to a color!";
            // 
            // UxBlueButton
            // 
            this.UxBlueButton.AutoSize = true;
            this.UxBlueButton.Font = new System.Drawing.Font("Castellar", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxBlueButton.Location = new System.Drawing.Point(164, 263);
            this.UxBlueButton.Name = "UxBlueButton";
            this.UxBlueButton.Size = new System.Drawing.Size(175, 56);
            this.UxBlueButton.TabIndex = 1;
            this.UxBlueButton.Text = "BLUE";
            this.UxBlueButton.UseVisualStyleBackColor = true;
            this.UxBlueButton.CheckedChanged += new System.EventHandler(this.UxBlueButton_CheckedChanged);
            // 
            // UxRedButton
            // 
            this.UxRedButton.AutoSize = true;
            this.UxRedButton.Font = new System.Drawing.Font("Castellar", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxRedButton.Location = new System.Drawing.Point(164, 335);
            this.UxRedButton.Name = "UxRedButton";
            this.UxRedButton.Size = new System.Drawing.Size(339, 56);
            this.UxRedButton.TabIndex = 2;
            this.UxRedButton.Text = "BLOOD RED";
            this.UxRedButton.UseVisualStyleBackColor = true;
            this.UxRedButton.CheckedChanged += new System.EventHandler(this.UxRedButton_CheckedChanged);
            // 
            // UxVioletBlueButton
            // 
            this.UxVioletBlueButton.AutoSize = true;
            this.UxVioletBlueButton.Font = new System.Drawing.Font("Castellar", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxVioletBlueButton.Location = new System.Drawing.Point(164, 414);
            this.UxVioletBlueButton.Name = "UxVioletBlueButton";
            this.UxVioletBlueButton.Size = new System.Drawing.Size(369, 56);
            this.UxVioletBlueButton.TabIndex = 3;
            this.UxVioletBlueButton.Text = "VIOLET BLUE";
            this.UxVioletBlueButton.UseVisualStyleBackColor = true;
            this.UxVioletBlueButton.CheckedChanged += new System.EventHandler(this.UxVioletBlueButton_CheckedChanged);
            // 
            // UxPinkButton
            // 
            this.UxPinkButton.AutoSize = true;
            this.UxPinkButton.Font = new System.Drawing.Font("Castellar", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxPinkButton.Location = new System.Drawing.Point(164, 491);
            this.UxPinkButton.Name = "UxPinkButton";
            this.UxPinkButton.Size = new System.Drawing.Size(175, 56);
            this.UxPinkButton.TabIndex = 4;
            this.UxPinkButton.Text = "PINK";
            this.UxPinkButton.UseVisualStyleBackColor = true;
            this.UxPinkButton.CheckedChanged += new System.EventHandler(this.UxPinkButton_CheckedChanged);
            // 
            // UxGreenButton
            // 
            this.UxGreenButton.AutoSize = true;
            this.UxGreenButton.Font = new System.Drawing.Font("Castellar", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxGreenButton.Location = new System.Drawing.Point(164, 564);
            this.UxGreenButton.Name = "UxGreenButton";
            this.UxGreenButton.Size = new System.Drawing.Size(409, 56);
            this.UxGreenButton.TabIndex = 5;
            this.UxGreenButton.Text = "FOREST GREEN";
            this.UxGreenButton.UseVisualStyleBackColor = true;
            this.UxGreenButton.CheckedChanged += new System.EventHandler(this.UxGreenButton_CheckedChanged);
            // 
            // FiveColors2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 886);
            this.Controls.Add(this.UxGreenButton);
            this.Controls.Add(this.UxPinkButton);
            this.Controls.Add(this.UxVioletBlueButton);
            this.Controls.Add(this.UxRedButton);
            this.Controls.Add(this.UxBlueButton);
            this.Controls.Add(this.UxSelectionLabel);
            this.Name = "FiveColors2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxSelectionLabel;
        private System.Windows.Forms.RadioButton UxBlueButton;
        private System.Windows.Forms.RadioButton UxRedButton;
        private System.Windows.Forms.RadioButton UxVioletBlueButton;
        private System.Windows.Forms.RadioButton UxPinkButton;
        private System.Windows.Forms.RadioButton UxGreenButton;
        
    }
}

