using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ROSY
{

    public partial class progress : Form
    {
        private string _newusername;
        public progress(string newusername)
        {
            InitializeComponent();
            _newusername = newusername;
        }

        private void progress_Load(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;


            //Create background worker to run modified sell batch file.
            BackgroundWorker bgWorker;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(executeselltasks);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_sellcompleted);
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_sellcompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (File.Exists(@"sell.bat"))
            {
                File.Delete(@"sell.bat");
            }
            if (File.Exists(@"cleanup.bat"))
            {
                File.Delete(@"cleanup.bat");
            }
            if (File.Exists(@"powershellregclean.ps1"))
            {
                File.Delete(@"powershellregclean.ps1");
            }

            progressBar.Style = ProgressBarStyle.Continuous;
            DialogResult done = MessageBox.Show("Done!" + Environment.NewLine + "ROSY will now reboot this machine." + Environment.NewLine + "When your new account logs in for the first time, a cleanup script will run.", "Done", MessageBoxButtons.OK);
            if (done == DialogResult.OK)
            {
                Process.Start("shutdown", "/r /t 5 /c \"Restarting into new account\"");
                Application.Exit();
            }
        }


        private void executeselltasks(object sender, DoWorkEventArgs e)
        {
            List<string> files = new List<string>();
            files.Add("cleanup.bat");
            files.Add("powershellregclean.ps1"); 
            files.Add("sell.bat");  

            //Grab the embedded batch files and powershell scripts and write them out to disk.
            ExtractEmbeddedResource(@".","ROSY", files);

            //Execute the sell.bat file.
            Process process = new Process();
            process.StartInfo.FileName = @"sell.bat";
            process.StartInfo.Arguments = string.Format("\"{0}\"", _newusername);
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForExit();
        }

        private static void ExtractEmbeddedResource(string outputDir, string resourceLocation, List<string> files)
        {
            foreach (string file in files)
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceLocation + @"." + file))
                {
                    using (FileStream fileStream = new FileStream(Path.Combine(outputDir, file), FileMode.Create))
                    {
                        for (int i = 0; i < stream.Length; i++)
                        {
                            fileStream.WriteByte((byte)stream.ReadByte());
                        }
                        fileStream.Close();
                    }
                }
            }
        }
    }
}
