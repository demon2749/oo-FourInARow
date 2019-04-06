namespace FourInARow
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.activePlayer = new System.Windows.Forms.Label();
            this.boxMatch = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.boxManage = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.boxMatch.SuspendLayout();
            this.boxManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re up,";
            // 
            // activePlayer
            // 
            this.activePlayer.AutoSize = true;
            this.activePlayer.Location = new System.Drawing.Point(475, 128);
            this.activePlayer.Name = "activePlayer";
            this.activePlayer.Size = new System.Drawing.Size(47, 13);
            this.activePlayer.TabIndex = 1;
            this.activePlayer.Text = "<player>";
            // 
            // boxMatch
            // 
            this.boxMatch.Controls.Add(this.button7);
            this.boxMatch.Controls.Add(this.button6);
            this.boxMatch.Controls.Add(this.button5);
            this.boxMatch.Controls.Add(this.button4);
            this.boxMatch.Controls.Add(this.button3);
            this.boxMatch.Controls.Add(this.button2);
            this.boxMatch.Controls.Add(this.button1);
            this.boxMatch.Controls.Add(this.board);
            this.boxMatch.Location = new System.Drawing.Point(13, 12);
            this.boxMatch.Name = "boxMatch";
            this.boxMatch.Size = new System.Drawing.Size(443, 402);
            this.boxMatch.TabIndex = 2;
            this.boxMatch.TabStop = false;
            this.boxMatch.Text = "The Match";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(375, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Drop";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(314, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Drop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(253, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Drop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Drop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Drop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Drop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Drop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // board
            // 
            this.board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.board.ColumnCount = 7;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board.Cursor = System.Windows.Forms.Cursors.No;
            this.board.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.board.Location = new System.Drawing.Point(9, 48);
            this.board.Name = "board";
            this.board.RowCount = 6;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.Size = new System.Drawing.Size(428, 346);
            this.board.TabIndex = 0;
            // 
            // boxManage
            // 
            this.boxManage.Controls.Add(this.button10);
            this.boxManage.Controls.Add(this.button9);
            this.boxManage.Controls.Add(this.button8);
            this.boxManage.Location = new System.Drawing.Point(462, 299);
            this.boxManage.Name = "boxManage";
            this.boxManage.Size = new System.Drawing.Size(106, 115);
            this.boxManage.TabIndex = 3;
            this.boxManage.TabStop = false;
            this.boxManage.Text = "Manage";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 78);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Load";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Location = new System.Drawing.Point(492, 153);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(50, 50);
            this.pictureBox43.TabIndex = 46;
            this.pictureBox43.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 425);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.boxManage);
            this.Controls.Add(this.boxMatch);
            this.Controls.Add(this.activePlayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Four in a Row v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxMatch.ResumeLayout(false);
            this.boxManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activePlayer;
        private System.Windows.Forms.GroupBox boxMatch;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.GroupBox boxManage;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox43;
    }
}

