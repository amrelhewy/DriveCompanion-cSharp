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

namespace filetransfer
{
   
    public partial class Form1 : Form
    {
        FileInfo f;
        List<string> listbox = new List<string>();
        DriveInfo []di =DriveInfo.GetDrives() ;
        ContextMenuStrip st;
     
        
       
      
        
        public Form1()
        {    
            InitializeComponent();
            foreach (DriveInfo d in di)
            {
                listBox1.Items.Add(d);

            }
            var currentTime = new System.Threading.Timer((e) =>
            {
                currentTimer();
            },null,TimeSpan.Zero,TimeSpan.FromSeconds(1));





        }
        
        
        
        protected void currentTimer()
        {
            var time = DateTime.Now;
            infobox.Text = "Current Time: " + time.ToString();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            
            if(listBox1.SelectedItem!=null)
            {
                try
                {
                    string driveName = (listBox1.SelectedItem).ToString();
                    textBox1.Text = driveName;
                    listBox1.Items.Clear();
                    string[] allFiles = Directory.GetFileSystemEntries(driveName);
                    for (int i = 0; i < allFiles.Length; i++)
                    {
                        listBox1.Items.Add(allFiles[i]);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Error,Can't access this file");
                }

            }
          

        }

        private void forward_MouseClick(object sender, MouseEventArgs e)
        {
            backward.Enabled = true;
           for(int f=0;f<listBox2.Items.Count;f++)
            {
                for(int i=0;i<di.Length;i++)
                {
                    if(listBox2.Items[f]==di[i])
                    {
                        listBox2.Items.Remove(listBox2.Items[f]);

                    }
                }
                
            }
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void backward_MouseClick(object sender, MouseEventArgs e)
        {

            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
           

        }


        private void copy_MouseClick(object sender, MouseEventArgs e)
        {
            string sourceFile = Path.GetFileName(listBox1.SelectedItem.ToString());
            string destinationFile = Path.GetFullPath(listBox2.SelectedItem.ToString());
            string sourcePath = Path.GetFullPath(listBox1.SelectedItem.ToString());
            string fullCopy = destinationFile + "\\" + sourceFile;
            MessageBox.Show("File Copied !!");

            File.Copy(sourcePath, fullCopy, true);


        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            forward.Enabled = true;
            this.ContextMenuStrip = contextMenuStrip1;
            if(e.Button==MouseButtons.Left && listBox2.Items.Count==0)
            {
  
                foreach (DriveInfo d in di)
                {

                    listBox2.Items.Add(d);


                }

            }
            else if(e.Button==MouseButtons.Right)
            {


                this.ContextMenuStrip.Show();

               

                
                
            }
          


        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string driveName = (listBox2.SelectedItem).ToString();
                
                listBox2.Items.Clear();
                string[] allFiles = Directory.GetDirectories(driveName);
                for (int i = 0; i < allFiles.Length; i++)
                {
                    listBox2.Items.Add(allFiles[i]);
                }

            }
        }

        private void delete_MouseClick(object sender, MouseEventArgs e)
        {
            string sourcePath = Path.GetFullPath(listBox1.SelectedItem.ToString());
            File.Delete(sourcePath);
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            listBox1.Refresh();
            MessageBox.Show("File Deleted");
           
        }

        private void root_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();

            foreach (DriveInfo d in di)
            {
                listBox1.Items.Add(d);

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            string currentSRC = textBox1.Text;
            string current = Directory.GetDirectoryRoot(currentSRC);
            listBox1.Items.Clear();
            string[] prevArray = Directory.GetDirectories(current);
            foreach(string i in prevArray)
            {
                listBox1.Items.Add(i);
            }
            textBox1.Text = current;
            

        }

        private void move_Click(object sender, EventArgs e)
        {
            string sourceFile = Path.GetFileName(listBox1.SelectedItem.ToString());
            string destinationFile = Path.GetFullPath(listBox2.SelectedItem.ToString());
            string sourcePath = Path.GetFullPath(listBox1.SelectedItem.ToString());
            string fullCopy = destinationFile + "\\" + sourceFile;
            listBox1.Items.Remove(listBox1.SelectedItem);
            MessageBox.Show("File Moved !!");
            
            listBox1.Refresh();
            listBox2.Refresh();
            File.Move(sourcePath, fullCopy);


        }

        //private void search_KeyPress(object sender, KeyPressEventArgs e)
        //{   
           
            
        //}

        private void search_Enter(object sender, EventArgs e)
        {
            listbox.Clear();
            foreach(string s in listBox1.Items)
            {
                listbox.Add(s);
            }

        }

        private void dateCreatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = Directory.GetCreationTime(listBox1.SelectedItem.ToString());
            string dateFinal=d.ToLongDateString();
            string timeFinal = d.ToShortTimeString();
            MessageBox.Show(dateFinal+" "+timeFinal);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {

                List<string> searchedList = new List<string>();

                foreach (string s in listBox2.Items)
                {
                    string srch = s.ToLower();
                    if (srch.Contains(textBox2.Text))
                    {

                        searchedList.Add(s);

                    }
                }
                listBox2.Items.Clear();
                for (int i = 0; i < searchedList.Count; i++)
                {
                    listBox2.Items.Add(searchedList[i]);
                }


            }
            else
            {
                listBox2.Items.Clear();
                foreach (string s in listbox)
                {
                    listBox2.Items.Add(s);
                }
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            listbox.Clear();
            foreach (string s in listBox2.Items)
            {
                listbox.Add(s);
            }

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text.Length > 0)
            {

                List<string> searchedList = new List<string>();

                foreach (string s in listBox1.Items)
                {
                    string srch = s.ToLower();
                    if (srch.Contains(search.Text))
                    {

                        searchedList.Add(s);

                    }
                }
                listBox1.Items.Clear();
                for (int i = 0; i < searchedList.Count; i++)
                {
                    listBox1.Items.Add(searchedList[i]);
                }

            }
            else
            {
                listBox1.Items.Clear();
                foreach (string s in listbox)
                {
                    listBox1.Items.Add(s);
                }
            }



        }

        private void root2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox2.Clear();

            foreach (DriveInfo d in di)
            {
                listBox2.Items.Add(d);

            }
        }
        //private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string fileName = Path.GetFullPath(listBox1.SelectedItem.ToString());
        //     f = new FileInfo(Path.GetFileName(listBox1.SelectedItem.ToString()));

        //    MessageBox.Show(f.Name);
        //}
    }
}

















