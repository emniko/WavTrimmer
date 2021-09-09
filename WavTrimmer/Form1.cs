using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace WavTrimmer
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_BrowseLocation_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Location.Text = folderDialog.SelectedPath;
            }
        }

        private void btn_BrowseReference_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Reference.Text = folderDialog.SelectedPath;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                string[] referenceFiles = Directory.GetFiles(txt_Reference.Text, "*.wav", SearchOption.TopDirectoryOnly);
                Directory.CreateDirectory($"{txt_Location.Text}\\Result");

                foreach (string file in referenceFiles)
                {
                    string fileName = file.Substring(file.LastIndexOf('\\') + 1);

                    if (File.Exists($"{txt_Location.Text}\\{fileName}"))
                    {
                        using (WaveFileReader refWavReader = new WaveFileReader(file))
                        {
                            using (WaveFileReader locWavReader = new WaveFileReader($"{txt_Location.Text}\\{fileName}"))
                            {
                                if (locWavReader.TotalTime > refWavReader.TotalTime)
                                {
                                    TimeSpan diff = locWavReader.TotalTime - refWavReader.TotalTime;
                                    diff = new TimeSpan(diff.Ticks / 2);
                                    WavFileUtils.TrimWavFile($"{txt_Location.Text}\\{fileName}", $"{txt_Location.Text}\\Result\\{fileName}", diff, diff);
                                    lv_Logs.Items.Add($"File '{fileName}' successfully trimmed from {locWavReader.TotalTime} to {refWavReader.TotalTime}");
                                }
                                else if (locWavReader.TotalTime < refWavReader.TotalTime)
                                {
                                    TimeSpan diff = refWavReader.TotalTime - locWavReader.TotalTime;
                                    WavFileUtils.AddSilence($"{txt_Location.Text}\\{fileName}", $"{txt_Location.Text}\\Result\\{fileName}", diff.TotalMilliseconds);
                                    lv_Logs.Items.Add($"Silence added in file '{fileName}' from {locWavReader.TotalTime} to {refWavReader.TotalTime}");
                                }
                            }
                        }
                    }
                    else
                    {
                        lv_Logs.Items.Add($"File '{fileName}' not found in {txt_Location.Text}");
                    }
                }

                string[] moveToFiles = Directory.GetFiles($"{txt_Location.Text}\\Result", "*.wav", SearchOption.TopDirectoryOnly);
                foreach (string file in moveToFiles)
                {
                    File.Delete($"{txt_Location.Text}\\{file.Substring(file.LastIndexOf('\\') + 1)}");
                    File.Move(file, $"{txt_Location.Text}\\{file.Substring(file.LastIndexOf('\\') + 1)}");
                }
                Directory.Delete($"{txt_Location.Text}\\Result", true);
            }
            catch (Exception ex)
            {
                lv_Logs.Items.Add(ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lv_Logs.Items.Clear();       
        }
    }
}
