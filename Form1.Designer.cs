namespace QPReadWriteRegistry
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
            this.textBoxKeyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWriteKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReadKeyValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReadKeyName = new System.Windows.Forms.TextBox();
            this.ButtonReadKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKeyName
            // 
            this.textBoxKeyName.Location = new System.Drawing.Point(121, 40);
            this.textBoxKeyName.Name = "textBoxKeyName";
            this.textBoxKeyName.Size = new System.Drawing.Size(481, 20);
            this.textBoxKeyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registry Key Name";
            // 
            // textBoxKeyValue
            // 
            this.textBoxKeyValue.Location = new System.Drawing.Point(121, 76);
            this.textBoxKeyValue.Name = "textBoxKeyValue";
            this.textBoxKeyValue.Size = new System.Drawing.Size(112, 20);
            this.textBoxKeyValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registry Key Value";
            // 
            // buttonWriteKey
            // 
            this.buttonWriteKey.Location = new System.Drawing.Point(121, 112);
            this.buttonWriteKey.Name = "buttonWriteKey";
            this.buttonWriteKey.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteKey.TabIndex = 4;
            this.buttonWriteKey.Text = "Write Key";
            this.buttonWriteKey.UseVisualStyleBackColor = true;
            this.buttonWriteKey.Click += new System.EventHandler(this.buttonWriteKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registry Key Value";
            // 
            // textBoxReadKeyValue
            // 
            this.textBoxReadKeyValue.Location = new System.Drawing.Point(121, 202);
            this.textBoxReadKeyValue.Name = "textBoxReadKeyValue";
            this.textBoxReadKeyValue.Size = new System.Drawing.Size(112, 20);
            this.textBoxReadKeyValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registry Key Name";
            // 
            // textBoxReadKeyName
            // 
            this.textBoxReadKeyName.Location = new System.Drawing.Point(121, 166);
            this.textBoxReadKeyName.Name = "textBoxReadKeyName";
            this.textBoxReadKeyName.Size = new System.Drawing.Size(481, 20);
            this.textBoxReadKeyName.TabIndex = 5;
            // 
            // ButtonReadKey
            // 
            this.ButtonReadKey.Location = new System.Drawing.Point(121, 240);
            this.ButtonReadKey.Name = "ButtonReadKey";
            this.ButtonReadKey.Size = new System.Drawing.Size(75, 23);
            this.ButtonReadKey.TabIndex = 9;
            this.ButtonReadKey.Text = "Read Key";
            this.ButtonReadKey.UseVisualStyleBackColor = true;
            this.ButtonReadKey.Click += new System.EventHandler(this.ButtonReadKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReadKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReadKeyValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxReadKeyName);
            this.Controls.Add(this.buttonWriteKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKeyValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKeyName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKeyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWriteKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReadKeyValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReadKeyName;
        private System.Windows.Forms.Button ButtonReadKey;
    }
}

