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
      this.SuspendLayout();
      // 
      // ScoreView
      // 
      this.Name = "ScoreView";
      this.Load += new System.EventHandler(this.ScoreView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label ScoreLabel;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.Label HighScoreLabel;
    private System.Windows.Forms.TextBox textBox2;
  }
}
