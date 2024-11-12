namespace _01Assignment2
{
    partial class PlayForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblNumMoves = new System.Windows.Forms.Label();
            this.lblRemainingBoxes = new System.Windows.Forms.Label();
            this.txtNumMoves = new System.Windows.Forms.TextBox();
            this.txtRemainingBoxes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLevelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadLevelToolStripMenuItem
            // 
            this.loadLevelToolStripMenuItem.Name = "loadLevelToolStripMenuItem";
            this.loadLevelToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.loadLevelToolStripMenuItem.Text = "Load Level...";
            this.loadLevelToolStripMenuItem.Click += new System.EventHandler(this.loadLevelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(21, 618);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 70);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Tag = "Left";
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(97, 618);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(70, 70);
            this.btnDown.TabIndex = 3;
            this.btnDown.Tag = "Down";
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(173, 618);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 70);
            this.btnRight.TabIndex = 4;
            this.btnRight.Tag = "Right";
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(97, 542);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(70, 70);
            this.btnUp.TabIndex = 5;
            this.btnUp.Tag = "Up";
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // lblNumMoves
            // 
            this.lblNumMoves.AutoSize = true;
            this.lblNumMoves.Location = new System.Drawing.Point(43, 69);
            this.lblNumMoves.Name = "lblNumMoves";
            this.lblNumMoves.Size = new System.Drawing.Size(145, 20);
            this.lblNumMoves.TabIndex = 6;
            this.lblNumMoves.Text = "Number of Moves:";
            // 
            // lblRemainingBoxes
            // 
            this.lblRemainingBoxes.AutoSize = true;
            this.lblRemainingBoxes.Location = new System.Drawing.Point(43, 164);
            this.lblRemainingBoxes.Name = "lblRemainingBoxes";
            this.lblRemainingBoxes.Size = new System.Drawing.Size(230, 20);
            this.lblRemainingBoxes.TabIndex = 7;
            this.lblRemainingBoxes.Text = "Number of Remaining Boxes::";
            // 
            // txtNumMoves
            // 
            this.txtNumMoves.Location = new System.Drawing.Point(46, 92);
            this.txtNumMoves.Name = "txtNumMoves";
            this.txtNumMoves.ReadOnly = true;
            this.txtNumMoves.Size = new System.Drawing.Size(100, 22);
            this.txtNumMoves.TabIndex = 8;
            // 
            // txtRemainingBoxes
            // 
            this.txtRemainingBoxes.Location = new System.Drawing.Point(46, 187);
            this.txtRemainingBoxes.Name = "txtRemainingBoxes";
            this.txtRemainingBoxes.ReadOnly = true;
            this.txtRemainingBoxes.Size = new System.Drawing.Size(100, 22);
            this.txtRemainingBoxes.TabIndex = 9;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.txtRemainingBoxes);
            this.Controls.Add(this.txtNumMoves);
            this.Controls.Add(this.lblRemainingBoxes);
            this.Controls.Add(this.lblNumMoves);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblNumMoves;
        private System.Windows.Forms.Label lblRemainingBoxes;
        private System.Windows.Forms.TextBox txtNumMoves;
        private System.Windows.Forms.TextBox txtRemainingBoxes;
    }
}