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
            this.iTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.transportControl = new TransportBD.Controls.TransportControl();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cofAddButton
            // 
            this.cofAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cofAddButton.Location = new System.Drawing.Point(114, 235);
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
            this.cofCancelButton.Location = new System.Drawing.Point(195, 235);
            this.cofCancelButton.Name = "cofCancelButton";
            this.cofCancelButton.Size = new System.Drawing.Size(75, 23);
            this.cofCancelButton.TabIndex = 2;
            this.cofCancelButton.Text = "Отмена";
            this.cofCancelButton.UseVisualStyleBackColor = true;
            this.cofCancelButton.Click += new System.EventHandler(this.cofCancelButton_Click);
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
            // transportControl
            // 
            this.transportControl.Location = new System.Drawing.Point(2, 2);
            this.transportControl.Name = "transportControl";
            this.transportControl.Size = new System.Drawing.Size(277, 227);
            this.transportControl.TabIndex = 3;
            // 
            // CreateObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 270);
            this.Controls.Add(this.transportControl);
            this.Controls.Add(this.cofCancelButton);
            this.Controls.Add(this.cofAddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateObjectForm";
            this.Text = "TransportBD";
            ((System.ComponentModel.ISupportInitialize)(this.iTransportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource iTransportBindingSource;
        private System.Windows.Forms.Button cofAddButton;
        private System.Windows.Forms.Button cofCancelButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Controls.TransportControl transportControl;
    }
}