using Clio.Utilities;
using ff14bot;
using GatherAssist.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatherAssist
{
    public partial class GatherAssist_Form : Form
    {
        public static Vector3 vendorlocationtemp;
        public static GatherAssistSettings settings = GatherAssistSettings.instance;

        public GatherAssist_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            settings.ShardTarget = System.Convert.ToInt32(textBoxShardTarget.Text);
            settings.UpdateIntervalMinutes = System.Convert.ToInt32(textBoxUpdateInterval.Text);
            this.Close();
        }
    }
}