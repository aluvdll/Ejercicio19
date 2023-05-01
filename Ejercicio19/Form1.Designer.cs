namespace Ejercicio19
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBox_ColorDelFormulario = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_lilaForm = new System.Windows.Forms.Button();
            this.btn_verdeForm = new System.Windows.Forms.Button();
            this.btn_ReducirForm = new System.Windows.Forms.Button();
            this.btn_aumentarForm = new System.Windows.Forms.Button();
            this.lbl_prop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numeric_tamañoTXT = new System.Windows.Forms.NumericUpDown();
            this.lbl_color_del_txt = new System.Windows.Forms.GroupBox();
            this.btn_rojoTxt = new System.Windows.Forms.Button();
            this.btn_lilaTexto = new System.Windows.Forms.Button();
            this.btn_verdeTexto = new System.Windows.Forms.Button();
            this.lbl_TamañTxt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.check_Subrayado = new System.Windows.Forms.CheckBox();
            this.check_Cursiva = new System.Windows.Forms.CheckBox();
            this.chek_Negrita = new System.Windows.Forms.CheckBox();
            this.btn_resetearTxt = new System.Windows.Forms.Button();
            this.btn_mostrarTxt = new System.Windows.Forms.Button();
            this.btn_ocultarTxt = new System.Windows.Forms.Button();
            this.lbox_fuentes = new System.Windows.Forms.ListBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gBox_ColorDelFormulario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_tamañoTXT)).BeginInit();
            this.lbl_color_del_txt.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gBox_ColorDelFormulario);
            this.panel1.Controls.Add(this.btn_ReducirForm);
            this.panel1.Controls.Add(this.btn_aumentarForm);
            this.panel1.Controls.Add(this.lbl_prop);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 260);
            this.panel1.TabIndex = 0;
            // 
            // gBox_ColorDelFormulario
            // 
            this.gBox_ColorDelFormulario.Controls.Add(this.button1);
            this.gBox_ColorDelFormulario.Controls.Add(this.btn_lilaForm);
            this.gBox_ColorDelFormulario.Controls.Add(this.btn_verdeForm);
            this.gBox_ColorDelFormulario.Location = new System.Drawing.Point(39, 138);
            this.gBox_ColorDelFormulario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_ColorDelFormulario.Name = "gBox_ColorDelFormulario";
            this.gBox_ColorDelFormulario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_ColorDelFormulario.Size = new System.Drawing.Size(219, 102);
            this.gBox_ColorDelFormulario.TabIndex = 3;
            this.gBox_ColorDelFormulario.TabStop = false;
            this.gBox_ColorDelFormulario.Text = "Color del formulario";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(147, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_lilaForm
            // 
            this.btn_lilaForm.BackColor = System.Drawing.Color.Purple;
            this.btn_lilaForm.ForeColor = System.Drawing.Color.White;
            this.btn_lilaForm.Location = new System.Drawing.Point(84, 43);
            this.btn_lilaForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lilaForm.Name = "btn_lilaForm";
            this.btn_lilaForm.Size = new System.Drawing.Size(34, 35);
            this.btn_lilaForm.TabIndex = 5;
            this.btn_lilaForm.TabStop = false;
            this.btn_lilaForm.UseVisualStyleBackColor = false;
            this.btn_lilaForm.Click += new System.EventHandler(this.btn_lilaForm_Click);
            // 
            // btn_verdeForm
            // 
            this.btn_verdeForm.BackColor = System.Drawing.Color.Green;
            this.btn_verdeForm.ForeColor = System.Drawing.Color.White;
            this.btn_verdeForm.Location = new System.Drawing.Point(21, 43);
            this.btn_verdeForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verdeForm.Name = "btn_verdeForm";
            this.btn_verdeForm.Size = new System.Drawing.Size(34, 35);
            this.btn_verdeForm.TabIndex = 4;
            this.btn_verdeForm.TabStop = false;
            this.btn_verdeForm.UseVisualStyleBackColor = false;
            this.btn_verdeForm.Click += new System.EventHandler(this.btn_verdeForm_Click);
            // 
            // btn_ReducirForm
            // 
            this.btn_ReducirForm.Location = new System.Drawing.Point(226, 85);
            this.btn_ReducirForm.Name = "btn_ReducirForm";
            this.btn_ReducirForm.Size = new System.Drawing.Size(144, 46);
            this.btn_ReducirForm.TabIndex = 2;
            this.btn_ReducirForm.Text = "Reducir";
            this.btn_ReducirForm.UseVisualStyleBackColor = true;
            this.btn_ReducirForm.Click += new System.EventHandler(this.btn_ReducirForm_Click);
            // 
            // btn_aumentarForm
            // 
            this.btn_aumentarForm.Location = new System.Drawing.Point(39, 85);
            this.btn_aumentarForm.Name = "btn_aumentarForm";
            this.btn_aumentarForm.Size = new System.Drawing.Size(134, 46);
            this.btn_aumentarForm.TabIndex = 1;
            this.btn_aumentarForm.Text = "Aumentar";
            this.btn_aumentarForm.UseVisualStyleBackColor = true;
            this.btn_aumentarForm.Click += new System.EventHandler(this.btn_aumentarForm_Click);
            // 
            // lbl_prop
            // 
            this.lbl_prop.AutoSize = true;
            this.lbl_prop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prop.Location = new System.Drawing.Point(33, 32);
            this.lbl_prop.Name = "lbl_prop";
            this.lbl_prop.Size = new System.Drawing.Size(197, 22);
            this.lbl_prop.TabIndex = 0;
            this.lbl_prop.Text = "Propiedades del FORM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numeric_tamañoTXT);
            this.panel2.Controls.Add(this.lbl_color_del_txt);
            this.panel2.Controls.Add(this.lbl_TamañTxt);
            this.panel2.Location = new System.Drawing.Point(14, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 260);
            this.panel2.TabIndex = 4;
            // 
            // numeric_tamañoTXT
            // 
            this.numeric_tamañoTXT.Location = new System.Drawing.Point(38, 80);
            this.numeric_tamañoTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_tamañoTXT.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numeric_tamañoTXT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_tamañoTXT.Name = "numeric_tamañoTXT";
            this.numeric_tamañoTXT.Size = new System.Drawing.Size(220, 26);
            this.numeric_tamañoTXT.TabIndex = 4;
            this.numeric_tamañoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_tamañoTXT.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeric_tamañoTXT.ValueChanged += new System.EventHandler(this.numeric_tamañoTXT_ValueChanged);
            // 
            // lbl_color_del_txt
            // 
            this.lbl_color_del_txt.Controls.Add(this.btn_rojoTxt);
            this.lbl_color_del_txt.Controls.Add(this.btn_lilaTexto);
            this.lbl_color_del_txt.Controls.Add(this.btn_verdeTexto);
            this.lbl_color_del_txt.Location = new System.Drawing.Point(39, 138);
            this.lbl_color_del_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_color_del_txt.Name = "lbl_color_del_txt";
            this.lbl_color_del_txt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_color_del_txt.Size = new System.Drawing.Size(219, 102);
            this.lbl_color_del_txt.TabIndex = 3;
            this.lbl_color_del_txt.TabStop = false;
            this.lbl_color_del_txt.Text = "Color del texto";
            // 
            // btn_rojoTxt
            // 
            this.btn_rojoTxt.BackColor = System.Drawing.Color.Red;
            this.btn_rojoTxt.ForeColor = System.Drawing.Color.White;
            this.btn_rojoTxt.Location = new System.Drawing.Point(147, 43);
            this.btn_rojoTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_rojoTxt.Name = "btn_rojoTxt";
            this.btn_rojoTxt.Size = new System.Drawing.Size(34, 35);
            this.btn_rojoTxt.TabIndex = 6;
            this.btn_rojoTxt.TabStop = false;
            this.btn_rojoTxt.UseVisualStyleBackColor = false;
            this.btn_rojoTxt.Click += new System.EventHandler(this.btn_rojoTxt_Click);
            // 
            // btn_lilaTexto
            // 
            this.btn_lilaTexto.BackColor = System.Drawing.Color.Purple;
            this.btn_lilaTexto.ForeColor = System.Drawing.Color.White;
            this.btn_lilaTexto.Location = new System.Drawing.Point(84, 43);
            this.btn_lilaTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lilaTexto.Name = "btn_lilaTexto";
            this.btn_lilaTexto.Size = new System.Drawing.Size(34, 35);
            this.btn_lilaTexto.TabIndex = 5;
            this.btn_lilaTexto.TabStop = false;
            this.btn_lilaTexto.UseVisualStyleBackColor = false;
            this.btn_lilaTexto.Click += new System.EventHandler(this.btn_lilaTexto_Click);
            // 
            // btn_verdeTexto
            // 
            this.btn_verdeTexto.BackColor = System.Drawing.Color.Green;
            this.btn_verdeTexto.ForeColor = System.Drawing.Color.White;
            this.btn_verdeTexto.Location = new System.Drawing.Point(21, 43);
            this.btn_verdeTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verdeTexto.Name = "btn_verdeTexto";
            this.btn_verdeTexto.Size = new System.Drawing.Size(34, 35);
            this.btn_verdeTexto.TabIndex = 4;
            this.btn_verdeTexto.TabStop = false;
            this.btn_verdeTexto.UseVisualStyleBackColor = false;
            this.btn_verdeTexto.Click += new System.EventHandler(this.btn_verdeTexto_Click);
            // 
            // lbl_TamañTxt
            // 
            this.lbl_TamañTxt.AutoSize = true;
            this.lbl_TamañTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TamañTxt.Location = new System.Drawing.Point(33, 32);
            this.lbl_TamañTxt.Name = "lbl_TamañTxt";
            this.lbl_TamañTxt.Size = new System.Drawing.Size(149, 22);
            this.lbl_TamañTxt.TabIndex = 0;
            this.lbl_TamañTxt.Text = "Tamaño del texto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.check_Subrayado);
            this.panel3.Controls.Add(this.check_Cursiva);
            this.panel3.Controls.Add(this.chek_Negrita);
            this.panel3.Controls.Add(this.btn_resetearTxt);
            this.panel3.Controls.Add(this.btn_mostrarTxt);
            this.panel3.Controls.Add(this.btn_ocultarTxt);
            this.panel3.Location = new System.Drawing.Point(14, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 180);
            this.panel3.TabIndex = 4;
            // 
            // check_Subrayado
            // 
            this.check_Subrayado.AutoSize = true;
            this.check_Subrayado.Location = new System.Drawing.Point(444, 118);
            this.check_Subrayado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_Subrayado.Name = "check_Subrayado";
            this.check_Subrayado.Size = new System.Drawing.Size(112, 24);
            this.check_Subrayado.TabIndex = 6;
            this.check_Subrayado.Text = "Subrayado";
            this.check_Subrayado.UseVisualStyleBackColor = true;
            this.check_Subrayado.CheckedChanged += new System.EventHandler(this.check_Subrayado_CheckedChanged);
            // 
            // check_Cursiva
            // 
            this.check_Cursiva.AutoSize = true;
            this.check_Cursiva.Location = new System.Drawing.Point(249, 118);
            this.check_Cursiva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_Cursiva.Name = "check_Cursiva";
            this.check_Cursiva.Size = new System.Drawing.Size(87, 24);
            this.check_Cursiva.TabIndex = 5;
            this.check_Cursiva.Text = "Cursiva";
            this.check_Cursiva.UseVisualStyleBackColor = true;
            this.check_Cursiva.CheckedChanged += new System.EventHandler(this.check_Cursiva_CheckedChanged);
            // 
            // chek_Negrita
            // 
            this.chek_Negrita.AutoSize = true;
            this.chek_Negrita.Location = new System.Drawing.Point(51, 118);
            this.chek_Negrita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chek_Negrita.Name = "chek_Negrita";
            this.chek_Negrita.Size = new System.Drawing.Size(86, 24);
            this.chek_Negrita.TabIndex = 4;
            this.chek_Negrita.Text = "Negrita";
            this.chek_Negrita.UseVisualStyleBackColor = true;
            this.chek_Negrita.CheckedChanged += new System.EventHandler(this.chek_Negrita_CheckedChanged);
            // 
            // btn_resetearTxt
            // 
            this.btn_resetearTxt.Location = new System.Drawing.Point(432, 35);
            this.btn_resetearTxt.Name = "btn_resetearTxt";
            this.btn_resetearTxt.Size = new System.Drawing.Size(144, 46);
            this.btn_resetearTxt.TabIndex = 3;
            this.btn_resetearTxt.Text = "Resetear";
            this.btn_resetearTxt.UseVisualStyleBackColor = true;
            this.btn_resetearTxt.Click += new System.EventHandler(this.btn_resetearTxt_Click);
            // 
            // btn_mostrarTxt
            // 
            this.btn_mostrarTxt.Location = new System.Drawing.Point(225, 35);
            this.btn_mostrarTxt.Name = "btn_mostrarTxt";
            this.btn_mostrarTxt.Size = new System.Drawing.Size(144, 46);
            this.btn_mostrarTxt.TabIndex = 2;
            this.btn_mostrarTxt.Text = "Mostrar Texto";
            this.btn_mostrarTxt.UseVisualStyleBackColor = true;
            this.btn_mostrarTxt.Click += new System.EventHandler(this.btn_mostrarTxt_Click);
            // 
            // btn_ocultarTxt
            // 
            this.btn_ocultarTxt.Location = new System.Drawing.Point(38, 35);
            this.btn_ocultarTxt.Name = "btn_ocultarTxt";
            this.btn_ocultarTxt.Size = new System.Drawing.Size(134, 46);
            this.btn_ocultarTxt.TabIndex = 1;
            this.btn_ocultarTxt.Text = "Ocultar Texto";
            this.btn_ocultarTxt.UseVisualStyleBackColor = true;
            this.btn_ocultarTxt.Click += new System.EventHandler(this.btn_ocultarTxt_Click);
            // 
            // lbox_fuentes
            // 
            this.lbox_fuentes.FormattingEnabled = true;
            this.lbox_fuentes.ItemHeight = 20;
            this.lbox_fuentes.Location = new System.Drawing.Point(744, 15);
            this.lbox_fuentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbox_fuentes.Name = "lbox_fuentes";
            this.lbox_fuentes.Size = new System.Drawing.Size(408, 764);
            this.lbox_fuentes.TabIndex = 5;
            this.lbox_fuentes.DoubleClick += new System.EventHandler(this.lbox_fuentes_SelectedIndexChanged);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.Location = new System.Drawing.Point(355, 315);
            this.lbl_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(330, 260);
            this.lbl_Texto.TabIndex = 6;
            this.lbl_Texto.Text = "TEXTO";
            this.lbl_Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 800);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.lbox_fuentes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TEXTO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBox_ColorDelFormulario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_tamañoTXT)).EndInit();
            this.lbl_color_del_txt.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_aumentarForm;
        private System.Windows.Forms.Label lbl_prop;
        private System.Windows.Forms.GroupBox gBox_ColorDelFormulario;
        private System.Windows.Forms.Button btn_lilaForm;
        private System.Windows.Forms.Button btn_verdeForm;
        private System.Windows.Forms.Button btn_ReducirForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numeric_tamañoTXT;
        private System.Windows.Forms.GroupBox lbl_color_del_txt;
        private System.Windows.Forms.Button btn_rojoTxt;
        private System.Windows.Forms.Button btn_lilaTexto;
        private System.Windows.Forms.Button btn_verdeTexto;
        private System.Windows.Forms.Label lbl_TamañTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox check_Subrayado;
        private System.Windows.Forms.CheckBox check_Cursiva;
        private System.Windows.Forms.CheckBox chek_Negrita;
        private System.Windows.Forms.Button btn_resetearTxt;
        private System.Windows.Forms.Button btn_mostrarTxt;
        private System.Windows.Forms.Button btn_ocultarTxt;
        private System.Windows.Forms.ListBox lbox_fuentes;
        private System.Windows.Forms.Label lbl_Texto;
    }
}

