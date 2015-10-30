namespace Yahtzee
{
    partial class CheatView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.Extra_Roll_btn = new System.Windows.Forms.Button();
      this.Individual_Roll_btn = new System.Windows.Forms.Button();
      this.Cheat_Score_P1 = new System.Windows.Forms.Label();
      this.Cheat_Score_P2 = new System.Windows.Forms.Label();
      this.Amount_Cheat_Points_P1 = new System.Windows.Forms.Label();
      this.Amount_Cheat_Points_P2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Extra_Roll_btn
      // 
      this.Extra_Roll_btn.Location = new System.Drawing.Point(55, 132);
      this.Extra_Roll_btn.Name = "Extra_Roll_btn";
      this.Extra_Roll_btn.Size = new System.Drawing.Size(91, 23);
      this.Extra_Roll_btn.TabIndex = 0;
      this.Extra_Roll_btn.Text = "Extra Roll";
      this.Extra_Roll_btn.UseVisualStyleBackColor = true;
      this.Extra_Roll_btn.Click += new System.EventHandler(this.Extra_Roll_btn_Click);
      // 
      // Individual_Roll_btn
      // 
      this.Individual_Roll_btn.Location = new System.Drawing.Point(152, 132);
      this.Individual_Roll_btn.Name = "Individual_Roll_btn";
      this.Individual_Roll_btn.Size = new System.Drawing.Size(111, 23);
      this.Individual_Roll_btn.TabIndex = 1;
      this.Individual_Roll_btn.Text = "Individual Rolls";
      this.Individual_Roll_btn.UseVisualStyleBackColor = true;
      this.Individual_Roll_btn.Click += new System.EventHandler(this.Individual_Roll_btn_Click);
      // 
      // Cheat_Score_P1
      // 
      this.Cheat_Score_P1.AutoSize = true;
      this.Cheat_Score_P1.Location = new System.Drawing.Point(65, 37);
      this.Cheat_Score_P1.Name = "Cheat_Score_P1";
      this.Cheat_Score_P1.Size = new System.Drawing.Size(89, 13);
      this.Cheat_Score_P1.TabIndex = 2;
      this.Cheat_Score_P1.Text = "Cheat Points P1 :";
      // 
      // Cheat_Score_P2
      // 
      this.Cheat_Score_P2.AutoSize = true;
      this.Cheat_Score_P2.Location = new System.Drawing.Point(65, 83);
      this.Cheat_Score_P2.Name = "Cheat_Score_P2";
      this.Cheat_Score_P2.Size = new System.Drawing.Size(89, 13);
      this.Cheat_Score_P2.TabIndex = 3;
      this.Cheat_Score_P2.Text = "Cheat Points P2 :";
      // 
      // Amount_Cheat_Points_P1
      // 
      this.Amount_Cheat_Points_P1.AutoSize = true;
      this.Amount_Cheat_Points_P1.Location = new System.Drawing.Point(189, 37);
      this.Amount_Cheat_Points_P1.Name = "Amount_Cheat_Points_P1";
      this.Amount_Cheat_Points_P1.Size = new System.Drawing.Size(43, 13);
      this.Amount_Cheat_Points_P1.TabIndex = 4;
      this.Amount_Cheat_Points_P1.Text = "Amount";
      this.Amount_Cheat_Points_P1.Click += new System.EventHandler(this.Amount_Cheat_Points_P1_Click);
      // 
      // Amount_Cheat_Points_P2
      // 
      this.Amount_Cheat_Points_P2.AutoSize = true;
      this.Amount_Cheat_Points_P2.Location = new System.Drawing.Point(189, 83);
      this.Amount_Cheat_Points_P2.Name = "Amount_Cheat_Points_P2";
      this.Amount_Cheat_Points_P2.Size = new System.Drawing.Size(43, 13);
      this.Amount_Cheat_Points_P2.TabIndex = 5;
      this.Amount_Cheat_Points_P2.Text = "Amount";
      this.Amount_Cheat_Points_P2.Click += new System.EventHandler(this.Amount_Cheat_Points_P2_Click);
      // 
      // CheatView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Amount_Cheat_Points_P2);
      this.Controls.Add(this.Amount_Cheat_Points_P1);
      this.Controls.Add(this.Cheat_Score_P2);
      this.Controls.Add(this.Cheat_Score_P1);
      this.Controls.Add(this.Individual_Roll_btn);
      this.Controls.Add(this.Extra_Roll_btn);
      this.Name = "CheatView";
      this.Size = new System.Drawing.Size(266, 181);
      this.Load += new System.EventHandler(this.CheatView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Extra_Roll_btn;
        private System.Windows.Forms.Button Individual_Roll_btn;
        private System.Windows.Forms.Label Cheat_Score_P1;
        private System.Windows.Forms.Label Cheat_Score_P2;
        private System.Windows.Forms.Label Amount_Cheat_Points_P1;
        private System.Windows.Forms.Label Amount_Cheat_Points_P2;
    }
}
