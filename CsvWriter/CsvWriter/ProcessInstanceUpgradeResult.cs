namespace CsvWriter
{
    /// <summary>
    /// Possible results of the K2 process converter
    /// </summary>
    public enum ProcessInstanceUpgradeResult
    {
        /// <summary>
        /// Conversion to new processdefinition version was successfull
        /// </summary>
        Success,

        /// <summary>
        /// Conversion to new processdefinition version failed because of an exception
        /// </summary>
        Failed
    }
}
