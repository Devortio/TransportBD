namespace TransportBD
{
    partial class CreateObjectForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateObjectForm));
            this.cofAddButton = new System.Windows.Forms.Button();
            this.cofCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonHelicopter = new System.Windows.Forms.RadioButton();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.textBoxWear = new System.Windows.Forms.TextBox();
            this.textBoxFuelConsumption = new System.Windows.Forms.TextBox();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelTypeFuel = new System.Windows.Forms.Label();
            this.comboBoxTypeFuel = new System.Windows.Forms.ComboBox();
            this.iTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelWear = new System.Windows.Forms.Label();
            this.labelFuelConsumption = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxCurrentVolume = new System.Windows.Forms.TextBox();
            this.labelCurrentVolume = new System.Windows.Forms.Label();
            this.labelFuelDensity = new System.Windows.Forms.Label();
            this.textBoxFuelDensity = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iTransportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cofAddButton
            // 
            this.cofAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cofAddButton.Location = new System.Drawing.Point(174, 235);
            this.cofAddButton.Name = "cofAddButton";
            this.cofAddButton.Size = new System.Drawing.Size(75, 23);
            this.cofAddButton.TabIndex = 1;
            this.cofAddButton.Text = "Добавить";
            this.cofAddButton.UseVisualStyleBackColor = true;
            this.cofAddButton.Click += new System.EventHandler(this.cofAddButton_Click);
            // 
            // cofCancelButton
            // 
            this.cofCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cofCancelButton.Location = new System.Drawing.Point(255, 235);
            this.cofCancelButton.Name = "cofCancelButton";
            this.cofCancelButton.Size = new System.Drawing.Size(75, 23);
            this.cofCancelButton.TabIndex = 2;
            this.cofCancelButton.Text = "Отмена";
            this.cofCancelButton.UseVisualStyleBackColor = true;
            this.cofCancelButton.Click += new System.EventHandler(this.cofCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите типа объекта:";
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(149, 7);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCar.TabIndex = 4;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Машина";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // radioButtonHelicopter
            // 
            this.radioButtonHelicopter.AutoSize = true;
            this.radioButtonHelicopter.Location = new System.Drawing.Point(240, 7);
            this.radioButtonHelicopter.Name = "radioButtonHelicopter";
            this.radioButtonHelicopter.Size = new System.Drawing.Size(72, 17);
            this.radioButtonHelicopter.TabIndex = 5;
            this.radioButtonHelicopter.TabStop = true;
            this.radioButtonHelicopter.Text = "Вертолет";
            this.radioButtonHelicopter.UseVisualStyleBackColor = true;
            this.radioButtonHelicopter.CheckedChanged += new System.EventHandler(this.radioButtonHelicopter_CheckedChanged);
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(122, 32);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxMark.TabIndex = 6;
            this.textBoxMark.MouseLeave += new System.EventHandler(this.textBoxMark_MouseLeave);
            // 
            // textBoxWear
            // 
            this.textBoxWear.Location = new System.Drawing.Point(122, 58);
            this.textBoxWear.Name = "textBoxWear";
            this.textBoxWear.Size = new System.Drawing.Size(100, 20);
            this.textBoxWear.TabIndex = 8;
            this.textBoxWear.MouseLeave += new System.EventHandler(this.textBoxWear_MouseLeave);
            // 
            // textBoxFuelConsumption
            // 
            this.textBoxFuelConsumption.Location = new System.Drawing.Point(122, 84);
            this.textBoxFuelConsumption.Name = "textBoxFuelConsumption";
            this.textBoxFuelConsumption.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelConsumption.TabIndex = 9;
            this.textBoxFuelConsumption.MouseLeave += new System.EventHandler(this.textBoxFuelConsumption_MouseLeave);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(12, 35);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(101, 13);
            this.labelMark.TabIndex = 10;
            this.labelMark.Text = "Марка транспорта";
            // 
            // labelTypeFuel
            // 
            this.labelTypeFuel.AutoSize = true;
            this.labelTypeFuel.Location = new System.Drawing.Point(12, 166);
            this.labelTypeFuel.Name = "labelTypeFuel";
            this.labelTypeFuel.Size = new System.Drawing.Size(70, 13);
            this.labelTypeFuel.TabIndex = 11;
            this.labelTypeFuel.Text = "Тип топлива";
            // 
            // comboBoxTypeFuel
            // 
            this.comboBoxTypeFuel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTransportBindingSource, "TypeFuel", true));
            this.comboBoxTypeFuel.FormattingEnabled = true;
            this.comboBoxTypeFuel.Items.AddRange(new object[] {
            "Бензин",
            "Дизель",
            "Газ"});
            this.comboBoxTypeFuel.Location = new System.Drawing.Point(122, 163);
            this.comboBoxTypeFuel.Name = "comboBoxTypeFuel";
            this.comboBoxTypeFuel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTypeFuel.TabIndex = 12;
            this.comboBoxTypeFuel.MouseLeave += new System.EventHandler(this.comboBoxTypeFuel_MouseLeave);
            // 
            // iTransportBindingSource
            // 
            this.iTransportBindingSource.DataSource = typeof(Model.ITransport);
            // 
            // labelWear
            // 
            this.labelWear.AutoSize = true;
            this.labelWear.Location = new System.Drawing.Point(12, 61);
            this.labelWear.Name = "labelWear";
            this.labelWear.Size = new System.Drawing.Size(88, 13);
            this.labelWear.TabIndex = 13;
            this.labelWear.Text = "Степень износа";
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(12, 87);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(87, 13);
            this.labelFuelConsumption.TabIndex = 14;
            this.labelFuelConsumption.Text = "Расход топлива";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 114);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(55, 13);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "Скорость";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(122, 111);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 16;
            this.textBoxSpeed.MouseLeave += new System.EventHandler(this.textBoxSpeed_MouseLeave);
            // 
            // textBoxCurrentVolume
            // 
            this.textBoxCurrentVolume.Location = new System.Drawing.Point(122, 137);
            this.textBoxCurrentVolume.Name = "textBoxCurrentVolume";
            this.textBoxCurrentVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentVolume.TabIndex = 17;
            this.textBoxCurrentVolume.MouseLeave += new System.EventHandler(this.textBoxCurrentVolume_MouseLeave);
            // 
            // labelCurrentVolume
            // 
            this.labelCurrentVolume.AutoSize = true;
            this.labelCurrentVolume.Location = new System.Drawing.Point(12, 140);
            this.labelCurrentVolume.Name = "labelCurrentVolume";
            this.labelCurrentVolume.Size = new System.Drawing.Size(86, 13);
            this.labelCurrentVolume.TabIndex = 18;
            this.labelCurrentVolume.Text = "Объем топлива";
            // 
            // labelFuelDensity
            // 
            this.labelFuelDensity.AutoSize = true;
            this.labelFuelDensity.Location = new System.Drawing.Point(12, 193);
            this.labelFuelDensity.Name = "labelFuelDensity";
            this.labelFuelDensity.Size = new System.Drawing.Size(105, 13);
            this.labelFuelDensity.TabIndex = 19;
            this.labelFuelDensity.Text = "Плотность топлива";
            // 
            // textBoxFuelDensity
            // 
            this.textBoxFuelDensity.Location = new System.Drawing.Point(122, 190);
            this.textBoxFuelDensity.Name = "textBoxFuelDensity";
            this.textBoxFuelDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelDensity.TabIndex = 20;
            this.textBoxFuelDensity.MouseLeave += new System.EventHandler(this.textBoxFuelDensity_MouseLeave);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 80;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 270);
            this.Controls.Add(this.textBoxFuelDensity);
            this.Controls.Add(this.labelFuelDensity);
            this.Controls.Add(this.labelCurrentVolume);
            this.Controls.Add(this.textBoxCurrentVolume);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelFuelConsumption);
            this.Controls.Add(this.labelWear);
            this.Controls.Add(this.comboBoxTypeFuel);
            this.Controls.Add(this.labelTypeFuel);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.textBoxFuelConsumption);
            this.Controls.Add(this.textBoxWear);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.radioButtonHelicopter);
            this.Controls.Add(this.radioButtonCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cofCancelButton);
            this.Controls.Add(this.cofAddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateObjectForm";
            this.Text = "TransportBD";
            ((System.ComponentModel.ISupportInitialize)(this.iTransportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource iTransportBindingSource;
        private System.Windows.Forms.Button cofAddButton;
        private System.Windows.Forms.Button cofCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonHelicopter;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.TextBox textBoxWear;
        private System.Windows.Forms.TextBox textBoxFuelConsumption;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelTypeFuel;
        private System.Windows.Forms.ComboBox comboBoxTypeFuel;
        private System.Windows.Forms.Label labelWear;
        private System.Windows.Forms.Label labelFuelConsumption;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxCurrentVolume;
        private System.Windows.Forms.Label labelCurrentVolume;
        private System.Windows.Forms.Label labelFuelDensity;
        private System.Windows.Forms.TextBox textBoxFuelDensity;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}