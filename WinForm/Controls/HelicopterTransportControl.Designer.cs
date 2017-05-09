namespace TransportBD.Controls
{
    partial class HelicopterTransportControl
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
            this.components = new System.ComponentModel.Container();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelCurrentVolume = new System.Windows.Forms.Label();
            this.textBoxCurrentVolume = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelFuelConsumption = new System.Windows.Forms.Label();
            this.labelWear = new System.Windows.Forms.Label();
            this.comboBoxFuelType = new System.Windows.Forms.ComboBox();
            this.labelMark = new System.Windows.Forms.Label();
            this.textBoxFuelConsumption = new System.Windows.Forms.TextBox();
            this.textBoxWear = new System.Windows.Forms.TextBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.labelFuelDensity = new System.Windows.Forms.Label();
            this.textBoxFuelDensity = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(2, 163);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(73, 13);
            this.labelFuelType.TabIndex = 68;
            this.labelFuelType.Text = "Тип топлива:";
            // 
            // labelCurrentVolume
            // 
            this.labelCurrentVolume.AutoSize = true;
            this.labelCurrentVolume.Location = new System.Drawing.Point(2, 111);
            this.labelCurrentVolume.Name = "labelCurrentVolume";
            this.labelCurrentVolume.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentVolume.TabIndex = 67;
            this.labelCurrentVolume.Text = "Объем топлива:";
            // 
            // textBoxCurrentVolume
            // 
            this.textBoxCurrentVolume.Location = new System.Drawing.Point(118, 108);
            this.textBoxCurrentVolume.Name = "textBoxCurrentVolume";
            this.textBoxCurrentVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentVolume.TabIndex = 66;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(118, 82);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 65;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(2, 85);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(58, 13);
            this.labelSpeed.TabIndex = 64;
            this.labelSpeed.Text = "Скорость:";
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(2, 58);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(90, 13);
            this.labelFuelConsumption.TabIndex = 63;
            this.labelFuelConsumption.Text = "Расход топлива:";
            // 
            // labelWear
            // 
            this.labelWear.AutoSize = true;
            this.labelWear.Location = new System.Drawing.Point(2, 32);
            this.labelWear.Name = "labelWear";
            this.labelWear.Size = new System.Drawing.Size(91, 13);
            this.labelWear.TabIndex = 62;
            this.labelWear.Text = "Степень износа:";
            // 
            // comboBoxFuelType
            // 
            this.comboBoxFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuelType.FormattingEnabled = true;
            this.comboBoxFuelType.Items.AddRange(new object[] {
            "Бензин",
            "Дизель",
            "Газ"});
            this.comboBoxFuelType.Location = new System.Drawing.Point(118, 160);
            this.comboBoxFuelType.Name = "comboBoxFuelType";
            this.comboBoxFuelType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFuelType.TabIndex = 61;
            // 
            // labelMark
            // 
            this.labelMark.Location = new System.Drawing.Point(2, 6);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(112, 13);
            this.labelMark.TabIndex = 60;
            this.labelMark.Text = "Марка транспортаж:";
            // 
            // textBoxFuelConsumption
            // 
            this.textBoxFuelConsumption.Location = new System.Drawing.Point(118, 55);
            this.textBoxFuelConsumption.Name = "textBoxFuelConsumption";
            this.textBoxFuelConsumption.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelConsumption.TabIndex = 59;
            // 
            // textBoxWear
            // 
            this.textBoxWear.Location = new System.Drawing.Point(118, 29);
            this.textBoxWear.Name = "textBoxWear";
            this.textBoxWear.Size = new System.Drawing.Size(100, 20);
            this.textBoxWear.TabIndex = 58;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(118, 3);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxMark.TabIndex = 57;
            // 
            // labelFuelDensity
            // 
            this.labelFuelDensity.AutoSize = true;
            this.labelFuelDensity.Location = new System.Drawing.Point(2, 137);
            this.labelFuelDensity.Name = "labelFuelDensity";
            this.labelFuelDensity.Size = new System.Drawing.Size(108, 13);
            this.labelFuelDensity.TabIndex = 70;
            this.labelFuelDensity.Text = "Плотность топлива:";
            // 
            // textBoxFuelDensity
            // 
            this.textBoxFuelDensity.Location = new System.Drawing.Point(118, 134);
            this.textBoxFuelDensity.Name = "textBoxFuelDensity";
            this.textBoxFuelDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelDensity.TabIndex = 69;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // HelicopterTransportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFuelDensity);
            this.Controls.Add(this.textBoxFuelDensity);
            this.Controls.Add(this.labelFuelType);
            this.Controls.Add(this.labelCurrentVolume);
            this.Controls.Add(this.textBoxCurrentVolume);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelFuelConsumption);
            this.Controls.Add(this.labelWear);
            this.Controls.Add(this.comboBoxFuelType);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.textBoxFuelConsumption);
            this.Controls.Add(this.textBoxWear);
            this.Controls.Add(this.textBoxMark);
            this.Name = "HelicopterTransportControl";
            this.Size = new System.Drawing.Size(263, 185);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelCurrentVolume;
        private System.Windows.Forms.TextBox textBoxCurrentVolume;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelFuelConsumption;
        private System.Windows.Forms.Label labelWear;
        private System.Windows.Forms.ComboBox comboBoxFuelType;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.TextBox textBoxFuelConsumption;
        private System.Windows.Forms.TextBox textBoxWear;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label labelFuelDensity;
        private System.Windows.Forms.TextBox textBoxFuelDensity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
