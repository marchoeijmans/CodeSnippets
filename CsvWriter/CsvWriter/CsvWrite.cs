namespace CsvWriter
{
    using System;
    using System.IO;
    using System.Text;

    public class CsvWriter
    {
        private readonly string delimiter = "\t";
        private readonly string logFile = "result.csv";

        public void LogHeaderToFile()
        {
            StreamWriter streamWriter = File.AppendText(this.GetTempPath() + this.logFile);
            try
            {
                streamWriter.WriteLine(this.CreateLogHeader());
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public void LogMessageToFile(UpgradeResultMessageEntity message)
        {
            StreamWriter streamWriter = File.AppendText(this.GetTempPath() + this.logFile);
            try
            {
                streamWriter.WriteLine(this.CreateLogLine(message));
            }
            finally
            {
                streamWriter.Close();
            }
        }

        /// <summary>
        /// Creates the log header.
        /// </summary>
        /// <returns>The Log header.</returns>
        private string CreateLogHeader()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Upgraded");
            builder.Append(this.delimiter);

            builder.Append("Result");
            builder.Append(this.delimiter);

            builder.Append("ProcessFullName");
            builder.Append(this.delimiter);

            builder.Append("ProcessId");
            builder.Append(this.delimiter);

            builder.Append("ProcessVersionNumber");
            builder.Append(this.delimiter);

            builder.Append("ProcessSetId");
            builder.Append(this.delimiter);

            builder.Append("InstanceId");
            builder.Append(this.delimiter);

            builder.Append("ProcessId");
            builder.Append(this.delimiter);

            builder.Append("ExecutingProcId");
            builder.Append(this.delimiter);

            builder.Append("Folio");
            builder.Append(this.delimiter);

            builder.Append("Status");
            builder.Append(this.delimiter);

            builder.Append("TargetVerionNumber");
            builder.Append(this.delimiter);

            return builder.ToString();
        }

        /// <summary>
        /// Creates the log line.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>The log line.</returns>
        private string CreateLogLine(UpgradeResultMessageEntity message)
        {
            StringBuilder builder = new StringBuilder();

            // File: TimeCreated
            builder.Append(DateTime.Now.ToFileTimeUtc());
            builder.Append(this.delimiter);

            // Result
            builder.Append(message.Result.ToString());
            builder.Append(this.delimiter);

            // Process: ProcessFullName
            builder.Append(message.Process.FullName);
            builder.Append(this.delimiter);

            // Process: ProcessId
            builder.Append(message.Process.Id);
            builder.Append(this.delimiter);

            // Process: ProcessVersionNumber
            builder.Append(message.Process.Version.Number);
            builder.Append(this.delimiter);

            // Process: ProcessSetId
            builder.Append(message.Process.ProcessSetId);
            builder.Append(this.delimiter);

            // Instance: InstanceId
            builder.Append(message.Instance.InstanceId);
            builder.Append(this.delimiter);

            // Instance: ProcessId
            builder.Append(message.Instance.ProcessId);
            builder.Append(this.delimiter);

            // Instance: ExecutingProcId
            builder.Append(message.Instance.ExecutingProcId);
            builder.Append(this.delimiter);

            // Instance: Folio
            builder.Append(message.Instance.Folio);
            builder.Append(this.delimiter);

            // Instance: Status
            builder.Append(message.Instance.InstanceId);
            builder.Append(this.delimiter);

            // TargetVerionNumber
            builder.Append(message.TargetVersion);
            builder.Append(this.delimiter);

            return builder.ToString();
        }

        private string GetTempPath()
        {
            string path = System.Environment.GetEnvironmentVariable("TEMP");
            if (!path.EndsWith("\\")) path += "\\";
            return path;
        }
    }
}