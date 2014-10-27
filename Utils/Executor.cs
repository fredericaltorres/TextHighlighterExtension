using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Executor
{
    public static class Executor 
    {
        public class ExecutionInfo
        {
            public ExecutionInfo()
            {
              this.Output      = null;
              this.ErrorOutput = null;
              this.Time        = -1;
              this.CommandLine = null;
              this.ErrorLevel  = -1;
            }

            public string Output      { get; set; }
            public string ErrorOutput { get; set; }
            public int Time           { get; set; }
            public string CommandLine { get; set; }
            public int ErrorLevel     { get; set; }
            public bool Succeeded     { get { return this.ErrorLevel == 0; } }
        }

        public static ExecutionInfo ExecuteConsole(string program, string commandLine) {

            var e                     = new ExecutionInfo();
            e.Time                    = Environment.TickCount;
            e.ErrorLevel              = -1;
            StreamReader outputReader = null;
            StreamReader errorReader  = null;
            try {
                ProcessStartInfo processStartInfo       = new ProcessStartInfo(program, commandLine);
                processStartInfo.ErrorDialog            = false;
                processStartInfo.UseShellExecute        = false;
                processStartInfo.RedirectStandardError  = true;
                processStartInfo.RedirectStandardInput  = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow         = false;
                Process process                         = new Process();
                process.StartInfo                       = processStartInfo;
                bool processStarted                     = process.Start();

                if (processStarted) {
                    outputReader  = process.StandardOutput;
                    errorReader   = process.StandardError;
                    process.WaitForExit();
                    e.Output      = outputReader.ReadToEnd();
                    e.ErrorOutput = errorReader.ReadToEnd();
                    e.ErrorLevel  = process.ExitCode;
                }
                process.Dispose();
            }
            catch (Exception ex)
            {
                e.ErrorOutput += string.Format("Error lanching the nodejs.exe = {0}", ex.ToString());
            }
            finally
            {
                if (outputReader != null)
                    outputReader.Close();

                if (errorReader != null)
                    errorReader.Close();
            }
            e.Time = Environment.TickCount - e.Time;
            return e;
        }

        public static void ExecuteFile(string file)
        {
            Process.Start(file);
        }

        public static Process ExecuteAsBatch(
            string batchCode, 
            ProcessWindowStyle style = ProcessWindowStyle.Normal, 
            bool deleteBatchFile = true, 
            string batchFileName = "Executor.ExecuteAsBatch.bat") {
         
            var program            = "cmd.exe";
            var fullBatchFileName  = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), batchFileName);
            var commandLine        = string.Format(@" /c ""{0}"" ", fullBatchFileName);

            System.IO.File.WriteAllText(fullBatchFileName, batchCode);
            var p = Execute(program, commandLine, style: style, wait: true);

            if(deleteBatchFile)
                System.IO.File.Delete(fullBatchFileName);

            return p;
        }

        public static Process Execute(
            string program, 
            string commandLine, 
            ProcessWindowStyle style = ProcessWindowStyle.Normal, 
            bool wait = false) {

            var path                          = System.IO.Path.GetDirectoryName(program);
            var processStartInfo              = new ProcessStartInfo(program, commandLine);
            processStartInfo.ErrorDialog      = false;
            processStartInfo.UseShellExecute  = true;
            processStartInfo.CreateNoWindow   = false;
            processStartInfo.WorkingDirectory = path;
            processStartInfo.WindowStyle      = style;
            var process                       = new Process();
            process.StartInfo                 = processStartInfo;

            process.Start();

            if (wait) 
                process.WaitForExit();

            return process;
        }
    }
}
