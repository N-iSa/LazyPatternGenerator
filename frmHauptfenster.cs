using System.IO;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMGenerator
{
    public partial class frmHauptfenster : Form
    {
        private List<Group> _lstGroups;
        private BindingSource _bsGroups;

        public frmHauptfenster()
        {
            InitializeComponent();

            this._lstGroups = new List<Group>();
            this._bsGroups = new BindingSource();

            this.AddTestValues();
            this.loadTemplatenames();

            this._bsGroups.DataSource = this._lstGroups;
            this.dgvTitel.DataSource = this._bsGroups;

            this.dgvKeys.DataSource = this._bsGroups;
            this.dgvKeys.DataMember = "Elements";
            
        }

        private void AddTestValues()
        {
            Group g = new Group("Champion");
            g.Elements.Add(new GroupElement("Name", "string"));
            g.Elements.Add(new GroupElement("ID", "int"));
            g.Elements.Add(new GroupElement("Gold", "int"));
            this._lstGroups.Add(g);
        }

        private void loadTemplatenames()
        {
            string[] strTemplatenames = Directory.GetFiles(@"templates/");
            foreach (string s in strTemplatenames)
            {
                cmbTemplates.Items.Add(s.Split("/")[1]);
            }
            if(strTemplatenames.Length > 0)
            {
                cmbTemplates.SelectedIndex = 0;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach(Group g in this._lstGroups)
            {
                b = Generator.generateFile(cmbTemplates.Text, g);
            }

            MessageBox.Show("Die Datei wurde " + (b ? "erfolgreich" : "nicht") + " angelegt");

        }
    }
}
