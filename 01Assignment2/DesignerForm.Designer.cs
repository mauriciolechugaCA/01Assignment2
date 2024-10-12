namespace _01Assignment2
{
    partial class DesignerForm
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxGridGenerator = new System.Windows.Forms.GroupBox();
            this.btnGenerateGrid = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.groupBoxToolbox = new System.Windows.Forms.GroupBox();
            this.lblBoxBlue = new System.Windows.Forms.Label();
            this.lblBoxRed = new System.Windows.Forms.Label();
            this.lblDoorBlue = new System.Windows.Forms.Label();
            this.lblDoorRed = new System.Windows.Forms.Label();
            this.lblWall = new System.Windows.Forms.Label();
            this.lblNone = new System.Windows.Forms.Label();
            this.pictureBoxBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxWall = new System.Windows.Forms.PictureBox();
            this.pictureBoxNone = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxGridGenerator.SuspendLayout();
            this.groupBoxToolbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNone)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // groupBoxGridGenerator
            // 
            this.groupBoxGridGenerator.Controls.Add(this.btnGenerateGrid);
            this.groupBoxGridGenerator.Controls.Add(this.textBox2);
            this.groupBoxGridGenerator.Controls.Add(this.textBox1);
            this.groupBoxGridGenerator.Controls.Add(this.lblColumns);
            this.groupBoxGridGenerator.Controls.Add(this.lblRows);
            this.groupBoxGridGenerator.Location = new System.Drawing.Point(12, 36);
            this.groupBoxGridGenerator.Name = "groupBoxGridGenerator";
            this.groupBoxGridGenerator.Size = new System.Drawing.Size(259, 86);
            this.groupBoxGridGenerator.TabIndex = 1;
            this.groupBoxGridGenerator.TabStop = false;
            this.groupBoxGridGenerator.Text = "Create your grid first...";
            // 
            // btnGenerateGrid
            // 
            this.btnGenerateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGrid.Location = new System.Drawing.Point(145, 19);
            this.btnGenerateGrid.Name = "btnGenerateGrid";
            this.btnGenerateGrid.Size = new System.Drawing.Size(102, 52);
            this.btnGenerateGrid.TabIndex = 4;
            this.btnGenerateGrid.Text = "Generate!";
            this.btnGenerateGrid.UseVisualStyleBackColor = true;
            this.btnGenerateGrid.Click += new System.EventHandler(this.btnGenerateGrid_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(79, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(79, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(11, 52);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(62, 16);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(29, 25);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(44, 16);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // groupBoxToolbox
            // 
            this.groupBoxToolbox.Controls.Add(this.lblBoxBlue);
            this.groupBoxToolbox.Controls.Add(this.lblBoxRed);
            this.groupBoxToolbox.Controls.Add(this.lblDoorBlue);
            this.groupBoxToolbox.Controls.Add(this.lblDoorRed);
            this.groupBoxToolbox.Controls.Add(this.lblWall);
            this.groupBoxToolbox.Controls.Add(this.lblNone);
            this.groupBoxToolbox.Controls.Add(this.pictureBoxBoxBlue);
            this.groupBoxToolbox.Controls.Add(this.pictureBoxBoxRed);
            this.groupBoxToolbox.Controls.Add(this.pictureBoxDoorBlue);
            this.groupBoxToolbox.Controls.Add(this.pictureBoxDoorRed);
            this.groupBoxToolbox.Controls.Add(this.pictureBoxWall);
            this.groupBoxToolbox.Controls.Add(this.pictureBoxNone);
            this.groupBoxToolbox.Location = new System.Drawing.Point(12, 140);
            this.groupBoxToolbox.Name = "groupBoxToolbox";
            this.groupBoxToolbox.Size = new System.Drawing.Size(259, 443);
            this.groupBoxToolbox.TabIndex = 2;
            this.groupBoxToolbox.TabStop = false;
            this.groupBoxToolbox.Text = "Add your elements...";
            // 
            // lblBoxBlue
            // 
            this.lblBoxBlue.AutoSize = true;
            this.lblBoxBlue.Location = new System.Drawing.Point(86, 390);
            this.lblBoxBlue.Name = "lblBoxBlue";
            this.lblBoxBlue.Size = new System.Drawing.Size(49, 13);
            this.lblBoxBlue.TabIndex = 11;
            this.lblBoxBlue.Tag = "BB";
            this.lblBoxBlue.Text = "Blue Box";
            // 
            // lblBoxRed
            // 
            this.lblBoxRed.AutoSize = true;
            this.lblBoxRed.Location = new System.Drawing.Point(86, 321);
            this.lblBoxRed.Name = "lblBoxRed";
            this.lblBoxRed.Size = new System.Drawing.Size(48, 13);
            this.lblBoxRed.TabIndex = 10;
            this.lblBoxRed.Tag = "RB";
            this.lblBoxRed.Text = "Red Box";
            // 
            // lblDoorBlue
            // 
            this.lblDoorBlue.AutoSize = true;
            this.lblDoorBlue.Location = new System.Drawing.Point(86, 252);
            this.lblDoorBlue.Name = "lblDoorBlue";
            this.lblDoorBlue.Size = new System.Drawing.Size(54, 13);
            this.lblDoorBlue.TabIndex = 9;
            this.lblDoorBlue.Tag = "BD";
            this.lblDoorBlue.Text = "Blue Door";
            // 
            // lblDoorRed
            // 
            this.lblDoorRed.AutoSize = true;
            this.lblDoorRed.Location = new System.Drawing.Point(86, 183);
            this.lblDoorRed.Name = "lblDoorRed";
            this.lblDoorRed.Size = new System.Drawing.Size(53, 13);
            this.lblDoorRed.TabIndex = 8;
            this.lblDoorRed.Text = "Red Door";
            // 
            // lblWall
            // 
            this.lblWall.AutoSize = true;
            this.lblWall.Location = new System.Drawing.Point(86, 114);
            this.lblWall.Name = "lblWall";
            this.lblWall.Size = new System.Drawing.Size(28, 13);
            this.lblWall.TabIndex = 7;
            this.lblWall.Text = "Wall";
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Location = new System.Drawing.Point(86, 45);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(75, 13);
            this.lblNone.TabIndex = 6;
            this.lblNone.Text = "None / Delete";
            // 
            // pictureBoxBoxBlue
            // 
            this.pictureBoxBoxBlue.BackgroundImage = global::_01Assignment2.Properties.Resources.box_blue;
            this.pictureBoxBoxBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBoxBlue.Location = new System.Drawing.Point(14, 364);
            this.pictureBoxBoxBlue.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBoxBlue.Name = "pictureBoxBoxBlue";
            this.pictureBoxBoxBlue.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxBoxBlue.TabIndex = 5;
            this.pictureBoxBoxBlue.TabStop = false;
            this.pictureBoxBoxBlue.Click += new System.EventHandler(this.pictureBoxWall_Click);
            // 
            // pictureBoxBoxRed
            // 
            this.pictureBoxBoxRed.BackgroundImage = global::_01Assignment2.Properties.Resources.box_red;
            this.pictureBoxBoxRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBoxRed.Location = new System.Drawing.Point(14, 295);
            this.pictureBoxBoxRed.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBoxRed.Name = "pictureBoxBoxRed";
            this.pictureBoxBoxRed.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxBoxRed.TabIndex = 4;
            this.pictureBoxBoxRed.TabStop = false;
            this.pictureBoxBoxRed.Click += new System.EventHandler(this.pictureBoxWall_Click);
            // 
            // pictureBoxDoorBlue
            // 
            this.pictureBoxDoorBlue.BackgroundImage = global::_01Assignment2.Properties.Resources.door_blue;
            this.pictureBoxDoorBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDoorBlue.Location = new System.Drawing.Point(14, 226);
            this.pictureBoxDoorBlue.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDoorBlue.Name = "pictureBoxDoorBlue";
            this.pictureBoxDoorBlue.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxDoorBlue.TabIndex = 3;
            this.pictureBoxDoorBlue.TabStop = false;
            this.pictureBoxDoorBlue.Click += new System.EventHandler(this.pictureBoxWall_Click);
            // 
            // pictureBoxDoorRed
            // 
            this.pictureBoxDoorRed.BackgroundImage = global::_01Assignment2.Properties.Resources.door_red;
            this.pictureBoxDoorRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDoorRed.Location = new System.Drawing.Point(14, 157);
            this.pictureBoxDoorRed.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDoorRed.Name = "pictureBoxDoorRed";
            this.pictureBoxDoorRed.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxDoorRed.TabIndex = 2;
            this.pictureBoxDoorRed.TabStop = false;
            this.pictureBoxDoorRed.Tag = "";
            this.pictureBoxDoorRed.Click += new System.EventHandler(this.pictureBoxWall_Click);
            // 
            // pictureBoxWall
            // 
            this.pictureBoxWall.BackgroundImage = global::_01Assignment2.Properties.Resources.wall;
            this.pictureBoxWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWall.Location = new System.Drawing.Point(14, 88);
            this.pictureBoxWall.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWall.Name = "pictureBoxWall";
            this.pictureBoxWall.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxWall.TabIndex = 1;
            this.pictureBoxWall.TabStop = false;
            this.pictureBoxWall.Tag = "";
            this.pictureBoxWall.Click += new System.EventHandler(this.pictureBoxWall_Click);
            // 
            // pictureBoxNone
            // 
            this.pictureBoxNone.BackgroundImage = global::_01Assignment2.Properties.Resources.none;
            this.pictureBoxNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNone.Location = new System.Drawing.Point(14, 19);
            this.pictureBoxNone.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNone.Name = "pictureBoxNone";
            this.pictureBoxNone.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxNone.TabIndex = 0;
            this.pictureBoxNone.TabStop = false;
            this.pictureBoxNone.Tag = "";
            this.pictureBoxNone.Click += new System.EventHandler(this.pictureBoxWall_Click);
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBoxToolbox);
            this.Controls.Add(this.groupBoxGridGenerator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignerForm";
            this.Text = "Design your own level!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxGridGenerator.ResumeLayout(false);
            this.groupBoxGridGenerator.PerformLayout();
            this.groupBoxToolbox.ResumeLayout(false);
            this.groupBoxToolbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxGridGenerator;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerateGrid;
        private System.Windows.Forms.GroupBox groupBoxToolbox;
        private System.Windows.Forms.PictureBox pictureBoxWall;
        private System.Windows.Forms.PictureBox pictureBoxNone;
        private System.Windows.Forms.PictureBox pictureBoxBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxDoorBlue;
        private System.Windows.Forms.PictureBox pictureBoxDoorRed;
        private System.Windows.Forms.Label lblDoorBlue;
        private System.Windows.Forms.Label lblDoorRed;
        private System.Windows.Forms.Label lblWall;
        private System.Windows.Forms.Label lblNone;
        private System.Windows.Forms.Label lblBoxBlue;
        private System.Windows.Forms.Label lblBoxRed;
    }
}