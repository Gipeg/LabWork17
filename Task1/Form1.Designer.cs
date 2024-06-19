namespace Task1
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
            FIlesdataGridView1 = new DataGridView();
            Task1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)FIlesdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FIlesdataGridView1
            // 
            FIlesdataGridView1.BackgroundColor = SystemColors.Control;
            FIlesdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FIlesdataGridView1.GridColor = SystemColors.Window;
            FIlesdataGridView1.Location = new Point(12, 29);
            FIlesdataGridView1.Name = "FIlesdataGridView1";
            FIlesdataGridView1.Size = new Size(776, 369);
            FIlesdataGridView1.TabIndex = 0;
            FIlesdataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Task1
            // 
            Task1.Location = new Point(37, 415);
            Task1.Name = "Task1";
            Task1.Size = new Size(75, 23);
            Task1.TabIndex = 1;
            Task1.Text = "Task1";
            Task1.UseVisualStyleBackColor = true;
            Task1.Click += Task1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Task2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Task1);
            Controls.Add(FIlesdataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)FIlesdataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FIlesdataGridView1;
        private Button Task1;
        private Button button2;
    }
}
