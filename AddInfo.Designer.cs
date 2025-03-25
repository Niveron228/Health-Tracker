namespace Project
{
    partial class AddInfo
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
            this.btsend = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.tbweight = new System.Windows.Forms.TextBox();
            this.cbexercise = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblmode = new System.Windows.Forms.Label();
            this.tbinfo04 = new System.Windows.Forms.TextBox();
            this.tbinfo03 = new System.Windows.Forms.TextBox();
            this.lblmodeinfo04 = new System.Windows.Forms.Label();
            this.lblmodeinfo03 = new System.Windows.Forms.Label();
            this.tbinfo02 = new System.Windows.Forms.TextBox();
            this.tbinfo01 = new System.Windows.Forms.TextBox();
            this.lblmodeinfo02 = new System.Windows.Forms.Label();
            this.lblmodeinfo01 = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsend
            // 
            this.btsend.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btsend.Location = new System.Drawing.Point(357, 307);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(178, 38);
            this.btsend.TabIndex = 0;
            this.btsend.Text = "Save Data";
            this.btsend.UseVisualStyleBackColor = true;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbldate.ForeColor = System.Drawing.Color.Black;
            this.lbldate.Location = new System.Drawing.Point(54, 253);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(75, 25);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date:";
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.BackColor = System.Drawing.Color.Transparent;
            this.lblweight.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblweight.ForeColor = System.Drawing.Color.Black;
            this.lblweight.Location = new System.Drawing.Point(683, 209);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(105, 25);
            this.lblweight.TabIndex = 3;
            this.lblweight.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(425, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Exercise";
            // 
            // tbdate
            // 
            this.tbdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbdate.ForeColor = System.Drawing.Color.Black;
            this.tbdate.Location = new System.Drawing.Point(194, 253);
            this.tbdate.Multiline = true;
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(130, 25);
            this.tbdate.TabIndex = 7;
            // 
            // tbweight
            // 
            this.tbweight.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbweight.ForeColor = System.Drawing.Color.Black;
            this.tbweight.Location = new System.Drawing.Point(724, 269);
            this.tbweight.Multiline = true;
            this.tbweight.Name = "tbweight";
            this.tbweight.Size = new System.Drawing.Size(130, 25);
            this.tbweight.TabIndex = 9;
            // 
            // cbexercise
            // 
            this.cbexercise.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbexercise.ForeColor = System.Drawing.Color.Black;
            this.cbexercise.FormattingEnabled = true;
            this.cbexercise.Items.AddRange(new object[] {
            "Cardio",
            "Biceps",
            "Triceps",
            "Back",
            "Shoulders",
            "Chest"});
            this.cbexercise.Location = new System.Drawing.Point(387, 127);
            this.cbexercise.Name = "cbexercise";
            this.cbexercise.Size = new System.Drawing.Size(188, 33);
            this.cbexercise.TabIndex = 11;
            this.cbexercise.SelectedIndexChanged += new System.EventHandler(this.cbexercise_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblmode);
            this.groupBox1.Controls.Add(this.tbinfo04);
            this.groupBox1.Controls.Add(this.tbinfo03);
            this.groupBox1.Controls.Add(this.lblmodeinfo04);
            this.groupBox1.Controls.Add(this.lblmodeinfo03);
            this.groupBox1.Controls.Add(this.tbinfo02);
            this.groupBox1.Controls.Add(this.tbinfo01);
            this.groupBox1.Controls.Add(this.lblmodeinfo02);
            this.groupBox1.Controls.Add(this.lblmodeinfo01);
            this.groupBox1.Controls.Add(this.btsend);
            this.groupBox1.Location = new System.Drawing.Point(43, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 385);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lblmode
            // 
            this.lblmode.AutoSize = true;
            this.lblmode.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblmode.ForeColor = System.Drawing.Color.Black;
            this.lblmode.Location = new System.Drawing.Point(400, 16);
            this.lblmode.Name = "lblmode";
            this.lblmode.Size = new System.Drawing.Size(103, 32);
            this.lblmode.TabIndex = 8;
            this.lblmode.Text = "MODE";
            // 
            // tbinfo04
            // 
            this.tbinfo04.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbinfo04.ForeColor = System.Drawing.Color.Black;
            this.tbinfo04.Location = new System.Drawing.Point(760, 239);
            this.tbinfo04.Multiline = true;
            this.tbinfo04.Name = "tbinfo04";
            this.tbinfo04.Size = new System.Drawing.Size(100, 25);
            this.tbinfo04.TabIndex = 7;
            // 
            // tbinfo03
            // 
            this.tbinfo03.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbinfo03.ForeColor = System.Drawing.Color.Black;
            this.tbinfo03.Location = new System.Drawing.Point(760, 98);
            this.tbinfo03.Multiline = true;
            this.tbinfo03.Name = "tbinfo03";
            this.tbinfo03.Size = new System.Drawing.Size(100, 25);
            this.tbinfo03.TabIndex = 6;
            // 
            // lblmodeinfo04
            // 
            this.lblmodeinfo04.AutoSize = true;
            this.lblmodeinfo04.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblmodeinfo04.ForeColor = System.Drawing.Color.Black;
            this.lblmodeinfo04.Location = new System.Drawing.Point(557, 239);
            this.lblmodeinfo04.Name = "lblmodeinfo04";
            this.lblmodeinfo04.Size = new System.Drawing.Size(122, 25);
            this.lblmodeinfo04.TabIndex = 5;
            this.lblmodeinfo04.Text = "Rest time:";
            // 
            // lblmodeinfo03
            // 
            this.lblmodeinfo03.AutoSize = true;
            this.lblmodeinfo03.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblmodeinfo03.ForeColor = System.Drawing.Color.Black;
            this.lblmodeinfo03.Location = new System.Drawing.Point(557, 98);
            this.lblmodeinfo03.Name = "lblmodeinfo03";
            this.lblmodeinfo03.Size = new System.Drawing.Size(107, 25);
            this.lblmodeinfo03.TabIndex = 4;
            this.lblmodeinfo03.Text = "Repeats:";
            // 
            // tbinfo02
            // 
            this.tbinfo02.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbinfo02.ForeColor = System.Drawing.Color.Black;
            this.tbinfo02.Location = new System.Drawing.Point(244, 232);
            this.tbinfo02.Multiline = true;
            this.tbinfo02.Name = "tbinfo02";
            this.tbinfo02.Size = new System.Drawing.Size(100, 25);
            this.tbinfo02.TabIndex = 3;
            // 
            // tbinfo01
            // 
            this.tbinfo01.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbinfo01.ForeColor = System.Drawing.Color.Black;
            this.tbinfo01.Location = new System.Drawing.Point(244, 98);
            this.tbinfo01.Multiline = true;
            this.tbinfo01.Name = "tbinfo01";
            this.tbinfo01.Size = new System.Drawing.Size(100, 25);
            this.tbinfo01.TabIndex = 2;
            // 
            // lblmodeinfo02
            // 
            this.lblmodeinfo02.AutoSize = true;
            this.lblmodeinfo02.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblmodeinfo02.ForeColor = System.Drawing.Color.Black;
            this.lblmodeinfo02.Location = new System.Drawing.Point(24, 232);
            this.lblmodeinfo02.Name = "lblmodeinfo02";
            this.lblmodeinfo02.Size = new System.Drawing.Size(142, 25);
            this.lblmodeinfo02.TabIndex = 1;
            this.lblmodeinfo02.Text = "Max weight:";
            // 
            // lblmodeinfo01
            // 
            this.lblmodeinfo01.AutoSize = true;
            this.lblmodeinfo01.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblmodeinfo01.ForeColor = System.Drawing.Color.Black;
            this.lblmodeinfo01.Location = new System.Drawing.Point(24, 98);
            this.lblmodeinfo01.Name = "lblmodeinfo01";
            this.lblmodeinfo01.Size = new System.Drawing.Size(185, 25);
            this.lblmodeinfo01.TabIndex = 0;
            this.lblmodeinfo01.Text = "Working weight:";
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btexit.Location = new System.Drawing.Point(593, 762);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(313, 46);
            this.btexit.TabIndex = 13;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(309, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Track your progress";
            // 
            // btback
            // 
            this.btback.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btback.Location = new System.Drawing.Point(60, 762);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(313, 46);
            this.btback.TabIndex = 15;
            this.btback.Text = "Back";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(980, 840);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbexercise);
            this.Controls.Add(this.tbweight);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lbldate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddInfo";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.TextBox tbweight;
        private System.Windows.Forms.ComboBox cbexercise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox tbinfo02;
        private System.Windows.Forms.TextBox tbinfo01;
        private System.Windows.Forms.Label lblmodeinfo02;
        private System.Windows.Forms.Label lblmodeinfo01;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmode;
        private System.Windows.Forms.TextBox tbinfo04;
        private System.Windows.Forms.TextBox tbinfo03;
        private System.Windows.Forms.Label lblmodeinfo04;
        private System.Windows.Forms.Label lblmodeinfo03;
        private System.Windows.Forms.Button btback;
    }
}

