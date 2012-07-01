using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsvWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvWriter writer = new CsvWriter();
            writer.LogHeaderToFile();

            int processId = 1;
            string processFullName = "WFMProcessen\\Beroep";
            int processSetId = 2;
            int versionNumber = 33;
            int instanceId = 507;
            int executingProcId = 1;
            string folio = "6780001";
            string status = "Running";

            UpgradeResultMessageEntity result = new UpgradeResultMessageEntity();
            result.Process = new ProcessEntity(processId, 
                processFullName,
                processSetId,
                new ProcessVersionEntity(DateTime.Now, string.Empty, string.Empty, versionNumber));

            result.Instance = new InstanceEntity(instanceId, processId, versionNumber, executingProcId, folio, DateTime.Now, status);

            result.Result = ProcessInstanceUpgradeResult.Success;

            writer.LogMessageToFile(result);


            processId = 1;
            processFullName = "WFMProcessen\\Beroep";
            processSetId = 2;
            versionNumber = 33;
            instanceId = 507;
            executingProcId = 1;
            folio = "6780001";
            status = "Running";

            result.Process = new ProcessEntity(processId,
                processFullName,
                processSetId,
                new ProcessVersionEntity(DateTime.Now, string.Empty, string.Empty, versionNumber));

            result.Instance = new InstanceEntity(instanceId, processId, versionNumber, executingProcId, folio, DateTime.Now, status);

            result.Result = ProcessInstanceUpgradeResult.Failed;

            writer.LogMessageToFile(result);
        }
    }
}
