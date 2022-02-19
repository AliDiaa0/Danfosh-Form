using System;
using System.Windows.Forms;
using System.Media;

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
