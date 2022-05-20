
namespace Будильник
{
    partial class NewAlarm
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
            this.cancel = new System.Windows.Forms.Button();
            this.buttonbox = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 16);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 36);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // buttonbox
            // 
            this.buttonbox.Controls.Add(this.radioButton1);
            this.buttonbox.Controls.Add(this.label2);
            this.buttonbox.Controls.Add(this.textBox1);
            this.buttonbox.Controls.Add(this.label1);
            this.buttonbox.Location = new System.Drawing.Point(66, 250);
            this.buttonbox.Name = "buttonbox";
            this.buttonbox.Size = new System.Drawing.Size(219, 181);
            this.buttonbox.TabIndex = 2;
            this.buttonbox.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(259, 16);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(87, 36);
            this.save.TabIndex = 3;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(114, 164);
            this.time.Mask = "90:00";
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(122, 20);
            this.time.TabIndex = 4;
            this.time.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Повторение сигнала";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вкл";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NewAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 480);
            this.Controls.Add(this.time);
            this.Controls.Add(this.save);
            this.Controls.Add(this.buttonbox);
            this.Controls.Add(this.cancel);
            this.MaximumSize = new System.Drawing.Size(374, 519);
            this.Name = "NewAlarm";
            this.buttonbox.ResumeLayout(false);
            this.buttonbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox buttonbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MaskedTextBox time;
    }
}