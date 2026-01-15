using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NChapman_Miller_Final_Project
{
    public partial class frmClassInfo : Form
    {
        public frmClassInfo(character_type battleClass)
        {
            InitializeComponent();

            pBoxPlayerIcon.Image = battleClass.Icon;
            lblClassInfo.Text =
               $"{battleClass.Name}\n\n" +
               $"{battleClass.Description}\n\n" +
               $"Damage: {battleClass.Damage}\n" +
               $"Speed: {battleClass.Speed}\n" +
               $"Max Health: {battleClass.MaxHealth}\n" +
               $"Accuracy: {battleClass.Accuracy}";
        }
    }
}
