using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;

namespace Danfosh
{
    public partial class Danfosh : Form
    {
        public Danfosh()
        {
            InitializeComponent();
        }

        private void Danfosh_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.nokia_bulbul;
            SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
        }
    }
}