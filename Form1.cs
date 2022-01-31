using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamnensprojekt_2022
{
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            this.BackgroundImage = Properties.Resources.phskala;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
        }
    }
}
