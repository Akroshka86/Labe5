
namespace Лаб5
{
    partial class Form3
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuctionPowerBox = new System.Windows.Forms.TextBox();
            this.CapacityBox = new System.Windows.Forms.TextBox();
            this.BrightnessBox = new System.Windows.Forms.TextBox();
            this.VoltageBox = new System.Windows.Forms.TextBox();
            this.PowerBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuctionPower = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.Label();
            this.Brightness = new System.Windows.Forms.Label();
            this.Voltage = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Cancel.Location = new System.Drawing.Point(210, 302);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(181, 50);
            this.Cancel.TabIndex = 32;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.OK.Location = new System.Drawing.Point(49, 302);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(89, 50);
            this.OK.TabIndex = 31;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SuctionPowerBox
            // 
            this.SuctionPowerBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.SuctionPowerBox.Location = new System.Drawing.Point(210, 248);
            this.SuctionPowerBox.Name = "SuctionPowerBox";
            this.SuctionPowerBox.Size = new System.Drawing.Size(181, 31);
            this.SuctionPowerBox.TabIndex = 30;
            // 
            // CapacityBox
            // 
            this.CapacityBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.CapacityBox.Location = new System.Drawing.Point(210, 211);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(181, 31);
            this.CapacityBox.TabIndex = 29;
            // 
            // BrightnessBox
            // 
            this.BrightnessBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.BrightnessBox.Location = new System.Drawing.Point(210, 174);
            this.BrightnessBox.Name = "BrightnessBox";
            this.BrightnessBox.Size = new System.Drawing.Size(181, 31);
            this.BrightnessBox.TabIndex = 28;
            // 
            // VoltageBox
            // 
            this.VoltageBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.VoltageBox.Location = new System.Drawing.Point(210, 137);
            this.VoltageBox.Name = "VoltageBox";
            this.VoltageBox.Size = new System.Drawing.Size(181, 31);
            this.VoltageBox.TabIndex = 27;
            // 
            // PowerBox
            // 
            this.PowerBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.PowerBox.Location = new System.Drawing.Point(210, 100);
            this.PowerBox.Name = "PowerBox";
            this.PowerBox.Size = new System.Drawing.Size(181, 31);
            this.PowerBox.TabIndex = 26;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.NameBox.Location = new System.Drawing.Point(210, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(181, 31);
            this.NameBox.TabIndex = 25;
            // 
            // SuctionPower
            // 
            this.SuctionPower.AutoSize = true;
            this.SuctionPower.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.SuctionPower.Location = new System.Drawing.Point(32, 248);
            this.SuctionPower.Name = "SuctionPower";
            this.SuctionPower.Size = new System.Drawing.Size(148, 26);
            this.SuctionPower.TabIndex = 24;
            this.SuctionPower.Text = "SuctionPower";
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Capacity.Location = new System.Drawing.Point(32, 211);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(95, 26);
            this.Capacity.TabIndex = 23;
            this.Capacity.Text = "Capacity";
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Brightness.Location = new System.Drawing.Point(32, 174);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(115, 26);
            this.Brightness.TabIndex = 22;
            this.Brightness.Text = "Brightness";
            // 
            // Voltage
            // 
            this.Voltage.AutoSize = true;
            this.Voltage.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Voltage.Location = new System.Drawing.Point(32, 137);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(84, 26);
            this.Voltage.TabIndex = 21;
            this.Voltage.Text = "Voltage";
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Power.Location = new System.Drawing.Point(32, 100);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(74, 26);
            this.Power.TabIndex = 20;
            this.Power.Text = "Power";
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Names.Location = new System.Drawing.Point(32, 63);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(69, 26);
            this.Names.TabIndex = 19;
            this.Names.Text = "Name";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Class.Location = new System.Drawing.Point(32, 23);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(60, 26);
            this.Class.TabIndex = 18;
            this.Class.Text = "Class";
            // 
            // ClassBox
            // 
            this.ClassBox.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Items.AddRange(new object[] {
            "Desk Lamp",
            "Refrigerator",
            "Vacuum Cleaner"});
            this.ClassBox.Location = new System.Drawing.Point(210, 23);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(181, 34);
            this.ClassBox.TabIndex = 17;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 381);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.SuctionPowerBox);
            this.Controls.Add(this.CapacityBox);
            this.Controls.Add(this.BrightnessBox);
            this.Controls.Add(this.VoltageBox);
            this.Controls.Add(this.PowerBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SuctionPower);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.Voltage);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.ClassBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox SuctionPowerBox;
        private System.Windows.Forms.TextBox CapacityBox;
        private System.Windows.Forms.TextBox BrightnessBox;
        private System.Windows.Forms.TextBox VoltageBox;
        private System.Windows.Forms.TextBox PowerBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label SuctionPower;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Label Voltage;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox ClassBox;
    }
}