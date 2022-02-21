using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            InitializeComponent();

            string[] lines = File.ReadAllLines(@"c:\temp\arrayfil.csv");

            List<string> sInd = new List<string>();

            StringBuilder sb = new StringBuilder(lines[0]);
            for (int j = 0; j < lines.Length; j++)
            {
                if (j % 3 == 0)
                    sb.Replace(';', ':');

            }

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                string[] fields = lines[i].Split(new char[] { ';' });

                foreach (string item in fields)
                {
                    sInd.Add(item);
                }
            }

            string[] sltArray = sInd.ToArray();


        }
    }
}
