namespace Project
{
    partial class AddGoal
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
            this.gbLifting = new System.Windows.Forms.GroupBox();
            this.btAddLifting = new System.Windows.Forms.Button();
            this.tbLiftingParam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLiftingType = new System.Windows.Forms.ComboBox();
            this.gbCardio = new System.Windows.Forms.GroupBox();
            this.btAddCardio = new System.Windows.Forms.Button();
            this.tbCardioParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCardioType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.gbLifting.SuspendLayout();
            this.gbCardio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLifting
            // 
            this.gbLifting.Controls.Add(this.btAddLifting);
            this.gbLifting.Controls.Add(this.tbLiftingParam);
            this.gbLifting.Controls.Add(this.label5);
            this.gbLifting.Controls.Add(this.label4);
            this.gbLifting.Controls.Add(this.cbLiftingType);
            this.gbLifting.Location = new System.Drawing.Point(23, 122);
            this.gbLifting.Name = "gbLifting";
            this.gbLifting.Size = new System.Drawing.Size(398, 179);
            this.gbLifting.TabIndex = 0;
            this.gbLifting.TabStop = false;
            // 
            // btAddLifting
            // 
            this.btAddLifting.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAddLifting.Location = new System.Drawing.Point(17, 119);
            this.btAddLifting.Name = "btAddLifting";
            this.btAddLifting.Size = new System.Drawing.Size(375, 40);
            this.btAddLifting.TabIndex = 4;
            this.btAddLifting.Text = "Add";
            this.btAddLifting.UseVisualStyleBackColor = true;
            this.btAddLifting.Click += new System.EventHandler(this.btAddLifting_Click);
            // 
            // tbLiftingParam
            // 
            this.tbLiftingParam.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLiftingParam.Location = new System.Drawing.Point(254, 67);
            this.tbLiftingParam.Name = "tbLiftingParam";
            this.tbLiftingParam.Size = new System.Drawing.Size(138, 33);
            this.tbLiftingParam.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(285, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(33, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parameter";
            // 
            // cbLiftingType
            // 
            this.cbLiftingType.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLiftingType.FormattingEnabled = true;
            this.cbLiftingType.Items.AddRange(new object[] {
            "Max weight",
            "Work weight"});
            this.cbLiftingType.Location = new System.Drawing.Point(17, 66);
            this.cbLiftingType.Name = "cbLiftingType";
            this.cbLiftingType.Size = new System.Drawing.Size(183, 33);
            this.cbLiftingType.TabIndex = 0;
            // 
            // gbCardio
            // 
            this.gbCardio.Controls.Add(this.btAddCardio);
            this.gbCardio.Controls.Add(this.tbCardioParam);
            this.gbCardio.Controls.Add(this.label3);
            this.gbCardio.Controls.Add(this.label2);
            this.gbCardio.Controls.Add(this.cbCardioType);
            this.gbCardio.Location = new System.Drawing.Point(23, 325);
            this.gbCardio.Name = "gbCardio";
            this.gbCardio.Size = new System.Drawing.Size(398, 179);
            this.gbCardio.TabIndex = 1;
            this.gbCardio.TabStop = false;
            // 
            // btAddCardio
            // 
            this.btAddCardio.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAddCardio.Location = new System.Drawing.Point(17, 132);
            this.btAddCardio.Name = "btAddCardio";
            this.btAddCardio.Size = new System.Drawing.Size(375, 38);
            this.btAddCardio.TabIndex = 4;
            this.btAddCardio.Text = "Add";
            this.btAddCardio.UseVisualStyleBackColor = true;
            this.btAddCardio.Click += new System.EventHandler(this.btAddCardio_Click);
            // 
            // tbCardioParam
            // 
            this.tbCardioParam.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCardioParam.Location = new System.Drawing.Point(259, 65);
            this.tbCardioParam.Name = "tbCardioParam";
            this.tbCardioParam.Size = new System.Drawing.Size(132, 31);
            this.tbCardioParam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(285, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parameter";
            // 
            // cbCardioType
            // 
            this.cbCardioType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCardioType.FormattingEnabled = true;
            this.cbCardioType.Items.AddRange(new object[] {
            "Duration",
            "Distance",
            "Callories burned"});
            this.cbCardioType.Location = new System.Drawing.Point(17, 65);
            this.cbCardioType.Name = "cbCardioType";
            this.cbCardioType.Size = new System.Drawing.Size(183, 31);
            this.cbCardioType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add your goals here";
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBack.Location = new System.Drawing.Point(23, 557);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(398, 48);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Lifting goal",
            "Cardio goal"});
            this.cbType.Location = new System.Drawing.Point(136, 55);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(170, 31);
            this.cbType.TabIndex = 5;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // AddGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 637);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCardio);
            this.Controls.Add(this.gbLifting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddGoal";
            this.Text = "AddGoal";
            this.gbLifting.ResumeLayout(false);
            this.gbLifting.PerformLayout();
            this.gbCardio.ResumeLayout(false);
            this.gbCardio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLifting;
        private System.Windows.Forms.GroupBox gbCardio;
        private System.Windows.Forms.TextBox tbLiftingParam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLiftingType;
        private System.Windows.Forms.TextBox tbCardioParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCardioType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btAddLifting;
        private System.Windows.Forms.Button btAddCardio;
    }
}