namespace CSGOSS
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.kLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.kNum = new System.Windows.Forms.Label();
            this.dNum = new System.Windows.Forms.Label();
            this.aNum = new System.Windows.Forms.Label();
            this.kThisRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Font = new System.Drawing.Font("Headline One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kLabel.ForeColor = System.Drawing.Color.Silver;
            this.kLabel.Location = new System.Drawing.Point(1, 5);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(24, 29);
            this.kLabel.TabIndex = 4;
            this.kLabel.Text = "K";
            this.kLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Headline One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.Color.Silver;
            this.aLabel.Location = new System.Drawing.Point(180, 5);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(26, 29);
            this.aLabel.TabIndex = 8;
            this.aLabel.Text = "A";
            this.aLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Headline One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.Color.Silver;
            this.dLabel.Location = new System.Drawing.Point(111, 5);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(24, 29);
            this.dLabel.TabIndex = 9;
            this.dLabel.Text = "D";
            this.dLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // kNum
            // 
            this.kNum.AutoSize = true;
            this.kNum.Font = new System.Drawing.Font("Headline One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kNum.Location = new System.Drawing.Point(59, 5);
            this.kNum.Name = "kNum";
            this.kNum.Size = new System.Drawing.Size(30, 37);
            this.kNum.TabIndex = 10;
            this.kNum.Text = "0";
            this.kNum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // dNum
            // 
            this.dNum.AutoSize = true;
            this.dNum.Font = new System.Drawing.Font("Headline One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dNum.Location = new System.Drawing.Point(127, 5);
            this.dNum.Name = "dNum";
            this.dNum.Size = new System.Drawing.Size(30, 37);
            this.dNum.TabIndex = 11;
            this.dNum.Text = "0";
            this.dNum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // aNum
            // 
            this.aNum.AutoSize = true;
            this.aNum.Font = new System.Drawing.Font("Headline One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aNum.Location = new System.Drawing.Point(198, 5);
            this.aNum.Name = "aNum";
            this.aNum.Size = new System.Drawing.Size(30, 37);
            this.aNum.TabIndex = 12;
            this.aNum.Text = "0";
            this.aNum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // kThisRound
            // 
            this.kThisRound.AutoSize = true;
            this.kThisRound.Font = new System.Drawing.Font("Headline One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kThisRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kThisRound.Location = new System.Drawing.Point(17, 5);
            this.kThisRound.Name = "kThisRound";
            this.kThisRound.Size = new System.Drawing.Size(47, 37);
            this.kThisRound.TabIndex = 13;
            this.kThisRound.Text = "0 /";
            this.kThisRound.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(240, 43);
            this.Controls.Add(this.kThisRound);
            this.Controls.Add(this.aNum);
            this.Controls.Add(this.dNum);
            this.Controls.Add(this.kNum);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.kLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream Scoreboard";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UI_RClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label kNum;
        private System.Windows.Forms.Label dNum;
        private System.Windows.Forms.Label aNum;
        private System.Windows.Forms.Label kThisRound;
    }
}

