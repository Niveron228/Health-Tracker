namespace Project
{
    partial class Menu
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
            this.btShowProgress = new System.Windows.Forms.Button();
            this.btAddInfo = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Koufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Tracker";
            // 
            // btShowProgress
            // 
            this.btShowProgress.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btShowProgress.Location = new System.Drawing.Point(64, 247);
            this.btShowProgress.Name = "btShowProgress";
            this.btShowProgress.Size = new System.Drawing.Size(346, 52);
            this.btShowProgress.TabIndex = 1;
            this.btShowProgress.Text = "Show progress";
            this.btShowProgress.UseVisualStyleBackColor = true;
            this.btShowProgress.Click += new System.EventHandler(this.btShowProgress_Click);
            // 
            // btAddInfo
            // 
            this.btAddInfo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAddInfo.Location = new System.Drawing.Point(64, 127);
            this.btAddInfo.Name = "btAddInfo";
            this.btAddInfo.Size = new System.Drawing.Size(346, 50);
            this.btAddInfo.TabIndex = 2;
            this.btAddInfo.Text = "Add info";
            this.btAddInfo.UseVisualStyleBackColor = true;
            this.btAddInfo.Click += new System.EventHandler(this.btAddInfo_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btExit.Location = new System.Drawing.Point(64, 376);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(346, 51);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(479, 489);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAddInfo);
            this.Controls.Add(this.btShowProgress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowProgress;
        private System.Windows.Forms.Button btAddInfo;
        private System.Windows.Forms.Button btExit;
    }
}