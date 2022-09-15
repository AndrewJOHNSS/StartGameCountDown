namespace StartGameCountDown
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
            this.StartGame = new System.Windows.Forms.Button();
            this.CountDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Black;
            this.StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.StartGame.FlatAppearance.BorderSize = 4;
            this.StartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.Lime;
            this.StartGame.Location = new System.Drawing.Point(200, 206);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(166, 65);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountDown
            // 
            this.CountDown.BackColor = System.Drawing.Color.Transparent;
            this.CountDown.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown.ForeColor = System.Drawing.Color.White;
            this.CountDown.Location = new System.Drawing.Point(200, 110);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(166, 65);
            this.CountDown.TabIndex = 1;
            this.CountDown.Text = "3";
            this.CountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.StartGame);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label CountDown;
    }
}

