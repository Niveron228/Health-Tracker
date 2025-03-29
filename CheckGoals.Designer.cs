namespace Project
{
    partial class CheckGoals
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblComplete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbComplete = new System.Windows.Forms.ProgressBar();
            this.chbDelete = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblComplete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComplete.Location = new System.Drawing.Point(47, 508);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(133, 25);
            this.lblComplete.TabIndex = 1;
            this.lblComplete.Text = "Completed ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goals";
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBack.Location = new System.Drawing.Point(17, 601);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(521, 50);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "* Click on goal in table to check how close you are to this goal";
            // 
            // pbComplete
            // 
            this.pbComplete.Location = new System.Drawing.Point(266, 508);
            this.pbComplete.Name = "pbComplete";
            this.pbComplete.Size = new System.Drawing.Size(272, 23);
            this.pbComplete.TabIndex = 5;
            // 
            // chbDelete
            // 
            this.chbDelete.AutoSize = true;
            this.chbDelete.BackColor = System.Drawing.Color.Transparent;
            this.chbDelete.Location = new System.Drawing.Point(26, 517);
            this.chbDelete.Name = "chbDelete";
            this.chbDelete.Size = new System.Drawing.Size(15, 14);
            this.chbDelete.TabIndex = 6;
            this.chbDelete.UseVisualStyleBackColor = false;
            this.chbDelete.CheckedChanged += new System.EventHandler(this.chbDelete_CheckedChanged);
            // 
            // CheckGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 668);
            this.Controls.Add(this.chbDelete);
            this.Controls.Add(this.pbComplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CheckGoals";
            this.Text = "CheckGoals";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbComplete;
        private System.Windows.Forms.CheckBox chbDelete;
    }
}