namespace EMIcalc
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
            btn_Calculate = new Button();
            label_Principle = new Label();
            label_Interest = new Label();
            label_Tenure = new Label();
            textBox_Principle = new TextBox();
            textBox_Interest = new TextBox();
            textBox_Tenure = new TextBox();
            label_EMI = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_EMI_Result = new TextBox();
            textBox_TotalInterest_Result = new TextBox();
            textBox_TotalAmount_Result = new TextBox();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btn_Calculate
            // 
            btn_Calculate.Location = new Point(336, 218);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(94, 29);
            btn_Calculate.TabIndex = 0;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // label_Principle
            // 
            label_Principle.AutoSize = true;
            label_Principle.Location = new Point(219, 25);
            label_Principle.Name = "label_Principle";
            label_Principle.Size = new Size(126, 20);
            label_Principle.TabIndex = 1;
            label_Principle.Text = "Principle Amount:";
            // 
            // label_Interest
            // 
            label_Interest.AutoSize = true;
            label_Interest.Location = new Point(232, 88);
            label_Interest.Name = "label_Interest";
            label_Interest.Size = new Size(113, 20);
            label_Interest.TabIndex = 2;
            label_Interest.Text = "Rate of Interest:";
            // 
            // label_Tenure
            // 
            label_Tenure.AutoSize = true;
            label_Tenure.Location = new Point(210, 153);
            label_Tenure.Name = "label_Tenure";
            label_Tenure.Size = new Size(135, 20);
            label_Tenure.TabIndex = 3;
            label_Tenure.Text = "Tenure (in months):";
            // 
            // textBox_Principle
            // 
            textBox_Principle.Location = new Point(389, 22);
            textBox_Principle.Name = "textBox_Principle";
            textBox_Principle.Size = new Size(125, 27);
            textBox_Principle.TabIndex = 4;
            // 
            // textBox_Interest
            // 
            textBox_Interest.Location = new Point(389, 85);
            textBox_Interest.Name = "textBox_Interest";
            textBox_Interest.Size = new Size(125, 27);
            textBox_Interest.TabIndex = 5;
            // 
            // textBox_Tenure
            // 
            textBox_Tenure.Location = new Point(389, 150);
            textBox_Tenure.Name = "textBox_Tenure";
            textBox_Tenure.Size = new Size(125, 27);
            textBox_Tenure.TabIndex = 6;
            // 
            // label_EMI
            // 
            label_EMI.AutoSize = true;
            label_EMI.Location = new Point(284, 281);
            label_EMI.Name = "label_EMI";
            label_EMI.Size = new Size(34, 20);
            label_EMI.TabIndex = 7;
            label_EMI.Text = "EMI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 322);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 8;
            label1.Text = "Total Interest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 370);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Total Amount";
            // 
            // textBox_EMI_Result
            // 
            textBox_EMI_Result.Location = new Point(351, 274);
            textBox_EMI_Result.Name = "textBox_EMI_Result";
            textBox_EMI_Result.Size = new Size(125, 27);
            textBox_EMI_Result.TabIndex = 10;
            // 
            // textBox_TotalInterest_Result
            // 
            textBox_TotalInterest_Result.Location = new Point(351, 319);
            textBox_TotalInterest_Result.Name = "textBox_TotalInterest_Result";
            textBox_TotalInterest_Result.Size = new Size(125, 27);
            textBox_TotalInterest_Result.TabIndex = 11;
            // 
            // textBox_TotalAmount_Result
            // 
            textBox_TotalAmount_Result.Location = new Point(351, 367);
            textBox_TotalAmount_Result.Name = "textBox_TotalAmount_Result";
            textBox_TotalAmount_Result.Size = new Size(125, 27);
            textBox_TotalAmount_Result.TabIndex = 12;
            
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 404);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(671, 287);
            dataGridView.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 703);
            Controls.Add(dataGridView);
            Controls.Add(textBox_TotalAmount_Result);
            Controls.Add(textBox_TotalInterest_Result);
            Controls.Add(textBox_EMI_Result);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_EMI);
            Controls.Add(textBox_Tenure);
            Controls.Add(textBox_Interest);
            Controls.Add(textBox_Principle);
            Controls.Add(label_Tenure);
            Controls.Add(label_Interest);
            Controls.Add(label_Principle);
            Controls.Add(btn_Calculate);
            Name = "Form1";
            Text = "EMI Calculator";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calculate;
        private Label label_Principle;
        private Label label_Interest;
        private Label label_Tenure;
        private TextBox textBox_Principle;
        private TextBox textBox_Interest;
        private TextBox textBox_Tenure;
        private Label label_EMI;
        private Label label1;
        private Label label2;
        private TextBox textBox_EMI_Result;
        private TextBox textBox_TotalInterest_Result;
        private TextBox textBox_TotalAmount_Result;
        private DataGridView dataGridView;
    }
}
