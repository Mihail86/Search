using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace search
{
    public partial class Form1 : Form
    {
        bool stop=true;
        int n=0, s = 0, m = 0, h = 0, VPapke=0;
        string CurrentFile = "";
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (tbDirectory.Text != "")
            {
                
                string[] files = { "" };
                string StringFromFile = "";
                lTime.Text = "00:00:00";
                int a = 0;
                //timer1.Enabled = true;
                if (tbNameFile.Text == "" && tbFragmentFile.Text == "")
                    MessageBox.Show("Не указано имя файла или текст в файле.", "Сервисное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                {
                    string[] MainDirectory = tbDirectory.Text.Split('\\');
                    files = Directory.GetFiles(tbDirectory.Text, tbNameFile.Text!=""?tbNameFile.Text:"*.*", SearchOption.AllDirectories);
                    stop = true;
                    string PreviosDir = "";
                    timer1.Start();
                    //timer1.Tick += new EventHandler(timer1_Tick);
                    if (files.LongLength > 0)
                    {
                        
                        treeView1.Nodes.Add(MainDirectory[MainDirectory.Length - 1]);
                    }
                    double indicator = 0;
                    for (int i = n; i < files.LongLength; i++)
                    {
                        lNameProssesedFile.Text = files[i];

                        

                        if (tbFragmentFile.Text != "")
                        {StreamReader sr = new StreamReader(files[i]);
                            while (sr.EndOfStream != true)
                            {
                                StringFromFile = sr.ReadLine();
                                if (StringFromFile.Contains(tbFragmentFile.Text))
                                {
                                    string[] directory = files[i].Split('\\');
                                    string SubDirectory = "";
                                    if (MainDirectory.Length < directory.Length - 1)
                                        for (int j = 0; j <= MainDirectory.Length; j++)
                                        {
                                            SubDirectory = SubDirectory + directory[j] + (j != MainDirectory.Length ? "\\" : "");
                                        }
                                    if (SubDirectory != "")
                                    {CurrentFile = directory[directory.Length - 1];
                                        if (PreviosDir != SubDirectory)
                                        {
                                            DirectoryInfo papka = new DirectoryInfo(SubDirectory);
                                            TreeNode Papka = Tree_Set_Pach(papka);
                                            treeView1.Nodes[0].Nodes.Add(Papka);
                                        }
                                        PreviosDir = SubDirectory;
                                    }
                                    else
                                    { treeView1.Nodes[0].Nodes.Add(new TreeNode(directory[directory.Length - 1], 0, 0)); }
                                    break;
                                }
                            }
                            sr.Close();
                        }
                        else
                        {
                            string[] directory = files[i].Split('\\');
                            string SubDirectory = "";
                            if (MainDirectory.Length < directory.Length-1)
                            for (int j = 0; j <=MainDirectory.Length; j++)
                                {
                                    SubDirectory = SubDirectory + directory[j] + (j != MainDirectory.Length ? "\\" : "");
                                }
                            if (SubDirectory!="")
                            {    
                                if (PreviosDir != SubDirectory)
                                {
                                    DirectoryInfo papka = new DirectoryInfo(SubDirectory);
                                    TreeNode Papka = Tree_Set_Pach(papka);
                                    treeView1.Nodes[0].Nodes.Add(Papka);
                                }
                                PreviosDir = SubDirectory;
                            }
                            else
                            { treeView1.Nodes[0].Nodes.Add(new TreeNode(directory[directory.Length - 1], 0, 0)); }
                        }
                        lCountFiles.Text = (i + 1).ToString();
                        indicator += progressBar1.Size.Width / files.Length;
                        progressBar1.Step = (int)indicator;
                        progressBar1.PerformStep();
                        Application.DoEvents();
                        if (!stop)
                        {
                            n = i; break;
                        }
                    }
                    timer1.Stop();
                    treeView1.Sort();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          // timer1.Enabled = false;
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            stop = false;
            timer1.Stop();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                StreamWriter SP = new StreamWriter(saveFileDialog1.FileName);
                SP.Write(tbDirectory.Text + "\r\n");
                SP.Write(tbNameFile.Text + "\r\n");
                SP.Write(tbFragmentFile.Text + "\r\n");
                SP.Close();
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                StreamReader LP = new StreamReader(openFileDialog1.FileName);
                tbDirectory.Text = LP.ReadLine();
                tbNameFile.Text = LP.ReadLine();
                tbFragmentFile.Text = LP.ReadLine();
                LP.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            
            if (s > 59)
            {
                m++;
                s =0;
            }
            if (m > 59)
            {
                h++;
                m = 0;
            }
            lTime.Text = (h >= 10 ? h.ToString() : "0" + h.ToString()) + ":" + (m > +10 ? m.ToString() : "0" + m.ToString()) + ":" + (s >= 10 ? s.ToString() : "0" + s.ToString());
        }
        public TreeNode Tree_Set_Pach(DirectoryInfo dir)
        { TreeNode obj = new TreeNode(dir.Name);
          foreach (DirectoryInfo subdir in dir.GetDirectories(tbNameFile.Text))
          { TreeNode SD = Tree_Set_Pach(subdir);
            obj.Nodes.Add(SD);
          }
          foreach (FileInfo thisFile in dir.GetFiles(tbNameFile.Text))
          {
              if (tbFragmentFile.Text != "")
              {
                  if (thisFile.Name == CurrentFile)
                      obj.Nodes.Add(new TreeNode(thisFile.Name, 0, 0));
              }
              else
              { obj.Nodes.Add(new TreeNode(thisFile.Name, 0, 0)); }
          }
          return obj;
        }
    }
}
