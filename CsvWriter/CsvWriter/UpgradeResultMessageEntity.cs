using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsvWriter
{
    /// <summary>
    /// The result upgrade result message
    /// </summary>
    public class UpgradeResultMessageEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeResultMessageEntity"/> class.
        /// </summary>
        public UpgradeResultMessageEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeResultMessageEntity"/> class.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="message">The message.</param>
        public UpgradeResultMessageEntity(ProcessInstanceUpgradeResult result,
            ProcessEntity process,
            InstanceEntity instance,
            int? targetVersion)
        {
            this.Result = result;
            this.Process = process;
            this.Instance = instance;
            this.TargetVersion = targetVersion;
        }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public ProcessInstanceUpgradeResult Result { get; set; }

        /// <summary>
        /// Gets or sets the process.
        /// </summary>
        /// <value>
        /// The process.
        /// </value>
        public ProcessEntity Process { get; set; }

        /// <summary>
        /// Gets or sets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public InstanceEntity Instance { get; set; }

        /// <summary>
        /// Gets or sets the target version.
        /// </summary>
        /// <value>
        /// The target version.
        /// </value>
        public int? TargetVersion { get; set; }
    }
}
