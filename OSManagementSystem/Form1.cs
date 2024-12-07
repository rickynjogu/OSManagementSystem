using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;




namespace OSManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void processControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deviceListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void memoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void processListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void fileListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void storageListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//btnListFiles
        {
            listBoxResults.Items.Clear();//clearing previous results
            string path = folderCreationPath.Text; //Using floderCreatePath box to specify the directory
            try
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        listBoxResults.Items.Add(file);//Add each file to the list box
                    }
                }
                else
                {
                    MessageBox.Show("Directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a File to Read",
                Filter = "Text Files|*.txt|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string content = File.ReadAllText(filePath);
                    MessageBox.Show(content, "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            // Get the file path from a TextBox
            string filePath = fileCreationPath.Text;

            // Check if the path is valid and not empty
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if the file already exists
                if (!File.Exists(filePath))
                {
                    // Create the file
                    using (FileStream fs = File.Create(filePath))
                    {
                        // Optionally, write some default content
                        byte[] defaultContent = new UTF8Encoding(true).GetBytes("New file created.");
                        fs.Write(defaultContent, 0, defaultContent.Length);
                    }
                    MessageBox.Show("File created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File already exists at the specified path.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and provide feedback
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            // Get the folder path from a TextBox
            string folderPath = folderCreationPath.Text;

            // Check if the path is valid and not empty
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                MessageBox.Show("Please enter a valid folder path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if the folder already exists
                if (!Directory.Exists(folderPath))
                {
                    // Create the folder
                    Directory.CreateDirectory(folderPath);
                    MessageBox.Show("Folder created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Folder already exists at the specified path.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and provide feedback
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListDirectories_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();//Clearing prevois results
            string path = folderCreationPath.Text;//use folderCreationPath to specify roor dir
            try
            {
                if (!Directory.Exists(path))
                {
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string dir in dirs)
                    {
                        listBoxResults.Items.Add(dir);//Add each directory to the list box
                    }
                }
                else
                {
                    MessageBox.Show("Directory does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)//btnFileProperties
        {
            String path = fileCreationPath.Text;//Using our create file text box to specify the file path
            listBoxResults.Items.Clear();//clear previous results
            try
            {
                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    listBoxResults.Items.Add("File Name: " + fileInfo.Name);
                    listBoxResults.Items.Add("Full Path: " + fileInfo.FullName);
                    listBoxResults.Items.Add("Size: " + fileInfo.Length + "bytes");
                    listBoxResults.Items.Add("Created: " + fileInfo.CreationTime);
                    listBoxResults.Items.Add("Last Accessed: " + fileInfo.LastAccessTime);
                    listBoxResults.Items.Add("Last modified: " + fileInfo.LastWriteTime);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//List drives btn
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select a Directory to Delete"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string dirPath = folderBrowserDialog.SelectedPath;

                try
                {
                    Directory.Delete(dirPath, true); // true -> Recursively delete directory and contents.
                    MessageBox.Show("Directory deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//Closing the from
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateProcessList();
        }
        private void populateProcessList()
        {
            comboBox1.Items.Clear();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                comboBox1.Items.Add(process.ProcessName);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("winword");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting word" + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro in starting calculator: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("excel");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting Excel:" + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting Notepad" + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Are you sure you want to kill the process {comboBox1.Text}",
                "Confirm kill",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (var process in Process.GetProcessesByName(comboBox1.Text))
                    {
                        process.Kill();
                    }
                    MessageBox.Show("Process Killed successfully!");
                    populateProcessList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ErrorBlinkStyle killing process" + ex.Message);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getdrive()
        {
            listBox1.Items.Clear();
            foreach (DriveInfo drinfo in DriveInfo.GetDrives())
            {
                if (drinfo.IsReady)
                {
                    string driveInfo = $"Drive Name: {drinfo.Name}\n" +
                                     $"Volume Label:{drinfo.VolumeLabel}\n" +
                                     $"Drive Type: {drinfo.DriveType}\n" +
                                     $"Total Size {drinfo.TotalSize / 1073741824} GB\n" +
                                     $"Free Space: {drinfo.TotalFreeSpace / 1073741824} GB";
                    listBox1.Items.Add(driveInfo);
                }
                else
                {
                    listBox1.Items.Add($"Drive {drinfo.Name} is not ready");
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void showDriveInfo()
        {
            richTextBox1.Clear();
            foreach (DriveInfo drinfo in DriveInfo.GetDrives())
            {
                if (drinfo.IsReady)
                {
                    richTextBox1.AppendText($"Drive Name: {drinfo.Name}\n" +
                                     $"Volume Label:{drinfo.VolumeLabel}\n" +
                                     $"Drive Type: {drinfo.DriveType}\n" +
                                     $"Total Size {drinfo.TotalSize / 1073741824} GB\n" +
                                     $"Free Space: {drinfo.TotalFreeSpace / 1073741824} GB");

                }
                else
                {
                    richTextBox1.AppendText($"Drive {drinfo.Name} is not ready");
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            getdrive();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showDriveInfo();
        }
        private void GetSystemInfo()
        {
            listBox2.Items.Clear();
            //Addins System info
            listBox2.Items.Add($"Username: {Environment.UserName}");
            listBox2.Items.Add($"PC Name: {Environment.MachineName}");
            listBox2.Items.Add($"OS Version:{Environment.OSVersion}");

            //Adding IP Address info
            string ipAddress = GetLocalIpAddress();
            listBox2.Items.Add($"IP Address{ipAddress}");

            //AddingNewEventArgs Network Interface Details
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    listBox2.Items.Add($"Network Adapter: {nic.Description}");
                    listBox2.Items.Add($"Mac Address: {nic.GetPhysicalAddress()}");
                }
            }

        }
        private string GetLocalIpAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "No IPv4 address found";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetSystemInfo();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileCreationPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a File to Delete",
                Filter = "All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    File.Delete(filePath);
                    MessageBox.Show("File deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Select a File to Save",
                Filter = "Text Files|*.txt|All Files|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Example: Prompt the user for content to write
                string content = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter the text you want to save:",
                    "Write to File",
                    "Hello, World!"
                );

                if (!string.IsNullOrWhiteSpace(content))
                {
                    try
                    {
                        File.WriteAllText(filePath, content);
                        MessageBox.Show("File written successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No content to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
    


    

