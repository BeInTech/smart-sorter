namespace SmartSorter
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
            this.gridFillButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFillButton
            // 
            this.gridFillButton.Location = new System.Drawing.Point(433, 415);
            this.gridFillButton.Name = "gridFillButton";
            this.gridFillButton.Size = new System.Drawing.Size(98, 23);
            this.gridFillButton.TabIndex = 0;
            this.gridFillButton.Text = "Сортировать";
            this.gridFillButton.UseVisualStyleBackColor = true;
            this.gridFillButton.Click += new System.EventHandler(this.gridFillButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 30);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(519, 97);
            this.inputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входные данные";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.value,
            this.count});
            this.resultGridView.Location = new System.Drawing.Point(12, 165);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.Size = new System.Drawing.Size(519, 244);
            this.resultGridView.TabIndex = 3;
            // 
            // value
            // 
            this.value.HeaderText = "Значение";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.gridFillButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gridFillButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Label label2;
    }
}

