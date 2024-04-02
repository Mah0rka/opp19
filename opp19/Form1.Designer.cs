namespace opp19
{
    partial class OOP19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OOP19));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label_ans = new Label();
            button_sort = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(245, 40);
            button1.TabIndex = 0;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 1;
            label1.Text = "Додати елемент до масиву";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 48);
            textBox1.MaxLength = 32900;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 33);
            textBox1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(label_ans);
            flowLayoutPanel1.Location = new Point(12, 196);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 125);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label_ans
            // 
            label_ans.AutoSize = true;
            label_ans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_ans.Location = new Point(3, 0);
            label_ans.Name = "label_ans";
            label_ans.Size = new Size(0, 25);
            label_ans.TabIndex = 2;
            // 
            // button_sort
            // 
            button_sort.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_sort.Location = new Point(12, 150);
            button_sort.Name = "button_sort";
            button_sort.Size = new Size(245, 40);
            button_sort.TabIndex = 4;
            button_sort.Text = "Сортувати";
            button_sort.UseVisualStyleBackColor = true;
            button_sort.Click += button_sort_Click;
            // 
            // OOP19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 332);
            Controls.Add(button_sort);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OOP19";
            Text = "OOP19";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label_ans;
        private Button button_sort;
    }
}
