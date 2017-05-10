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
            this.labelTransportType = new System.Windows.Forms.Label();
            this.comboBoxTransportType = new System.Windows.Forms.ComboBox();
            this.carTransportControl = new TransportBD.Controls.CarTransportControl();
            this.helicopterTransportControl = new TransportBD.Controls.HelicopterTransportControl();
            this.SuspendLayout();
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Location = new System.Drawing.Point(5, 6);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(90, 13);
            this.labelTransportType.TabIndex = 58;
            this.labelTransportType.Text = "Тип транспорта:";
            // 
            // comboBoxTransportType
            // 
            this.comboBoxTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportType.FormattingEnabled = true;
            this.comboBoxTransportType.Items.AddRange(new object[] {
            "Машина",
            "Вертолет"});
            this.comboBoxTransportType.Location = new System.Drawing.Point(121, 3);
            this.comboBoxTransportType.Name = "comboBoxTransportType";
            this.comboBoxTransportType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTransportType.TabIndex = 57;
            this.comboBoxTransportType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransportType_SelectedIndexChanged);
            // 
            // carTransportControl
            // 
            this.carTransportControl.Location = new System.Drawing.Point(0, 26);
            this.carTransportControl.Name = "carTransportControl";
            this.carTransportControl.Size = new System.Drawing.Size(260, 162);
            this.carTransportControl.TabIndex = 59;
            // 
            // helicopterTransportControl
            // 
            this.helicopterTransportControl.Location = new System.Drawing.Point(3, 33);
            this.helicopterTransportControl.Name = "helicopterTransportControl";
            this.helicopterTransportControl.Size = new System.Drawing.Size(263, 185);
            this.helicopterTransportControl.TabIndex = 60;
            // 
            // TransportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helicopterTransportControl);
            this.Controls.Add(this.carTransportControl);
            this.Controls.Add(this.labelTransportType);
            this.Controls.Add(this.comboBoxTransportType);
            this.Name = "TransportControl";
            this.Size = new System.Drawing.Size(277, 227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.ComboBox comboBoxTransportType;
        private CarTransportControl carTransportControl;
        private HelicopterTransportControl helicopterTransportControl;
    }
}
