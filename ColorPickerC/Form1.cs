using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(portServer.Text);
            varGlobal.alamatIPServer = IPServer.Text;
            SocketTCP.StartListening();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(listenSocket);
            if (IPServer.Text != "")
            {
                thread.Start();
                btnListen.Enabled = false;
            }
            else
            {
                MessageBox.Show("Isi IP Server!!!");
            }
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (varGlobal.ColorServer != null)
            {
                // Menghapus isi TextBox
                redServer.Clear();
                greenServer.Clear();
                blueServer.Clear();

                // Split dari String yang mempunyai Delimiter ,
                string[] receiver = varGlobal.ColorServer.Split(',');

                // Memasukkan nilai ke dalam TextBox lagi
                redServer.Text = receiver[0];
                greenServer.Text = receiver[1];
                blueServer.Text = receiver[2];

                // Memberi warna ke panel di Server
                panelServer.BackColor = Color.FromArgb(int.Parse(receiver[0]), int.Parse(receiver[1]), int.Parse(receiver[2]));
            }
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelWarnaClient.BackColor = colorDialog.Color;
                redClient.Text = colorDialog.Color.R.ToString();
                greenClient.Text = colorDialog.Color.G.ToString();
                blueClient.Text = colorDialog.Color.B.ToString();
                trackRed.Value = colorDialog.Color.R;
                trackGreen.Value = colorDialog.Color.G;
                trackBlue.Value = colorDialog.Color.B;
            }

            varGlobal.ColorClient = trackRed.Value + "," + trackGreen.Value + "," + trackBlue.Value + ",";
            MessageBox.Show("RGB Warnanya adalah: " + varGlobal.ColorClient);
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (IPClient.Text.Equals(""))
                MessageBox.Show("Isi dulu IP Server!");
            else
            {
                varGlobal.port = Int16.Parse(portClient.Text);
                varGlobal.alamatIPServer = IPClient.Text;
                SocketTCP.StartClient(varGlobal.ColorClient);
            }
        }
    }
}
