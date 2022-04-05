using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Exemplo 01
//namespace Projeto62Janelas
//{
//    public partial class F_FilhoCheckBox : Form
//    {

//        public F_PaiCheckBox FPCB; // (FPCB é F_PaiCheckBox).
//        public F_FilhoCheckBox()
//        {
//            InitializeComponent();
//            FPCB = Application.OpenForms["F_PaiCheckBox"] as F_PaiCheckBox;
//            cb_AutoFalante.Checked  = FPCB.cb_AutoFalante.Checked;
//            cb_Baterias.Checked = FPCB.cb_Baterias.Checked;
//            cb_Cornetas.Checked = FPCB.cb_Cornetas.Checked;
//            cb_Modulos.Checked = FPCB.cb_Modulos.Checked;
//        }

//        private void F_FilhoCheckBox_Load(object sender, EventArgs e)
//        {

//        }

//        private void cb_AutoFalante_CheckedChanged(object sender, EventArgs e)
//        {
//            FPCB.cb_AutoFalante.Checked = cb_AutoFalante.Checked;            
//        }

//        private void cb_Baterias_CheckedChanged(object sender, EventArgs e)
//        {
//            FPCB.cb_Baterias.Checked = cb_Baterias.Checked;
//        }

//        private void cb_Cornetas_CheckedChanged(object sender, EventArgs e)
//        {
//            FPCB.cb_Cornetas.Checked = cb_Cornetas.Checked;
//        }

//        private void cb_Modulos_CheckedChanged(object sender, EventArgs e)
//        {
//            FPCB.cb_Modulos.Checked = cb_Modulos.Checked;
//        }
//    }
//}

//Exemplo 02 - Usando o try catch
namespace Projeto62Janelas
{
    public partial class F_FilhoCheckBox : Form
    {

        public F_PaiCheckBox FPCB; // (FPCB é F_PaiCheckBox).
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try
            {
                //Caso mude o Form aparecerá mensagem de erro ao abrir formulário.
                FPCB = Application.OpenForms["F_PaiCheckBox"] as F_PaiCheckBox;  
                cb_AutoFalante.Checked = FPCB.cb_AutoFalante.Checked;
                cb_Baterias.Checked = FPCB.cb_Baterias.Checked;
                cb_Cornetas.Checked = FPCB.cb_Cornetas.Checked;
                cb_Modulos.Checked = FPCB.cb_Modulos.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir formulário");
            }
        }

        private void F_FilhoCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void cb_AutoFalante_CheckedChanged(object sender, EventArgs e)
        {
            FPCB.cb_AutoFalante.Checked = cb_AutoFalante.Checked;
        }

        private void cb_Baterias_CheckedChanged(object sender, EventArgs e)
        {
            FPCB.cb_Baterias.Checked = cb_Baterias.Checked;
        }

        private void cb_Cornetas_CheckedChanged(object sender, EventArgs e)
        {
            FPCB.cb_Cornetas.Checked = cb_Cornetas.Checked;
        }

        private void cb_Modulos_CheckedChanged(object sender, EventArgs e)
        {
            FPCB.cb_Modulos.Checked = cb_Modulos.Checked;
        }
    }
}