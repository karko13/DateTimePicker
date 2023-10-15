namespace Date_TimePicker
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
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.vrijeme = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(339, 22);
            this.datum.Name = "datum";
            this.datum.ShowUpDown = true;
            this.datum.Size = new System.Drawing.Size(200, 20);
            this.datum.TabIndex = 0;
            this.datum.ValueChanged += new System.EventHandler(this.datum_ValueChanged);
            // 
            // vrijeme
            // 
            this.vrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vrijeme.Location = new System.Drawing.Point(339, 89);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.ShowUpDown = true;
            this.vrijeme.Size = new System.Drawing.Size(200, 20);
            this.vrijeme.TabIndex = 1;
            this.vrijeme.ValueChanged += new System.EventHandler(this.vrijeme_ValueChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(189, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(81, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Datum polaska:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(186, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Vrijeme polaska:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(189, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 173);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // gumb
            // 
            this.gumb.Location = new System.Drawing.Point(192, 362);
            this.gumb.Name = "gumb";
            this.gumb.Size = new System.Drawing.Size(350, 62);
            this.gumb.TabIndex = 5;
            this.gumb.Text = "Rezerviraj";
            this.gumb.UseVisualStyleBackColor = true;
            this.gumb.Click += new System.EventHandler(this.gumb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.vrijeme);
            this.Controls.Add(this.datum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.DateTimePicker vrijeme;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button gumb;
    }
}

