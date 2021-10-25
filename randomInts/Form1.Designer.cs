namespace randomInts
{
    partial class Form1
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
            this.reset = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sortColorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortEvenOddComboBox = new System.Windows.Forms.ComboBox();
            this.delEvenOddComboBox = new System.Windows.Forms.ComboBox();
            this.sortAscDescComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Location = new System.Drawing.Point(380, 375);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 75);
            this.reset.TabIndex = 0;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Sort
            // 
            this.Sort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Sort.Location = new System.Drawing.Point(449, 120);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 1;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Remove
            // 
            this.Remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Remove.Location = new System.Drawing.Point(449, 149);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sortColorComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.delColorComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.sortEvenOddComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.delEvenOddComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.sortAscDescComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.Sort);
            this.splitContainer1.Panel2.Controls.Add(this.Remove);
            this.splitContainer1.Panel2.Controls.Add(this.reset);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // sortColorComboBox
            // 
            this.sortColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortColorComboBox.FormattingEnabled = true;
            this.sortColorComboBox.Location = new System.Drawing.Point(403, 27);
            this.sortColorComboBox.Name = "sortColorComboBox";
            this.sortColorComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortColorComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sort Elements:";
            // 
            // delColorComboBox
            // 
            this.delColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delColorComboBox.FormattingEnabled = true;
            this.delColorComboBox.Location = new System.Drawing.Point(403, 91);
            this.delColorComboBox.Name = "delColorComboBox";
            this.delColorComboBox.Size = new System.Drawing.Size(121, 23);
            this.delColorComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Elements:";
            // 
            // sortEvenOddComboBox
            // 
            this.sortEvenOddComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortEvenOddComboBox.FormattingEnabled = true;
            this.sortEvenOddComboBox.Items.AddRange(new object[] {
            "Even Numbers",
            "Odd Numbers"});
            this.sortEvenOddComboBox.Location = new System.Drawing.Point(276, 27);
            this.sortEvenOddComboBox.Name = "sortEvenOddComboBox";
            this.sortEvenOddComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortEvenOddComboBox.TabIndex = 0;
            // 
            // delEvenOddComboBox
            // 
            this.delEvenOddComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delEvenOddComboBox.FormattingEnabled = true;
            this.delEvenOddComboBox.Items.AddRange(new object[] {
            "Even Numbers",
            "Odd Numbers"});
            this.delEvenOddComboBox.Location = new System.Drawing.Point(276, 91);
            this.delEvenOddComboBox.Name = "delEvenOddComboBox";
            this.delEvenOddComboBox.Size = new System.Drawing.Size(121, 23);
            this.delEvenOddComboBox.TabIndex = 0;
            // 
            // sortAscDescComboBox
            // 
            this.sortAscDescComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortAscDescComboBox.FormattingEnabled = true;
            this.sortAscDescComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortAscDescComboBox.Location = new System.Drawing.Point(149, 27);
            this.sortAscDescComboBox.Name = "sortAscDescComboBox";
            this.sortAscDescComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortAscDescComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Saltus Tech Demo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox sortColorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox delColorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortEvenOddComboBox;
        private System.Windows.Forms.ComboBox delEvenOddComboBox;
        private System.Windows.Forms.ComboBox sortAscDescComboBox;
    }
}

