namespace Yahtzee
{
  partial class TurnView
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
      this.label2 = new System.Windows.Forms.Label();
      this.TurnLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.White;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(24, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = "Turn:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TurnLabel
      // 
      this.TurnLabel.BackColor = System.Drawing.SystemColors.Control;
      this.TurnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TurnLabel.Location = new System.Drawing.Point(24, 40);
      this.TurnLabel.Name = "TurnLabel";
      this.TurnLabel.Size = new System.Drawing.Size(100, 100);
      this.TurnLabel.TabIndex = 6;
      this.TurnLabel.Text = "P1";
      this.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TurnView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TurnLabel);
      this.Name = "TurnView";
      this.Load += new System.EventHandler(this.TurnView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label TurnLabel;
  }
}
