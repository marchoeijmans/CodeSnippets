namespace CsvWriter
{
    /// <summary>
    /// K2 Process definitions (blueprint of a process instance)
    /// </summary>
    public class ProcessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessEntity"/> class.
        /// </summary>
        /// <param name="processId">The process id.</param>
        /// <param name="processFullName">Full name of the process.</param>
        /// <param name="processSetId">The process set id.</param>
        /// <param name="processVersion">The process version.</param>
        public ProcessEntity(
            int processId,
            string processFullName,
            int processSetId,
            ProcessVersionEntity processVersion)
        {
            this.Id = processId;
            this.FullName = processFullName;
            this.ProcessSetId = processSetId;
            this.Version = processVersion;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the process set id.
        /// </summary>
        /// <value>
        /// The process set id.
        /// </value>
        public int ProcessSetId { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public ProcessVersionEntity Version { get; set; }
    }
}
