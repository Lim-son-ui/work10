
namespace WindowsFormsApp1
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label_num = new System.Windows.Forms.Label();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "輸入的數為奇數或偶數?";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(39, 42);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(57, 15);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "Number:";
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(126, 42);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(100, 25);
            this.txt_in.TabIndex = 3;
            this.txt_in.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(516, 396);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(46, 15);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "Result:";
            // 
            // txt_out
            // 
            this.txt_out.BackColor = System.Drawing.SystemColors.Info;
            this.txt_out.Location = new System.Drawing.Point(585, 361);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_out.Size = new System.Drawing.Size(202, 50);
            this.txt_out.TabIndex = 3;
            this.txt_out.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "陣列arr0711[]最大/小值";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "陣列0711[]輸入為奇數或偶數";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "                             ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "陣列arr0711_str[]最長的名字";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "陣列arr0711_str[]xue \"C\" or \"c\"的字樣有幾個";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.button1);
            this.Name = "form1";
            this.Tag = "        ";
            this.Text = "homework7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

