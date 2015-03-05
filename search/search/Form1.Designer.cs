namespace search
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Search = new System.Windows.Forms.Button();
            this.lTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lCountFiles = new System.Windows.Forms.Label();
            this.lNameProssesedFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFragmentFile = new System.Windows.Forms.TextBox();
            this.tbNameFile = new System.Windows.Forms.TextBox();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.bStop);
            this.splitContainer1.Panel2.Controls.Add(this.bLoad);
            this.splitContainer1.Panel2.Controls.Add(this.bSave);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel2.Controls.Add(this.Search);
            this.splitContainer1.Panel2.Controls.Add(this.lTime);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.lCountFiles);
            this.splitContainer1.Panel2.Controls.Add(this.lNameProssesedFile);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.tbFragmentFile);
            this.splitContainer1.Panel2.Controls.Add(this.tbNameFile);
            this.splitContainer1.Panel2.Controls.Add(this.tbDirectory);
            this.splitContainer1.Size = new System.Drawing.Size(714, 502);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 1);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(204, 501);
            this.treeView1.TabIndex = 0;
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.Location = new System.Drawing.Point(350, 460);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(136, 28);
            this.bLoad.TabIndex = 15;
            this.bLoad.Text = "Выбрать параметры";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(165, 460);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(167, 29);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Coxpaнить параметры";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(18, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(469, 20);
            this.progressBar1.TabIndex = 13;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(389, 112);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(97, 29);
            this.Search.TabIndex = 11;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(119, 215);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 13);
            this.lTime.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Прошло времени";
            // 
            // lCountFiles
            // 
            this.lCountFiles.AutoSize = true;
            this.lCountFiles.Location = new System.Drawing.Point(89, 186);
            this.lCountFiles.Name = "lCountFiles";
            this.lCountFiles.Size = new System.Drawing.Size(68, 13);
            this.lCountFiles.TabIndex = 8;
            this.lCountFiles.Text = "Обработано";
            // 
            // lNameProssesedFile
            // 
            this.lNameProssesedFile.AutoSize = true;
            this.lNameProssesedFile.Location = new System.Drawing.Point(146, 152);
            this.lNameProssesedFile.Name = "lNameProssesedFile";
            this.lNameProssesedFile.Size = new System.Drawing.Size(130, 13);
            this.lNameProssesedFile.TabIndex = 7;
            this.lNameProssesedFile.Text = "Обрабатываемый файл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст в файле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя файла";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Директория";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(391, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFragmentFile
            // 
            this.tbFragmentFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFragmentFile.Location = new System.Drawing.Point(94, 86);
            this.tbFragmentFile.Name = "tbFragmentFile";
            this.tbFragmentFile.Size = new System.Drawing.Size(394, 20);
            this.tbFragmentFile.TabIndex = 2;
            // 
            // tbNameFile
            // 
            this.tbNameFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameFile.Location = new System.Drawing.Point(94, 51);
            this.tbNameFile.Name = "tbNameFile";
            this.tbNameFile.Size = new System.Drawing.Size(394, 20);
            this.tbNameFile.TabIndex = 1;
            // 
            // tbDirectory
            // 
            this.tbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirectory.Location = new System.Drawing.Point(94, 19);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(292, 20);
            this.tbDirectory.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(288, 112);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(88, 28);
            this.bStop.TabIndex = 16;
            this.bStop.Text = "Стоп";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Обрабатываемый файл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Обработано";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Поиск файлов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbFragmentFile;
        private System.Windows.Forms.TextBox tbNameFile;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lCountFiles;
        private System.Windows.Forms.Label lNameProssesedFile;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

