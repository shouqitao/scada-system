using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SCADACommon.Model {
    [DataContract]
    public class AnalogInputTag : InputTag {
        public AnalogInputTag() { }

        public AnalogInputTag(double lowLimit, double highLimit, string units) {
            LowLimit = lowLimit;
            HighLimit = highLimit;
            Units = units;
        }

        public AnalogInputTag(int scanTime, List<Alarm> alarms, bool onScan, bool autoMode,
            FunctionType functionType,
            double lowLimit, double highLimit, string units) : base(scanTime, alarms, onScan, autoMode,
            functionType) {
            LowLimit = lowLimit;
            HighLimit = highLimit;
            Units = units;
        }

        public AnalogInputTag(string id, string description, SimulationDriver driver, string address,
            int scanTime,
            List<Alarm> alarms, bool onScan, bool autoMode, FunctionType functionType, double lowLimit,
            double highLimit,
            string units) : base(id, description, driver, address, scanTime, alarms, onScan, autoMode,
            functionType) {
            LowLimit = lowLimit;
            HighLimit = highLimit;
            Units = units;
        }

        [DataMember]
        public double LowLimit { get; set; }

        [DataMember]
        public double HighLimit { get; set; }

        [DataMember]
        public string Units { get; set; }
    }
}