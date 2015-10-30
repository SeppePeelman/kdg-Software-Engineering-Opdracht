namespace Yahtzee
{
  partial class TeerlingView
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
      this.TeerlingLabel = new System.Windows.Forms.Label();
      this.TeerlingWerpBtn = new System.Windows.Forms.Button();
      this.holdBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TeerlingLabel
      // 
      this.TeerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TeerlingLabel.Location = new System.Drawing.Point(22, 12);
      this.TeerlingLabel.Name = "TeerlingLabel";
      this.TeerlingLabel.Size = new System.Drawing.Size(100, 100);
      this.TeerlingLabel.TabIndex = 0;
      this.TeerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TeerlingWerpBtn
      // 
      this.TeerlingWerpBtn.Location = new System.Drawing.Point(34, 115);
      this.TeerlingWerpBtn.Name = "TeerlingWerpBtn";
      this.TeerlingWerpBtn.Size = new System.Drawing.Size(75, 23);
      this.TeerlingWerpBtn.TabIndex = 1;
      this.TeerlingWerpBtn.Text = "Roll";
      this.TeerlingWerpBtn.UseVisualStyleBackColor = true;
      this.TeerlingWerpBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // holdBtn
      // 
      this.holdBtn.Location = new System.Drawing.Point(34, 144);
      this.holdBtn.Name = "holdBtn";
      this.holdBtn.Size = new System.Drawing.Size(75, 23);
      this.holdBtn.TabIndex = 2;
      this.holdBtn.Text = "Hold";
      this.holdBtn.UseVisualStyleBackColor = true;
      this.holdBtn.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // TeerlingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.holdBtn);
      this.Controls.Add(this.TeerlingWerpBtn);
      this.Controls.Add(this.TeerlingLabel);
      this.Name = "TeerlingView";
      this.Size = new System.Drawing.Size(150, 186);
      this.Load += new System.EventHandler(this.TeerlingView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label TeerlingLabel;
    private System.Windows.Forms.Button TeerlingWerpBtn;
    private System.Windows.Forms.Button holdBtn;
  }
}
