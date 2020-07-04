using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG_SIM
{
    public partial class SimOutput : Form
    {
        private Pong pong;

        public SimOutput()
        {
            InitializeComponent();

            pong = new Pong(new Size(800, 600));
            this.ClientSize = pong.FieldSize;
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            pong.Tick();
            pbxSim.Invalidate();
        }

        private void pbxSim_Paint(object sender, PaintEventArgs e)
        {
            pong.Render(e.Graphics);
        }

        private void SimOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) pong.MoveLeftBarrier(-10);
            if (e.KeyCode == Keys.S) pong.MoveLeftBarrier(10);
            if (e.KeyCode == Keys.Up) pong.MoveRightBarrier(-10);
            if (e.KeyCode == Keys.Down) pong.MoveRightBarrier(10);
        }
    }
}
