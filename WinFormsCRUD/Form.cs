using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUDXmlFile
{
    public partial class Form : System.Windows.Forms.Form
    {
        private XDocument xmldoc;
        public Form()
        {
            InitializeComponent();
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            FileTextBox.Enabled = false;
        }

        private void FileDialog(string filter, string title, TextBox textbox)
        {
            var ofd = new OpenFileDialog();

            ofd.Filter = filter;
            ofd.Title = title;
            ofd.ShowDialog(this);

            textbox.Text = ofd.FileName;
        }

        private void ChooseXMLButton_Click(object sender, EventArgs e)
        {
            FileDialog("XML Files|*.xml", "Choose an XML file", FileTextBox);
            try
            {
                LoadData();
                btn_add.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = true;
                btn_update.Enabled = true;
                ChooseXMLButton.Enabled = false;
                dataGridView1.Enabled = true;
            }
            catch { }
        }

        public void LoadData()
        {
            xmldoc = XDocument.Load(FileTextBox.Text);
            var data = xmldoc.Descendants("state").Select(p => new
            {
                id = p.Element("id").Value,
                name = p.Element("name").Value,
                governor = p.Element("governor").Value,
                area = p.Element("area").Value,
                minimumwage = p.Element("minimumwage").Value,
                timezone = p.Element("timezone").Value
            }).OrderBy(p => int.Parse(p.id)).ToList();
           
            IdTextBox.DataBindings.Clear();
            NameTextBox.DataBindings.Clear();
            GovernorTextBox.DataBindings.Clear();
            AreaTextBox.DataBindings.Clear();
            MinimumWageTextBox.DataBindings.Clear();
            TimeZoneTextBox.DataBindings.Clear();

            IdTextBox.DataBindings.Add("text", data, "id");
            NameTextBox.DataBindings.Add("text", data, "name");
            GovernorTextBox.DataBindings.Add("text", data, "governor");
            AreaTextBox.DataBindings.Add("text", data, "area");
            MinimumWageTextBox.DataBindings.Add("text", data, "minimumwage");
            TimeZoneTextBox.DataBindings.Add("text", data, "timezone");
            dataGridView1.DataSource = data;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (var item in group_info.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            IdTextBox.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            XElement emp = 
                new XElement("state",
                new XElement("id", IdTextBox.Text),
                new XElement("name", NameTextBox.Text),
                new XElement("governor", GovernorTextBox.Text),
                new XElement("area", AreaTextBox.Text),
                new XElement("minimumwage", MinimumWageTextBox.Text),
                new XElement("timezone", TimeZoneTextBox.Text));
            xmldoc.Root.Add(emp);
            xmldoc.Save(FileTextBox.Text);
            LoadData();
            btn_add_Click(null, null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            XElement emp = xmldoc.Descendants("state").FirstOrDefault(p => p.Element("id").Value == IdTextBox.Text);
            if (emp != null)
            {
                emp.Element("name").Value = NameTextBox.Text;
                emp.Element("governor").Value = GovernorTextBox.Text;
                emp.Element("area").Value = AreaTextBox.Text;
                emp.Element("minimumwage").Value = MinimumWageTextBox.Text;
                emp.Element("timezone").Value = TimeZoneTextBox.Text; ;          
                xmldoc.Save(FileTextBox.Text);
                LoadData();
                btn_add_Click(null, null);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            XElement emp = xmldoc.Descendants("state").FirstOrDefault(p => p.Element("id").Value == IdTextBox.Text);
            if (emp != null)
            {
                emp.Remove();
                xmldoc.Save(FileTextBox.Text);
                LoadData();
                btn_add_Click(null, null);
            }
        }
    }
}
