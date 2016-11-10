namespace Adventure_Game_Summative_Actual
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
            this.beginButton = new System.Windows.Forms.Button();
            this.thirdChoiceLabel = new System.Windows.Forms.Label();
            this.secondChoiceLabel = new System.Windows.Forms.Label();
            this.firstChoiceLabel = new System.Windows.Forms.Label();
            this.firstButtonLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yellowButtonPicture = new System.Windows.Forms.PictureBox();
            this.blueButtonPicture = new System.Windows.Forms.PictureBox();
            this.redButtonPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButtonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(294, 108);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(59, 23);
            this.beginButton.TabIndex = 21;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // thirdChoiceLabel
            // 
            this.thirdChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.thirdChoiceLabel.Location = new System.Drawing.Point(78, 323);
            this.thirdChoiceLabel.Name = "thirdChoiceLabel";
            this.thirdChoiceLabel.Size = new System.Drawing.Size(275, 44);
            this.thirdChoiceLabel.TabIndex = 20;
            // 
            // secondChoiceLabel
            // 
            this.secondChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.secondChoiceLabel.Location = new System.Drawing.Point(83, 269);
            this.secondChoiceLabel.Name = "secondChoiceLabel";
            this.secondChoiceLabel.Size = new System.Drawing.Size(275, 51);
            this.secondChoiceLabel.TabIndex = 19;
            // 
            // firstChoiceLabel
            // 
            this.firstChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.firstChoiceLabel.Location = new System.Drawing.Point(83, 221);
            this.firstChoiceLabel.Name = "firstChoiceLabel";
            this.firstChoiceLabel.Size = new System.Drawing.Size(275, 49);
            this.firstChoiceLabel.TabIndex = 17;
            // 
            // firstButtonLabel
            // 
            this.firstButtonLabel.AutoSize = true;
            this.firstButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButtonLabel.ForeColor = System.Drawing.Color.White;
            this.firstButtonLabel.Location = new System.Drawing.Point(10, 108);
            this.firstButtonLabel.Name = "firstButtonLabel";
            this.firstButtonLabel.Size = new System.Drawing.Size(170, 18);
            this.firstButtonLabel.TabIndex = 14;
            this.firstButtonLabel.Text = "Click the button to begin.";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(294, 9);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(60, 20);
            this.nameInput.TabIndex = 13;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(10, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(344, 114);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Welcome adventurer, what is your name? ";
            // 
            // yellowButtonPicture
            // 
            this.yellowButtonPicture.BackColor = System.Drawing.Color.Black;
            this.yellowButtonPicture.Image = global::Adventure_Game_Summative_Actual.Properties.Resources.yellow_50x50;
            this.yellowButtonPicture.Location = new System.Drawing.Point(13, 319);
            this.yellowButtonPicture.Name = "yellowButtonPicture";
            this.yellowButtonPicture.Size = new System.Drawing.Size(59, 48);
            this.yellowButtonPicture.TabIndex = 18;
            this.yellowButtonPicture.TabStop = false;
            // 
            // blueButtonPicture
            // 
            this.blueButtonPicture.BackColor = System.Drawing.Color.Black;
            this.blueButtonPicture.Image = global::Adventure_Game_Summative_Actual.Properties.Resources.blue_50x50;
            this.blueButtonPicture.Location = new System.Drawing.Point(13, 271);
            this.blueButtonPicture.Name = "blueButtonPicture";
            this.blueButtonPicture.Size = new System.Drawing.Size(59, 49);
            this.blueButtonPicture.TabIndex = 16;
            this.blueButtonPicture.TabStop = false;
            // 
            // redButtonPicture
            // 
            this.redButtonPicture.BackColor = System.Drawing.Color.Black;
            this.redButtonPicture.Image = global::Adventure_Game_Summative_Actual.Properties.Resources.red_50x50;
            this.redButtonPicture.InitialImage = global::Adventure_Game_Summative_Actual.Properties.Resources.red_50x50;
            this.redButtonPicture.Location = new System.Drawing.Point(13, 221);
            this.redButtonPicture.Name = "redButtonPicture";
            this.redButtonPicture.Size = new System.Drawing.Size(59, 49);
            this.redButtonPicture.TabIndex = 15;
            this.redButtonPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 376);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.thirdChoiceLabel);
            this.Controls.Add(this.secondChoiceLabel);
            this.Controls.Add(this.yellowButtonPicture);
            this.Controls.Add(this.firstChoiceLabel);
            this.Controls.Add(this.blueButtonPicture);
            this.Controls.Add(this.redButtonPicture);
            this.Controls.Add(this.firstButtonLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.yellowButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButtonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label thirdChoiceLabel;
        private System.Windows.Forms.Label secondChoiceLabel;
        private System.Windows.Forms.PictureBox yellowButtonPicture;
        private System.Windows.Forms.Label firstChoiceLabel;
        private System.Windows.Forms.PictureBox blueButtonPicture;
        private System.Windows.Forms.PictureBox redButtonPicture;
        private System.Windows.Forms.Label firstButtonLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label titleLabel;
    }
}

