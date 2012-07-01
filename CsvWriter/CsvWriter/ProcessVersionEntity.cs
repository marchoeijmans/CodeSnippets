namespace CsvWriter
{
    using System;

    /// <summary>
    /// The version details off a Process
    /// </summary>
    public class ProcessVersionEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessVersionEntity"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="label">The label.</param>
        /// <param name="description">The description.</param>
        /// <param name="number">The number.</param>
        public ProcessVersionEntity(DateTime date, string label, string description, int number)
        {
            this.Date = date;
            this.Label = label;
            this.Description = description;
            this.Number = number;
        }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }
    }
}
