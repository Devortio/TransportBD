namespace TransportBD.Controls
{
    partial class TransportControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFuelType = new System.Windows.Forms.Label();
            this.comboBoxFuelType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(5, 6);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(73, 13);
            this.labelFuelType.TabIndex = 58;
            this.labelFuelType.Text = "Тип топлива:";
            // 
            // comboBoxFuelType
            // 
            this.comboBoxFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuelType.FormattingEnabled = true;
            this.comboBoxFuelType.Items.AddRange(new object[] {
            "Бензин",
            "Дизель",
            "Газ"});
            this.comboBoxFuelType.Location = new System.Drawing.Point(121, 3);
            this.comboBoxFuelType.Name = "comboBoxFuelType";
            this.comboBoxFuelType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFuelType.TabIndex = 57;
            // 
            // TransportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFuelType);
            this.Controls.Add(this.comboBoxFuelType);
            this.Name = "TransportControl";
            this.Size = new System.Drawing.Size(331, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.ComboBox comboBoxFuelType;
    }
}
