﻿using System;
using System.Diagnostics;
using System.IO;

namespace WebMConverter
{
    class FFplay : Process
    {
        public string FFplayPath = Path.Combine(Environment.CurrentDirectory, "Binaries", "ffplay.exe");

        public FFplay(string argument)
        {
            this.StartInfo.FileName = FFplayPath;
            this.StartInfo.Arguments = argument;
            this.StartInfo.RedirectStandardInput = true;
            this.StartInfo.RedirectStandardOutput = true;
            this.StartInfo.RedirectStandardError = true;
            this.StartInfo.UseShellExecute = false; //Required to redirect IO streams
            this.StartInfo.CreateNoWindow = true; //Hide console
            this.EnableRaisingEvents = true;
        }

        new public void Start()
        {
            base.Start();
            this.BeginErrorReadLine();
            this.BeginOutputReadLine();
        }
    }
}