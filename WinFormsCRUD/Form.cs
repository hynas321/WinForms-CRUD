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
using System.Xml.Linq;

namespace CRUDXmlFile
{
    public partial class Form : System.Windows.Forms.Form
    {
        private XDocument xmlDocument;
        private string filePath;
        public Form()
        {
            InitializeComponent();
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            SaveButton.Enabled = false;
            UpdateButton.Enabled = false;
            FileTextBox.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void FileDialog(string filter, string title, TextBox textbox)
        {
            var ofd = new OpenFileDialog();

            ofd.Filter = filter;
            ofd.Title = title;
            ofd.ShowDialog(this);
            filePath = ofd.FileName;
            textbox.Text = Path.GetFileName(ofd.FileName);
        }

        private void ChooseXMLButton_Click(object sender, EventArgs e)
        {
            FileDialog("XML Files|*.xml", "Choose an XML file", FileTextBox);
            try
            {
                LoadData();
                AddButton.Enabled = true;
                DeleteButton.Enabled = true;
                SaveButton.Enabled = true;
                UpdateButton.Enabled = true;
                dataGridView1.Enabled = true;
            }
            catch { }
        }

        public void LoadData()
        {
            xmlDocument = XDocument.Load(filePath);
            var data = xmlDocument.Descendants("state").Select(p => new
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

        private void ClickAddButton(object sender, EventArgs e)
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

        private void ClickSaveButton(object sender, EventArgs e)
        {
            XElement emp = 
                new XElement("state",
                new XElement("id", IdTextBox.Text),
                new XElement("name", NameTextBox.Text),
                new XElement("governor", GovernorTextBox.Text),
                new XElement("area", AreaTextBox.Text),
                new XElement("minimumwage", MinimumWageTextBox.Text),
                new XElement("timezone", TimeZoneTextBox.Text));

            xmlDocument.Root.Add(emp);
            xmlDocument.Save(filePath);
            LoadData();
            ClickAddButton(null, null);
        }

        private void ClickUpdateButton(object sender, EventArgs e)
        {
            XElement emp = xmlDocument.Descendants("state").FirstOrDefault(p => p.Element("id").Value == IdTextBox.Text);

            if (emp != null)
            {
                emp.Element("name").Value = NameTextBox.Text;
                emp.Element("governor").Value = GovernorTextBox.Text;
                emp.Element("area").Value = AreaTextBox.Text;
                emp.Element("minimumwage").Value = MinimumWageTextBox.Text;
                emp.Element("timezone").Value = TimeZoneTextBox.Text; ;          
                xmlDocument.Save(filePath);
                LoadData();
                ClickAddButton(null, null);
            }
        }

        private void ClickDeleteButton(object sender, EventArgs e)
        {
            XElement emp = xmlDocument.Descendants("state").FirstOrDefault(p => p.Element("id").Value == IdTextBox.Text);

            if (emp != null)
            {
                emp.Remove();
                xmlDocument.Save(filePath);
                LoadData();
                ClickAddButton(null, null);
            }
        }
    }
}
