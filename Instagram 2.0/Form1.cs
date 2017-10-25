using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            //CODIGO PARA CERRAR LA VENTANA
            Environment.Exit(0);
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            //CODIGO PARA MINIMIZAR LA VENTANA
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized){
                WindowState = FormWindowState.Normal;
            }else{
                WindowState = FormWindowState.Maximized;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:/Users/jhass/Desktop/interfaces/instagram/psg.mp4";
        }

        
    }
}
