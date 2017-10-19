using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Web;


namespace Minecraft_Server_Manager
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        private void savetoxml()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(Application.StartupPath + "/Servers/" + servername.Text + ".xml", settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("ServerInfo");
            writer.WriteAttributeString("Name", servername.Text);
            writer.WriteAttributeString("Version", serverversion.Text);
            writer.WriteAttributeString("MemoryMin", memorymin.Text);
            writer.WriteAttributeString("MemoryMax", memorymax.Text);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }
        private void XMLRead()
        {
            if (listBoxServers.SelectedItems.Count > 0)
            {
                string selectedoption = listBoxServers.SelectedItem.ToString();
                XmlTextReader reader = new XmlTextReader(Application.StartupPath + "/Servers/" + selectedoption + ".xml");
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "ServerInfo")
                        {
                            label3.Text = (reader.GetAttribute("Name"));
                            label4.Text = (reader.GetAttribute("Version"));
                            label12.Text = "-" + (reader.GetAttribute("MemoryMin")) + " -" + (reader.GetAttribute("MemoryMax"));
                        }
                    }
                }
                reader.Close();
                textBox1.Text = (Application.StartupPath + "/Servers/" + selectedoption + ".xml");
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public static string GetSubstringByString(string a, string b, string c)
        {
            return c.Substring((c.IndexOf(a) + a.Length), (c.IndexOf(b) - c.IndexOf(a) - a.Length));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            memorymin.Items.Add("Xmx1024M");
            memorymin.Items.Add("Xmx2048M");
            memorymin.Items.Add("Xmx3072M");
            memorymin.Items.Add("Xmx4096M");
            memorymin.Items.Add("Xmx5120M");
            memorymin.Items.Add("Xmx6144M");
            memorymin.Items.Add("Xmx8192M");
            
            memorymax.Items.Add("Xmx1024M");
            memorymax.Items.Add("Xmx2048M");
            memorymax.Items.Add("Xmx3072M");
            memorymax.Items.Add("Xmx4096M");
            memorymax.Items.Add("Xmx5120M");
            memorymax.Items.Add("Xmx6144M");
            memorymax.Items.Add("Xmx8192M");
            panelEx2.Visible = false;
            panelEx3.Visible = false;
            btnRunServer.Enabled = false;
            btnPlugins.Enabled = false;
            btnDeleteServer.Enabled = false;
            btnOpenServerFolder.Enabled = false;            
            if (!Directory.Exists(Application.StartupPath + "/Servers/"))
            {
                Directory.CreateDirectory(Application.StartupPath + "/Servers/");
            }
            else
            {
                string path = (Application.StartupPath + "/Servers/");
                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    string newfile = GetSubstringByString("", ".", file.ToString());
                    listBoxServers.Items.Add(newfile);
                }

                string path2 = (Application.StartupPath + "/jars/");
                System.IO.DirectoryInfo dii = new DirectoryInfo(path2);

                foreach (FileInfo file2 in dii.GetFiles())
                {
                    string newfile2 = GetSubstringByString("", "-", file2.ToString());
                    serverversion.Items.Add(newfile2);
                }
            }
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            panelEx2.Visible = true;
        }

        private void btnEditServer_Click(object sender, EventArgs e)
        {
        }

        public bool isDirectoryContainFiles(string path)
        {
            if (!Directory.Exists(path)) return false;
            return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).Any();
        }

        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a server first", "ERROR!");
            }
            else
            {
                string selectedoption2 = listBoxServers.SelectedItem.ToString();
                string path2 = (Application.StartupPath + "/Servers/" + "/" + selectedoption2 + "/");
                System.IO.DirectoryInfo dii = new DirectoryInfo(path2);

                clearFolder(path2);
                if (File.Exists(Application.StartupPath + "/Servers/" + "/" + selectedoption2 + ".xml"))
                {
                    File.Delete(Application.StartupPath + "/Servers/" + "/" + selectedoption2 + ".xml");
                }
                listBoxServers.Items.Remove(selectedoption2);
                label3.Text = "";
                label4.Text = "";
                label7.Text = "";
                label12.Text = "";
                textBox1.Text = "";

                btnRunServer.Enabled = false;
                btnPlugins.Enabled = false;
                btnDeleteServer.Enabled = false;
                btnOpenServerFolder.Enabled = false;      
            }
        }

        private void btnRunServer_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a server first", "ERROR!");
            }
            else
            {
                string versionjar = label4.Text + "-.jar";
                string selectedoption = listBoxServers.SelectedItem.ToString();
                if (File.Exists(Application.StartupPath + "/jars/" + versionjar) && !File.Exists(Application.StartupPath + "/Servers/" + selectedoption + "/eula.txt"))
                {
                    File.Copy(Application.StartupPath + "/jars/" + versionjar, Application.StartupPath + "/Servers/" + selectedoption + "/" + versionjar);
                    File.Copy(Application.StartupPath + "/jars/Files/" + "/eula.txt", Application.StartupPath + "/Servers/" + selectedoption + "/eula.txt");

                    Process process1 = new Process();
                    process1.StartInfo.FileName = "java";
                    process1.StartInfo.WorkingDirectory = (Application.StartupPath + @"\Servers\" + @"\" + selectedoption + @"\");
                    process1.StartInfo.UseShellExecute = false;
                    process1.StartInfo.Arguments = "" + memorymin.Text + " " + memorymax.Text + " -jar " + versionjar + " nogui";
                    process1.Start();
                    process1.Dispose();
                }
                else
                {
                    MessageBox.Show("Error when getting the Server.jar");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((servername.Text == "") || (serverversion.Text == "") || (memorymin.Text == "") || (memorymax.Text == ""))
            {
                MessageBox.Show("Fill out all the boxs", "ERROR!");
                return;
            }
            savetoxml();
            
            if (!Directory.Exists(Application.StartupPath + "/Servers/" + servername.Text))
            {
                Directory.CreateDirectory(Application.StartupPath + "/Servers/" + servername.Text);
            }
            if (!Directory.Exists(Application.StartupPath + "/Servers/" + servername.Text + "/plugins/"))
            {
                Directory.CreateDirectory(Application.StartupPath + "/Servers/" + servername.Text + "/plugins/");
            }
            listBoxServers.Items.Add(servername.Text);
            panelEx2.Visible = false;
            servername.Text = "";
            serverversion.Text = "";
            memorymin.Text = "";
            memorymax.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            panelEx2.Visible = false;
            servername.Text = "";
            serverversion.Text = "";
            memorymin.Text = "";
            memorymax.Text = "";
        }

        private void btnPlugins_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a server first", "ERROR!");
            }
            else
            {
                if (label4.Text.Contains("CraftBukkit") || label4.Text.Contains("Bukkit") || label4.Text.Contains("Spigot"))
                {
                    string selectedoption = listBoxServers.SelectedItem.ToString();
                    if (!Directory.Exists(Application.StartupPath + "/Servers/" + selectedoption))
                    {
                        MessageBox.Show("Problem when finding the server!", "ERROR!");
                    }
                    else
                    {
                        string path = (Application.StartupPath + "/Servers/"+ label3.Text +"/plugins/");
                        System.IO.DirectoryInfo di = new DirectoryInfo(path);
                        foreach (FileInfo file in di.GetFiles())
                        {
                            string newfile = GetSubstringByString("", ".", file.ToString());
                            listBox2.Items.Add(newfile);
                        }
                        panelEx3.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Not a CraftBukkit Server!", "ERROR!");
                }
            }
        }

        private void listBoxServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServers.Items.Count > 0)
            { 
                XMLRead();
            }
            btnRunServer.Enabled = true;
            btnOpenServerFolder.Enabled = true;
            btnDeleteServer.Enabled = true;
            if (label4.Text.Contains("CraftBukkit") || label4.Text.Contains("Bukkit") || label4.Text.Contains("Spigot"))
                btnPlugins.Enabled = true;
            else
            {
                btnPlugins.Enabled = false;
            }
        }

        private void btnOpenServerFolder_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a server first", "ERROR!");
            }
            else
            {
                string selectedoption3 = listBoxServers.SelectedItem.ToString();
                Process.Start(Application.StartupPath + "/Servers/" + selectedoption3 + "/");
            }
        }
        private void btnAddPlugin_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Plugin Jar";
                dlg.Filter = "jar files (*.jar)|*.jar";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(Application.StartupPath + "/Servers/" + label3.Text + "/plugins/" + dlg.SafeFileName))
                    {
                        File.Copy(dlg.FileName, Application.StartupPath + "/Servers/"+ label3.Text +"/plugins/" + dlg.SafeFileName);
                        listBox2.Items.Add(dlg.SafeFileName);
                    }
                    else{
                        MessageBox.Show("Plugin Already Added!", "ERROR!");
                    }
                }
            }
        }

        private void btnDeletePlugin2_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a server first", "ERROR!");
            }
            else
            {
                string selectedoption3 = listBox2.SelectedItem.ToString();
                if (File.Exists(Application.StartupPath + "/Servers/" + label3.Text + "/plugins/" + selectedoption3))
                {
                    File.Delete(Application.StartupPath + "/Servers/" + label3.Text + "/plugins/" + selectedoption3);
                    String Plugin_Name = GetSubstringByString("", ".jar", Application.StartupPath + "/Servers/" + label3.Text + "/plugins/" + selectedoption3);
                    if (Directory.Exists(Application.StartupPath + "/Servers/" + label3.Text + "/plugins/" + Plugin_Name))
                        Directory.Delete(Application.StartupPath + "/Servers/" + label3.Text + "/plugins/" + Plugin_Name);
                    listBox2.Items.Remove(selectedoption3);
                }
                else
                {
                    MessageBox.Show("Plugin Not found!", "ERROR!");
                    listBox2.Items.Remove(selectedoption3);
                }
            }
        }

        private void btnPluginOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/Servers/" + label3.Text + "/plugins/");
        }

        private void btnClosePlugin_Click(object sender, EventArgs e)
        {
            panelEx3.Visible = false;
            listBox2.Items.Clear();
        }
    }
}
