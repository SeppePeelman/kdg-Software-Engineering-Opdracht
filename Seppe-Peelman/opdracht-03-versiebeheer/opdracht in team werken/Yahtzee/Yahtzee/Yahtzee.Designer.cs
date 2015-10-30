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
      this.ThrowsLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // AlgemeneWerpBtn
      // 
      this.AlgemeneWerpBtn.Location = new System.Drawing.Point(19, 180);
      this.AlgemeneWerpBtn.Name = "AlgemeneWerpBtn";
      this.AlgemeneWerpBtn.Size = new System.Drawing.Size(698, 24);
      this.AlgemeneWerpBtn.TabIndex = 0;
      this.AlgemeneWerpBtn.Text = "Roll";
      this.AlgemeneWerpBtn.UseVisualStyleBackColor = true;
      this.AlgemeneWerpBtn.Click += new System.EventHandler(this.AlgemeneWerpBtn_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(663, 216);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(54, 17);
      this.checkBox1.TabIndex = 1;
      this.checkBox1.Text = "Cheat";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // RetryBtn
      // 
      this.RetryBtn.Location = new System.Drawing.Point(19, 208);
      this.RetryBtn.Name = "RetryBtn";
      this.RetryBtn.Size = new System.Drawing.Size(100, 23);
      this.RetryBtn.TabIndex = 2;
      this.RetryBtn.Text = "Next Player";
      this.RetryBtn.UseVisualStyleBackColor = true;
      this.RetryBtn.Click += new System.EventHandler(this.RetryBtn_Click);
      // 
      // ThrowsLabel
      // 
      this.ThrowsLabel.BackColor = System.Drawing.SystemColors.Control;
      this.ThrowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ThrowsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ThrowsLabel.Location = new System.Drawing.Point(125, 210);
      this.ThrowsLabel.Name = "ThrowsLabel";
      this.ThrowsLabel.Size = new System.Drawing.Size(100, 23);
      this.ThrowsLabel.TabIndex = 5;
      this.ThrowsLabel.Text = "Throws: 0/3";
      this.ThrowsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Yahtzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(742, 326);
      this.Controls.Add(this.ThrowsLabel);
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
    private System.Windows.Forms.Label ThrowsLabel;
  }
}

