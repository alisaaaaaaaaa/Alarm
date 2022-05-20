
namespace Будильник
{
    partial class Alarm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CorrectGB = new System.Windows.Forms.GroupBox();
            this.plucbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.indicator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CorrectGB
            // 
            this.CorrectGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CorrectGB.Controls.Add(this.plucbutton);
            this.CorrectGB.Location = new System.Drawing.Point(12, 2);
            this.CorrectGB.Name = "CorrectGB";
            this.CorrectGB.Size = new System.Drawing.Size(776, 60);
            this.CorrectGB.TabIndex = 0;
            this.CorrectGB.TabStop = false;
            // 
            // plucbutton
            // 
            this.plucbutton.Location = new System.Drawing.Point(716, 15);
            this.plucbutton.Name = "plucbutton";
            this.plucbutton.Size = new System.Drawing.Size(40, 35);
            this.plucbutton.TabIndex = 1;
            this.plucbutton.Text = "+";
            this.plucbutton.UseVisualStyleBackColor = true;
            this.plucbutton.Click += new System.EventHandler(this.plucbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indicator,
            this.Time,
            this.Title});
            this.dataGridView1.Location = new System.Drawing.Point(18, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // indicator
            // 
            this.indicator.HeaderText = " Вкл";
            this.indicator.Name = "indicator";
            this.indicator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.indicator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.indicator.Width = 50;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.Width = 150;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.Width = 200;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CorrectGB);
            this.Name = "Alarm";
            this.Text = "Будильник";
            this.CorrectGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CorrectGB;
        private System.Windows.Forms.Button plucbutton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn indicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}

