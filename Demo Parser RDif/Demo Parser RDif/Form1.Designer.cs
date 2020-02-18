namespace Demo_Parser_RDif
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
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonParse
            // 
            this.buttonParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParse.Location = new System.Drawing.Point(499, 454);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(111, 23);
            this.buttonParse.TabIndex = 0;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(12, 24);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(279, 408);
            this.textBox_Input.TabIndex = 2;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(316, 24);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(294, 408);
            this.textBox_Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 489);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.buttonParse);
            this.Name = "Form1";
            this.Text = "Demo Parser Tramas Recarga diferida";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Result;
        }
    }

