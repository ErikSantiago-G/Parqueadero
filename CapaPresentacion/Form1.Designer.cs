namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnIngreso = new Button();
            btnSalida = new Button();
            tbPlacaIngreso = new TextBox();
            tbPlacaSalida = new TextBox();
            cbTipoVehiculoIngreso = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 48);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 78);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo Vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingreso Vehiculo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 157);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Salida Vehiculo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 192);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Placa";
            // 
            // btnIngreso
            // 
            btnIngreso.Location = new Point(76, 108);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(155, 23);
            btnIngreso.TabIndex = 5;
            btnIngreso.Text = "Ingresar vehiculo";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(76, 230);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(155, 23);
            btnSalida.TabIndex = 6;
            btnSalida.Text = "Salida vehiculo";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // tbPlacaIngreso
            // 
            tbPlacaIngreso.Location = new Point(117, 40);
            tbPlacaIngreso.Name = "tbPlacaIngreso";
            tbPlacaIngreso.Size = new Size(139, 23);
            tbPlacaIngreso.TabIndex = 7;
            // 
            // tbPlacaSalida
            // 
            tbPlacaSalida.Location = new Point(117, 184);
            tbPlacaSalida.Name = "tbPlacaSalida";
            tbPlacaSalida.Size = new Size(139, 23);
            tbPlacaSalida.TabIndex = 9;
            // 
            // cbTipoVehiculoIngreso
            // 
            cbTipoVehiculoIngreso.FormattingEnabled = true;
            cbTipoVehiculoIngreso.Items.AddRange(new object[] { "Automovil", "Motocicleta" });
            cbTipoVehiculoIngreso.Location = new Point(117, 70);
            cbTipoVehiculoIngreso.Name = "cbTipoVehiculoIngreso";
            cbTipoVehiculoIngreso.Size = new Size(139, 23);
            cbTipoVehiculoIngreso.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 291);
            Controls.Add(cbTipoVehiculoIngreso);
            Controls.Add(tbPlacaSalida);
            Controls.Add(tbPlacaIngreso);
            Controls.Add(btnSalida);
            Controls.Add(btnIngreso);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Parqueadero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnIngreso;
        private Button btnSalida;
        private TextBox tbPlacaIngreso;
        private TextBox tbPlacaSalida;
        private ComboBox cbTipoVehiculoIngreso;
    }
}
