using System.Runtime.Serialization;

namespace SCADACommon.Model {
    [DataContract]
    public class AnalogOutputTag : OutputTag {
        public AnalogOutputTag() { }

        public AnalogOutputTag(double lowLimit, double highLimit, string units) {
            LowLimit = lowLimit;
            HighLimit = highLimit;
            Units = units;
        }

        public AnalogOutputTag(double initialValue, double lowLimit, double highLimit, string units)
            : base(initialValue) {
            LowLimit = lowLimit;
            HighLimit = highLimit;
            Units = units;
        }

        public AnalogOutputTag(string id, string description, SimulationDriver driver, string address,
            double initialValue, double lowLimit, double highLimit, string units)
            : base(id, description, driver, address, initialValue) {
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