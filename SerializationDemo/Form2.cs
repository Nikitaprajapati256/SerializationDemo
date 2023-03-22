using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Data.SqlTypes;

namespace SerializationDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdBinary.dat", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtRollno.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToInt32(txtPercentage.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, std);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdBinary.dat", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                std = (Student)binaryFormatter.Deserialize(fs);
                txtName.Text = std.Name.ToString();
                txtPercentage.Text = std.Percentage.ToString();
                txtRollno.Text = std.Rollno.ToString();
                fs.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdXml.xml", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtRollno.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                xmlSerializer.Serialize(fs, std);
                MessageBox.Show("Data saved");
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {

                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdXml.xml", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                XmlSerializer xmlSerializer= new XmlSerializer(typeof(Student));
                std=(Student)xmlSerializer.Deserialize(fs);
                txtRollno.Text = std.Rollno.ToString();
                txtName.Text = std.Name.ToString();
                txtPercentage.Text = std.Percentage.ToString();
                fs.Close();



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdSoap.soap", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, std);
                std.Rollno = Convert.ToInt32(txtRollno.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                MessageBox.Show("Data Saved");
                fs.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdSoap.soap", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                std = (Student)soapFormatter.Deserialize(fs);
                txtRollno.Text = std.Rollno.ToString();
                txtName.Text = std.Name.ToString();
                txtPercentage.Text = std.Percentage.ToString();
                fs.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdJson.json", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtRollno.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToInt32(txtPercentage.Text);
                JsonSerializer.Serialize<Student>(fs, std);

                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20Dec\StdJson.json", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                std= JsonSerializer.Deserialize<Student>(fs);
                txtName.Text = std.Name;
                txtRollno.Text = std.Rollno.ToString();
                txtPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
