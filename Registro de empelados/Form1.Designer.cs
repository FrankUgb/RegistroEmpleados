
namespace Registro_de_empelados
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
            this.components = new System.ComponentModel.Container();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labeldui = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDui = new System.Windows.Forms.TextBox();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.Registro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textSalario = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textAFP = new System.Windows.Forms.TextBox();
            this.BtAFP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textISSS = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textNeto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(70, 64);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(17, 15);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Id";
            this.labelid.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(70, 113);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(51, 15);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Nombre";
            this.labelnombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeldui
            // 
            this.labeldui.AutoSize = true;
            this.labeldui.Location = new System.Drawing.Point(70, 164);
            this.labeldui.Name = "labeldui";
            this.labeldui.Size = new System.Drawing.Size(26, 15);
            this.labeldui.TabIndex = 2;
            this.labeldui.Text = "DUI";
            this.labeldui.Click += new System.EventHandler(this.label3_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(196, 61);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 23);
            this.textId.TabIndex = 3;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(196, 110);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 4;
            // 
            // textDui
            // 
            this.textDui.Location = new System.Drawing.Point(196, 161);
            this.textDui.Name = "textDui";
            this.textDui.Size = new System.Drawing.Size(100, 23);
            this.textDui.TabIndex = 5;
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(196, 289);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtGuardar.TabIndex = 6;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Location = new System.Drawing.Point(196, 350);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(0, 15);
            this.Registro.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(196, 214);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 23);
            this.textSalario.TabIndex = 9;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(70, 217);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(42, 15);
            this.labelSalario.TabIndex = 8;
            this.labelSalario.Text = "Salario";
            // 
            // textAFP
            // 
            this.textAFP.Location = new System.Drawing.Point(527, 61);
            this.textAFP.Name = "textAFP";
            this.textAFP.Size = new System.Drawing.Size(100, 23);
            this.textAFP.TabIndex = 11;
            // 
            // BtAFP
            // 
            this.BtAFP.Location = new System.Drawing.Point(414, 60);
            this.BtAFP.Name = "BtAFP";
            this.BtAFP.Size = new System.Drawing.Size(75, 23);
            this.BtAFP.TabIndex = 12;
            this.BtAFP.Text = "AFP";
            this.BtAFP.UseVisualStyleBackColor = true;
            this.BtAFP.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ISSS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textISSS
            // 
            this.textISSS.Location = new System.Drawing.Point(527, 110);
            this.textISSS.Name = "textISSS";
            this.textISSS.Size = new System.Drawing.Size(100, 23);
            this.textISSS.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "SalarioNeto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textNeto
            // 
            this.textNeto.Location = new System.Drawing.Point(527, 161);
            this.textNeto.Name = "textNeto";
            this.textNeto.Size = new System.Drawing.Size(100, 23);
            this.textNeto.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textNeto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textISSS);
            this.Controls.Add(this.BtAFP);
            this.Controls.Add(this.textAFP);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.textDui);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labeldui);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labeldui;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDui;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textAFP;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Button BtAFP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textNeto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textISSS;
    }
}

