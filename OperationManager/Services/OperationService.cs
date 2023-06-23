using System.Collections.Generic;
using OperationManager.Models; 

namespace OperationManager.Services
{
    public class OperationService
    {
        private List<Operation> operations;

        public OperationService()
        {
            
            operations = new List<Operation>
            {
                new Operation { OperationID = 1, Name = "Operation 1", OrderInWhichToPerform = 1, Device = new Device { DeviceID = 1, Name = "Device 1", DeviceType = DeviceType.BarcodeScanner } },
                new Operation { OperationID = 2, Name = "Operation 2", OrderInWhichToPerform = 2, Device = new Device { DeviceID = 2, Name = "Device 2", DeviceType = DeviceType.Printer } },
                new Operation { OperationID = 3, Name = "Operation 3", OrderInWhichToPerform = 3, Device = new Device { DeviceID = 3, Name = "Device 3", DeviceType = DeviceType.Camera } }
            };
        }

        public List<Operation> GetOperations()
        {
            return operations;
        }

        public void AddOperation(Operation operation)
        {
            
            operations.Add(operation);
        }

        public void RemoveOperation(Operation operation)
        {
            operations.Remove(operation);
        }
    }
}
