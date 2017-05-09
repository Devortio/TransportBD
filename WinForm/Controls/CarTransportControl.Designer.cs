namespace TransportBD.Controls
{
    partial class CarTransportControl
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
            this.labelFuelType = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentVolume
            // 
            this.labelCurrentVolume.AutoSize = true;
            this.labelCurrentVolume.Location = new System.Drawing.Point(5, 115);
            this.labelCurrentVolume.Name = "labelCurrentVolume";
            this.labelCurrentVolume.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentVolume.TabIndex = 55;
            this.labelCurrentVolume.Text = "Объем топлива:";
            // 
            // textBoxCurrentVolume
            // 
            this.textBoxCurrentVolume.Location = new System.Drawing.Point(121, 112);
            this.textBoxCurrentVolume.Name = "textBoxCurrentVolume";
            this.textBoxCurrentVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentVolume.TabIndex = 54;
            this.textBoxCurrentVolume.MouseLeave += new System.EventHandler(this.textBoxCurrentVolume_MouseLeave);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(121, 86);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 53;
            this.textBoxSpeed.MouseLeave += new System.EventHandler(this.textBoxSpeed_MouseLeave);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(5, 89);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(58, 13);
            this.labelSpeed.TabIndex = 52;
            this.labelSpeed.Text = "Скорость:";
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(5, 62);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(90, 13);
            this.labelFuelConsumption.TabIndex = 51;
            this.labelFuelConsumption.Text = "Расход топлива:";
            // 
            // labelWear
            // 
            this.labelWear.AutoSize = true;
            this.labelWear.Location = new System.Drawing.Point(5, 36);
            this.labelWear.Name = "labelWear";
            this.labelWear.Size = new System.Drawing.Size(91, 13);
            this.labelWear.TabIndex = 50;
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
            this.comboBoxFuelType.Location = new System.Drawing.Point(121, 138);
            this.comboBoxFuelType.Name = "comboBoxFuelType";
            this.comboBoxFuelType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFuelType.TabIndex = 49;
            this.comboBoxFuelType.MouseLeave += new System.EventHandler(this.comboBoxFuelType_MouseLeave);
            // 
            // labelMark
            // 
            this.labelMark.Location = new System.Drawing.Point(5, 10);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(112, 13);
            this.labelMark.TabIndex = 48;
            this.labelMark.Text = "Марка транспортаж:";
            // 
            // textBoxFuelConsumption
            // 
            this.textBoxFuelConsumption.Location = new System.Drawing.Point(121, 59);
            this.textBoxFuelConsumption.Name = "textBoxFuelConsumption";
            this.textBoxFuelConsumption.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelConsumption.TabIndex = 47;
            this.textBoxFuelConsumption.MouseLeave += new System.EventHandler(this.textBoxFuelConsumption_MouseLeave);
            // 
            // textBoxWear
            // 
            this.textBoxWear.Location = new System.Drawing.Point(121, 33);
            this.textBoxWear.Name = "textBoxWear";
            this.textBoxWear.Size = new System.Drawing.Size(100, 20);
            this.textBoxWear.TabIndex = 46;
            this.textBoxWear.MouseLeave += new System.EventHandler(this.textBoxWear_MouseLeave);
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(121, 7);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxMark.TabIndex = 45;
            this.textBoxMark.MouseLeave += new System.EventHandler(this.textBoxMark_MouseLeave);
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(5, 141);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(73, 13);
            this.labelFuelType.TabIndex = 56;
            this.labelFuelType.Text = "Тип топлива:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CarTransportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "CarTransportControl";
            this.Size = new System.Drawing.Size(260, 162);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
