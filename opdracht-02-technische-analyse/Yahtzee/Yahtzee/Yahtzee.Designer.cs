using System.Collections.Generic;

namespace Yahtzee

{
  partial class Yahtzee
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
      this.AlgemeneWerpBtn = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.RetryBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // AlgemeneWerpBtn
      // 
      this.AlgemeneWerpBtn.Location = new System.Drawing.Point(21, 152);
      this.AlgemeneWerpBtn.Name = "AlgemeneWerpBtn";
      this.AlgemeneWerpBtn.Size = new System.Drawing.Size(402, 24);
      this.AlgemeneWerpBtn.TabIndex = 0;
      this.AlgemeneWerpBtn.Text = "werp alle teerlingen";
      this.AlgemeneWerpBtn.UseVisualStyleBackColor = true;
      this.AlgemeneWerpBtn.Click += new System.EventHandler(this.AlgemeneWerpBtn_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(21, 191);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(54, 17);
      this.checkBox1.TabIndex = 1;
      this.checkBox1.Text = "Cheat";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // RetryBtn
      // 
      this.RetryBtn.Location = new System.Drawing.Point(348, 185);
      this.RetryBtn.Name = "RetryBtn";
      this.RetryBtn.Size = new System.Drawing.Size(75, 23);
      this.RetryBtn.TabIndex = 2;
      this.RetryBtn.Text = "Try Again";
      this.RetryBtn.UseVisualStyleBackColor = true;
      this.RetryBtn.Click += new System.EventHandler(this.RetryBtn_Click);
      // 
      // Yahtzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(452, 220);
      this.Controls.Add(this.RetryBtn);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.AlgemeneWerpBtn);
      this.Name = "Yahtzee";
      this.Text = "Yahtzee";
      this.Load += new System.EventHandler(this.Yahtzee_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button AlgemeneWerpBtn;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button RetryBtn;
  }
}

