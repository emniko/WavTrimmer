using NAudio.Wave;
using System;
using System.Collections.Generic;
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
            DialogResult dialogResult = MessageBox.Show("Files will be overwritten, are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) 
            {
                try
                {
                    string[] referenceFiles = Directory.GetFiles(txt_Reference.Text, "*.wav", SearchOption.AllDirectories);
                    string[] locationFiles = Directory.GetFiles(txt_Location.Text, "*.wav", SearchOption.AllDirectories);                
                    List<KeyValuePair<string, string>> tempBackup = new List<KeyValuePair<string, string>>();
                    List<string> ALTfiles = new List<string>();

                    //Collecting ALT files
                    foreach (string file in locationFiles) 
                    {
                        if (file.Contains("_ALT")) ALTfiles.Add(file);
                    }

                    string refRootName = txt_Reference.Text.Substring(txt_Reference.Text.LastIndexOf("\\") + 1);
                    string locRootName = txt_Location.Text.Substring(txt_Location.Text.LastIndexOf("\\") + 1);

                    Directory.CreateDirectory($"{txt_Location.Text}\\Result");

                    foreach (string file in referenceFiles)
                    {
                        string fileName = file.Substring(file.LastIndexOf('\\') + 1);
                       
                        if (File.Exists(file.Replace(refRootName, locRootName)))
                        {
                            using (WaveFileReader refWavReader = new WaveFileReader(file))
                            {
                                using (WaveFileReader locWavReader = new WaveFileReader(file.Replace(refRootName, locRootName)))
                                {
                                    if (locWavReader.TotalTime > refWavReader.TotalTime)
                                    {
                                        if (cb_Trim.Checked)
                                        {
                                            TimeSpan diff = locWavReader.TotalTime - refWavReader.TotalTime;
                                            if (rb_50.Checked)
                                            {
                                                diff = new TimeSpan(diff.Ticks / 2);
                                                WavFileUtils.TrimWavFile(file.Replace(refRootName, locRootName), $"{txt_Location.Text}\\Result\\{fileName}", diff, diff);
                                            }
                                            else if (rb_End.Checked)
                                            {
                                                WavFileUtils.TrimWavFile(file.Replace(refRootName, locRootName), $"{txt_Location.Text}\\Result\\{fileName}", new TimeSpan(0,0,0), diff);
                                            }

                                            tempBackup.Add(new KeyValuePair<string, string>($"{txt_Location.Text}\\Result\\{fileName}", file.Replace(refRootName, locRootName)));
                                            lv_Logs.Items.Add($"File '{fileName}' successfully trimmed from {locWavReader.TotalTime} to {refWavReader.TotalTime}");
                                        }
                                    }
                                    else if (locWavReader.TotalTime < refWavReader.TotalTime)
                                    {
                                        if (cb_Silence.Checked)
                                        {
                                            TimeSpan diff = refWavReader.TotalTime - locWavReader.TotalTime;
                                            WavFileUtils.AddSilence(file.Replace(refRootName, locRootName), $"{txt_Location.Text}\\Result\\{fileName}", diff.TotalMilliseconds, rb_End.Checked);
                                            tempBackup.Add(new KeyValuePair<string, string>($"{txt_Location.Text}\\Result\\{fileName}", file.Replace(refRootName, locRootName)));
                                            lv_Logs.Items.Add($"Silence added in file '{fileName}' from {locWavReader.TotalTime} to {refWavReader.TotalTime}");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            lv_Logs.Items.Add($"File '{fileName}' not found in {file.Replace(refRootName, locRootName)}");
                        }
                    }

                    //ALT Files
                    if (cb_ALT.Checked) 
                    {
                        lv_Logs.Items.Add("Processing _ALT files...");

                        foreach (string altPath in ALTfiles)
                        {
                            //Removing _ALT
                            string newAltFile = altPath.Substring(0, altPath.IndexOf("_ALT")) + ".wav";

                            foreach (string file in referenceFiles)
                            {
                                if (file.Replace(refRootName, locRootName).Equals(newAltFile))
                                {
                                    string fileName = altPath.Substring(altPath.LastIndexOf('\\') + 1);

                                    using (WaveFileReader refWavReader = new WaveFileReader(file))
                                    {
                                        using (WaveFileReader locWavReader = new WaveFileReader(altPath))
                                        {
                                            if (locWavReader.TotalTime > refWavReader.TotalTime)
                                            {
                                                if (cb_Trim.Checked)
                                                {
                                                    TimeSpan diff = locWavReader.TotalTime - refWavReader.TotalTime;
                                                    if (rb_50.Checked)
                                                    {
                                                        diff = new TimeSpan(diff.Ticks / 2);
                                                        WavFileUtils.TrimWavFile(altPath, $"{txt_Location.Text}\\Result\\{fileName}", diff, diff);
                                                    }
                                                    else if (rb_End.Checked)
                                                    {
                                                        WavFileUtils.TrimWavFile(altPath, $"{txt_Location.Text}\\Result\\{fileName}", new TimeSpan(0, 0, 0), diff);
                                                    }

                                                    tempBackup.Add(new KeyValuePair<string, string>($"{txt_Location.Text}\\Result\\{fileName}", altPath));
                                                    lv_Logs.Items.Add($"File '{fileName}' successfully trimmed from {locWavReader.TotalTime} to {refWavReader.TotalTime}");
                                                }
                                            }
                                            else if (locWavReader.TotalTime < refWavReader.TotalTime)
                                            {
                                                if (cb_Silence.Checked)
                                                {
                                                    TimeSpan diff = refWavReader.TotalTime - locWavReader.TotalTime;
                                                    WavFileUtils.AddSilence(altPath, $"{txt_Location.Text}\\Result\\{fileName}", diff.TotalMilliseconds, rb_End.Checked);
                                                    tempBackup.Add(new KeyValuePair<string, string>($"{txt_Location.Text}\\Result\\{fileName}", altPath));
                                                    lv_Logs.Items.Add($"Silence added in file '{fileName}' from {locWavReader.TotalTime} to {refWavReader.TotalTime}");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    foreach (var file in tempBackup)
                    {
                        File.Delete(file.Value);
                        File.Move(file.Key, file.Value);
                    }
                    Directory.Delete($"{txt_Location.Text}\\Result", true);
                }
                catch (Exception ex)
                {
                    lv_Logs.Items.Add(ex.Message);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lv_Logs.Items.Clear();       
        }
    }
}
