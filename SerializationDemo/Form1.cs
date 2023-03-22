using System;

using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\DeptBinary.dat", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtdeptId.Text);
                dept.Name = txtdeptName.Text;
                dept.Location = txtLocation.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Data is Saved");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try { 
             FileStream fs = new FileStream(@"D:\DotNet20Dec\DeptBinary.dat", FileMode.Open, FileAccess.Read);
             Department dept = new Department();
             BinaryFormatter binaryFormatter = new BinaryFormatter();
             dept=(Department)binaryFormatter.Deserialize(fs);
             txtdeptId.Text=dept.Id.ToString();
                txtdeptName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\DeptXML.xml", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtdeptId.Text);
                dept.Name = txtdeptName.Text;
                dept.Location = txtLocation.Text;
                XmlSerializer xmlSerializer= new XmlSerializer(typeof(Department));
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Data is Saved");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try{ 
            FileStream fs = new FileStream(@"D:\DotNet20Dec\DeptXML.xml", FileMode.Open, FileAccess.Read);
            Department dept = new Department();
           XmlSerializer xmlSerializer= new XmlSerializer(typeof(Department));
            dept = (Department)xmlSerializer.Deserialize(fs);
            txtdeptId.Text = dept.Id.ToString();
            txtdeptName.Text = dept.Name.ToString();
            txtLocation.Text = dept.Location;
            fs.Close();


             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\DepSOAP.soap", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtdeptId.Text);
                dept.Name = txtdeptName.Text;
                dept.Location = txtLocation.Text;
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Data is Saved");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\DepSOAP.soap", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                SoapFormatter soapFormatter = new SoapFormatter();
                dept = (Department)soapFormatter.Deserialize(fs);
                txtdeptId.Text = dept.Id.ToString();
                txtdeptName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\DepJSON.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtdeptId.Text);
                dept.Name = txtdeptName.Text;
                dept.Location = txtLocation.Text;
                JsonSerializer.Serialize<Department>(fs,dept);
               
                MessageBox.Show("Data is Saved");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\DepJson.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();

                dept = JsonSerializer.Deserialize<Department>(fs);
                txtdeptId.Text = dept.Id.ToString();
                txtdeptName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
