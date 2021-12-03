
namespace MID_09156213_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.multiply = new System.Windows.Forms.RadioButton();
            this.divide = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.output = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(28, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(139, 20);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(29, 16);
            this.plus.TabIndex = 1;
            this.plus.TabStop = true;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(139, 69);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(27, 16);
            this.minus.TabIndex = 2;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(139, 117);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(29, 16);
            this.multiply.TabIndex = 3;
            this.multiply.TabStop = true;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Location = new System.Drawing.Point(139, 168);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(30, 16);
            this.divide.TabIndex = 4;
            this.divide.TabStop = true;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(195, 89);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 33);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MID_09156213_2.Properties.Resources.Equal_symbol_svg;
            this.pictureBox1.Location = new System.Drawing.Point(289, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output.Location = new System.Drawing.Point(342, 84);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(81, 33);
            this.output.TabIndex = 7;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(28, 229);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(428, 46);
            this.calculate_button.TabIndex = 8;
            this.calculate_button.Text = "計算";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 287);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.output);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton multiply;
        private System.Windows.Forms.RadioButton divide;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button calculate_button;
    }
}

