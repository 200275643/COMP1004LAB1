namespace COMP1004LAB1
{
    partial class StartForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(132, 70);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 27);
            this.MessageLabel.TabIndex = 0;
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(40, 228);
            this.ClickMeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(157, 42);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            this.ClickMeButton.MouseEnter += new System.EventHandler(this.ClickMeButton_MouseEnter);
            this.ClickMeButton.MouseLeave += new System.EventHandler(this.ClickMeButton_MouseLeave);
            this.ClickMeButton.MouseHover += new System.EventHandler(this.ClickMeButton_MouseHover);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(224, 228);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(157, 42);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 320);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.MessageLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

