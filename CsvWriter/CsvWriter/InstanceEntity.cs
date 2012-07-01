namespace CsvWriter
{
    using System;

    /// <summary>
    /// Instance off specific process (version)
    /// </summary>
    public class InstanceEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceEntity"/> class.
        /// </summary>
        /// <param name="processInstanceId">The process instance id.</param>
        /// <param name="processId">The process definitions id.</param>
        /// <param name="executingProcId">The executing proc id.</param>
        /// <param name="processVersionId">The process version id.</param>
        /// <param name="processInstanceFolio">The process instance folio.</param>
        /// <param name="processInstanceStartDate">The process instance start date.</param>
        /// <param name="processInstanceStatus">The process instance status.</param>
        public InstanceEntity(
            int processInstanceId,
            int processId,
            int executingProcId,
            int processVersionId,
            string processInstanceFolio,
            DateTime processInstanceStartDate,
            string processInstanceStatus)
        {
            this.InstanceId = processInstanceId;
            this.ProcessId = processId;
            this.ExecutingProcId = executingProcId;
            this.ProcessVersionId = processId;
            this.Folio = processInstanceFolio;
            this.StartDate = processInstanceStartDate;
            this.Status = processInstanceStatus;
        }

        #region Process Instance properties

        /// <summary>
        /// Gets or sets the instance id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int InstanceId { get; set; }

        /// <summary>
        /// Gets or sets the process id.
        /// </summary>
        /// <value>
        /// The process id.
        /// </value>
        public int ProcessId { get; set; }

        /// <summary>
        /// Gets or sets the executing proc id.
        /// </summary>
        /// <value>
        /// The executing proc id.
        /// </value>
        public int ExecutingProcId { get; set; }

        /// <summary>
        /// Gets or sets the process set id.
        /// </summary>
        /// <value>
        /// The process set id.
        /// </value>
        public int ProcessSetId { get; set; }

        /// <summary>
        /// Gets or sets the process version id.
        /// </summary>
        /// <value>
        /// The process version id.
        /// </value>
        public int ProcessVersionId { get; set; }

        /// <summary>
        /// Gets or sets the folio (BSN).
        /// </summary>
        /// <value>
        /// The folio.
        /// </value>
        public string Folio { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }
        #endregion
    }
}
