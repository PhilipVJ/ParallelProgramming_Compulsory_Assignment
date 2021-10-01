
namespace ParallelProgramming_Compulsory_Assignment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fromValue = new System.Windows.Forms.TextBox();
            this.toValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.parallelBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.spinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prime Calculator";
            // 
            // fromValue
            // 
            this.fromValue.Location = new System.Drawing.Point(88, 81);
            this.fromValue.Name = "fromValue";
            this.fromValue.Size = new System.Drawing.Size(125, 27);
            this.fromValue.TabIndex = 2;
            // 
            // toValue
            // 
            this.toValue.Location = new System.Drawing.Point(306, 81);
            this.toValue.Name = "toValue";
            this.toValue.Size = new System.Drawing.Size(125, 27);
            this.toValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(250, 295);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(181, 29);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Caulcate in sequential";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(88, 337);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(49, 20);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "Time: ";
            // 
            // parallelBtn
            // 
            this.parallelBtn.Location = new System.Drawing.Point(88, 295);
            this.parallelBtn.Name = "parallelBtn";
            this.parallelBtn.Size = new System.Drawing.Size(156, 29);
            this.parallelBtn.TabIndex = 11;
            this.parallelBtn.Text = "Calculate in Parallel";
            this.parallelBtn.UseVisualStyleBackColor = true;
            this.parallelBtn.Click += new System.EventHandler(this.parallelBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(88, 164);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(343, 116);
            this.resultBox.TabIndex = 12;
            // 
            // spinner
            // 
            this.spinner.Image = ((System.Drawing.Image)(resources.GetObject("spinner.Image")));
            this.spinner.Location = new System.Drawing.Point(203, 386);
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(97, 91);
            this.spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinner.TabIndex = 13;
            this.spinner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 500);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.parallelBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toValue);
            this.Controls.Add(this.fromValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromValue;
        private System.Windows.Forms.TextBox toValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button parallelBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.PictureBox spinner;
    }
}

