using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SCADACommon.Model {
    [DataContract]
    public class InputTag : Tag {
        public InputTag() { }

        public InputTag(int scanTime, List<Alarm> alarms, bool onScan, bool autoMode,
            FunctionType functionType) {
            ScanTime = scanTime;
            Alarms = alarms;
            OnScan = onScan;
            AutoMode = autoMode;
            FunctionType = functionType;
        }

        public InputTag(string id, string description, SimulationDriver driver, string address, int scanTime,
            List<Alarm> alarms, bool onScan, bool autoMode, FunctionType functionType)
            : base(id, description, driver, address) {
            ScanTime = scanTime;
            Alarms = alarms;
            OnScan = onScan;
            AutoMode = autoMode;
            FunctionType = functionType;
        }

        [DataMember]
        public int ScanTime { get; set; }

        [DataMember]
        public List<Alarm> Alarms { get; set; }

        [DataMember]
        public bool OnScan { get; set; }

        [DataMember]
        public bool AutoMode { get; set; }

        [DataMember]
        public FunctionType FunctionType { get; set; }
    }
}