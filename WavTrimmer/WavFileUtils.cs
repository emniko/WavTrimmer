using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Diagnostics;
using System.IO;

namespace WavTrimmer
{
    public static class WavFileUtils
    {
        public static void AddSilence(string inPath, string outPath, double silenceMilliSecondLength, bool end)
        {
            using (var source = new AudioFileReader(inPath)) 
            {
                OffsetSampleProvider newWav;
                if (end) 
                {
                    newWav = new OffsetSampleProvider(source)
                    {
                        LeadOut = TimeSpan.FromMilliseconds(silenceMilliSecondLength)
                    };
                }
                else
                {
                    newWav = new OffsetSampleProvider(source)
                    {
                        DelayBy = TimeSpan.FromMilliseconds(silenceMilliSecondLength / 2),
                        LeadOut = TimeSpan.FromMilliseconds(silenceMilliSecondLength / 2)
                    };
                }
                WaveFileWriter.CreateWaveFile16(outPath, newWav);
            }
        }

        public static void TrimWavFile(string inPath, string outPath, TimeSpan cutFromStart, TimeSpan cutFromEnd)
        {
            using (WaveFileReader reader = new WaveFileReader(inPath))
            {
                using (WaveFileWriter writer = new WaveFileWriter(outPath, reader.WaveFormat))
                {
                    int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;

                    int startPos = (int)cutFromStart.TotalMilliseconds * bytesPerMillisecond;
                    startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                    int endBytes = (int)cutFromEnd.TotalMilliseconds * bytesPerMillisecond;
                    endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                    int endPos = (int)reader.Length - endBytes;

                    TrimWavFile(reader, writer, startPos, endPos);
                }
            }
        }

        private static void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[1024];
            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);
                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead - (bytesToRead % writer.WaveFormat.BlockAlign));
                    if (bytesRead > 0)
                    {
                        writer.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
