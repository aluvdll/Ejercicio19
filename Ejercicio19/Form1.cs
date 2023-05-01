using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        private FontFamily[] fuentes;
       
    public Form1()
        {
            InitializeComponent();
            fuentes = new InstalledFontCollection().Families;
            foreach (FontFamily x in fuentes)
            {
                lbox_fuentes.Items.Add(x.Name);
            }


        }

        private void btn_aumentarForm_Click(object sender, EventArgs e)
        {
            Size = new Size((this.Size.Width + 10), (this.Size.Height + 10));
        }

        private void btn_ReducirForm_Click(object sender, EventArgs e)
        {
            Size = new Size((this.Size.Width + -10), (this.Size.Height + -10));
        }

        private void btn_verdeForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btn_lilaForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void numeric_tamañoTXT_ValueChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = new Font(lbl_Texto.Font.FontFamily, (int) numeric_tamañoTXT.Value);


        }

        private void btn_verdeTexto_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Green;
            
            
        }

        private void btn_lilaTexto_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Purple;
        }

        private void btn_rojoTxt_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Red;
        }

        private void btn_ocultarTxt_Click(object sender, EventArgs e)
        {
            lbl_Texto.Visible = false;
            
        }

        private void btn_mostrarTxt_Click(object sender, EventArgs e)
        {
            lbl_Texto.Visible = true;

        }

        private void btn_resetearTxt_Click(object sender, EventArgs e)
        {
            
            lbl_Texto.Visible = true;
            lbl_Texto.Text = "TEXTO";
            lbl_Texto.ForeColor = Color.Black;
            lbl_Texto.Font = new Font("Microsoft Sans Serif", 8);
            numeric_tamañoTXT.Value = 8;
        }

        private void chek_Negrita_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = chek_Negrita.Checked ? new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Bold) : new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Bold);
        }

        private void check_Cursiva_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = check_Cursiva.Checked ? new Font(lbl_Texto.Font, lbl_Texto.Font.Style| FontStyle.Italic) : new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Italic);
        }

        private void check_Subrayado_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = check_Subrayado.Checked ? new Font(lbl_Texto.Font, lbl_Texto.Font.Style |FontStyle.Underline) : new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Underline);

        }

        private void lbox_fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = new Font(fuentes[lbox_fuentes.SelectedIndex].Name, lbl_Texto.Font.Size);

        }
    }
}
