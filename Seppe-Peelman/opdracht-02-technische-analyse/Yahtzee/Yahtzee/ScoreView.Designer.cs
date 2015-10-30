namespace Yahtzee
{
  partial class ScoreView
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
      this.components = new System.ComponentModel.Container();
      this.ScoreLabel = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.HighScoreLabel = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // ScoreLabel
      // 
      this.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ScoreLabel.Location = new System.Drawing.Point(24, 38);
      this.ScoreLabel.Name = "ScoreLabel";
      this.ScoreLabel.Size = new System.Drawing.Size(100, 100);
      this.ScoreLabel.TabIndex = 0;
      this.ScoreLabel.Text = "0";
      this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(24, 15);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "Score:";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // HighScoreLabel
      // 
      this.HighScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.HighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HighScoreLabel.Location = new System.Drawing.Point(24, 185);
      this.HighScoreLabel.Name = "HighScoreLabel";
      this.HighScoreLabel.Size = new System.Drawing.Size(100, 100);
      this.HighScoreLabel.TabIndex = 3;
      this.HighScoreLabel.Text = "0";
      this.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(24, 162);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 4;
      this.textBox2.Text = "HiScore:";
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ScoreView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.HighScoreLabel);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.ScoreLabel);
      this.Name = "ScoreView";
      this.Size = new System.Drawing.Size(151, 313);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label ScoreLabel;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.Label HighScoreLabel;
    private System.Windows.Forms.TextBox textBox2;
  }
}
