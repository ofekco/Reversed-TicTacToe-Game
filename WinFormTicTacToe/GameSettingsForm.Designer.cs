
namespace FormUI
{
    partial class FormGameSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelCols = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(172, 46);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(150, 31);
            this.textBoxPlayer1.TabIndex = 1;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AccessibleName = "Player1Label";
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(26, 48);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(78, 25);
            this.labelPlayer1.TabIndex = 2;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(13, 6);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(71, 25);
            this.labelPlayers.TabIndex = 3;
            this.labelPlayers.Text = "Players:\r\n";
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(26, 97);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(104, 29);
            this.checkBoxPlayer2.TabIndex = 6;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.Click += new System.EventHandler(this.CheckBoxPlayer2_Click);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPlayer2.Location = new System.Drawing.Point(172, 98);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(150, 31);
            this.textBoxPlayer2.TabIndex = 7;
            this.textBoxPlayer2.Text = "[Computer\r\n]";
            this.textBoxPlayer2.TextChanged += new System.EventHandler(this.textBoxPlayer2_TextChanged);
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Location = new System.Drawing.Point(13, 152);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(99, 25);
            this.labelBoardSize.TabIndex = 8;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(35, 190);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(58, 25);
            this.labelRows.TabIndex = 9;
            this.labelRows.Text = "Rows:\r\n";
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(161, 190);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(50, 25);
            this.labelCols.TabIndex = 10;
            this.labelCols.Text = "Cols:";
            // 
            // buttonStart
            // 
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Location = new System.Drawing.Point(13, 241);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(309, 39);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(227, 190);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(61, 31);
            this.numericUpDownCols.TabIndex = 15;
            this.numericUpDownCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCols.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDownCols_MouseDown);
            this.numericUpDownCols.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDownCols_MouseDown);
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(100, 190);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(55, 31);
            this.numericUpDownRows.TabIndex = 14;
            this.numericUpDownRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDownRows_MouseDown);
            this.numericUpDownRows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDownCols_MouseDown);
            // 
            // FormGameSettings
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 322);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.textBoxPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
    }
}

