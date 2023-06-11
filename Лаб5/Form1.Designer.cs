
namespace Лаб5
{
    partial class Form1
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
            this.Adddevice = new System.Windows.Forms.Button();
            this.Deletedevice = new System.Windows.Forms.Button();
            this.Editdevice = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Label();
            this.ValuePower = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Adddevice
            // 
            this.Adddevice.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adddevice.Location = new System.Drawing.Point(27, 297);
            this.Adddevice.Name = "Adddevice";
            this.Adddevice.Size = new System.Drawing.Size(108, 37);
            this.Adddevice.TabIndex = 0;
            this.Adddevice.Text = "Add device";
            this.Adddevice.UseVisualStyleBackColor = true;
            this.Adddevice.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deletedevice
            // 
            this.Deletedevice.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletedevice.Location = new System.Drawing.Point(148, 297);
            this.Deletedevice.Name = "Deletedevice";
            this.Deletedevice.Size = new System.Drawing.Size(108, 37);
            this.Deletedevice.TabIndex = 1;
            this.Deletedevice.Text = "Delete device";
            this.Deletedevice.UseVisualStyleBackColor = true;
            this.Deletedevice.Click += new System.EventHandler(this.Deletedevice_Click);
            // 
            // Editdevice
            // 
            this.Editdevice.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editdevice.Location = new System.Drawing.Point(262, 297);
            this.Editdevice.Name = "Editdevice";
            this.Editdevice.Size = new System.Drawing.Size(108, 37);
            this.Editdevice.TabIndex = 2;
            this.Editdevice.Text = "Edit device";
            this.Editdevice.UseVisualStyleBackColor = true;
            this.Editdevice.Click += new System.EventHandler(this.Editdevice_Click);
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Power.Location = new System.Drawing.Point(143, 362);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(25, 26);
            this.Power.TabIndex = 3;
            this.Power.Text = "0";
            // 
            // ValuePower
            // 
            this.ValuePower.AutoSize = true;
            this.ValuePower.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuePower.Location = new System.Drawing.Point(24, 362);
            this.ValuePower.Name = "ValuePower";
            this.ValuePower.Size = new System.Drawing.Size(75, 26);
            this.ValuePower.TabIndex = 4;
            this.ValuePower.Text = "Power";
            this.ValuePower.Click += new System.EventHandler(this.ValuePower_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(27, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 246);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 419);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ValuePower);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Editdevice);
            this.Controls.Add(this.Deletedevice);
            this.Controls.Add(this.Adddevice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adddevice;
        private System.Windows.Forms.Button Deletedevice;
        private System.Windows.Forms.Button Editdevice;
        private System.Windows.Forms.Label ValuePower;
        public System.Windows.Forms.Label Power;
        public System.Windows.Forms.ListBox listBox1;
    }
}

