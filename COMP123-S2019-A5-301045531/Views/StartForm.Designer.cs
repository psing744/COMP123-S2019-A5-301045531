namespace COMP123_S2019_A5_301045531.Views
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.startNewOrderButton = new System.Windows.Forms.Button();
            this.openSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.welcomePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(260, 23);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Order Your Computer Today!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startNewOrderButton
            // 
            this.startNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewOrderButton.Location = new System.Drawing.Point(50, 264);
            this.startNewOrderButton.Name = "startNewOrderButton";
            this.startNewOrderButton.Size = new System.Drawing.Size(184, 42);
            this.startNewOrderButton.TabIndex = 1;
            this.startNewOrderButton.Text = "Start a New Order";
            this.startNewOrderButton.UseVisualStyleBackColor = true;
            this.startNewOrderButton.Click += new System.EventHandler(this.startNewOrderButton_Click);
            // 
            // openSavedOrderButton
            // 
            this.openSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSavedOrderButton.Location = new System.Drawing.Point(50, 312);
            this.openSavedOrderButton.Name = "openSavedOrderButton";
            this.openSavedOrderButton.Size = new System.Drawing.Size(184, 42);
            this.openSavedOrderButton.TabIndex = 1;
            this.openSavedOrderButton.Text = "Open a Saved Order";
            this.openSavedOrderButton.UseVisualStyleBackColor = true;
            this.openSavedOrderButton.Click += new System.EventHandler(this.openSavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(50, 360);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 42);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.Location = new System.Drawing.Point(103, 103);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.welcomePictureBox.Size = new System.Drawing.Size(100, 50);
            this.welcomePictureBox.TabIndex = 2;
            this.welcomePictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.ControlBox = false;
            this.Controls.Add(this.welcomePictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.openSavedOrderButton);
            this.Controls.Add(this.startNewOrderButton);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to  Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button startNewOrderButton;
        private System.Windows.Forms.Button openSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox welcomePictureBox;
    }
}

