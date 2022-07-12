using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class Vessel
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string callSign;
        public string CallSign { get { return callSign; } set { callSign = value; } }

        private string mmsi;

        public string MMSI { get { return mmsi; } set { mmsi = value; } }

        private string images;
        public string Images { get { return images; } set { images = value; } }

        private int? flagStateID;

        public int? FlagStateID { get { return flagStateID; } set { flagStateID = value; } }
        public National FlagState { get; set; }

        private string length;
        public string Length { get { return length; } set { length = value; } }

        private string beam;
        public string Beam { get { return beam; } set { beam = value; } }

        private string draft;
        public string Draft { get { return draft; } set { draft = value; } }

        private string grossTonnage;

        public string GrossTonnage { get { return grossTonnage; } set { grossTonnage = value; } }

        private string clearanceHeight;

        public string ClearanceHeight { get { return clearanceHeight; } set { clearanceHeight = value; } }

        private string deadweightTonnage;

        public string DeadweightTonnage { get { return deadweightTonnage; } set { deadweightTonnage = value; } }

        private string agentsInVN;

        public string AgentsInVN { get { return agentsInVN; } set { agentsInVN = value; } }

        private string maxSOG;

        public string MaxSOG { get { return maxSOG; } set { maxSOG = value; } }

        private string maxSTW;
        public string MaxSTW { get { return maxSTW; } set { maxSTW = value; } }

        private bool? vms;

        public bool? VMS { get { return vms; } set { vms = value; } }

        private string vmsNation;
        public string VMSNation { get { return vmsNation; } set { vmsNation = value; } }

        private string contractInfo;
        public string ContractInfo { get { return contractInfo; } set { contractInfo = value; } }

        private string certificateOfRegistryID;
        public string CertificateOfRegistryID { get { return certificateOfRegistryID; } set { certificateOfRegistryID = value; } }

        private string portOfRegisty;
        public string PortOfRegisty { get { return portOfRegisty; } set { portOfRegisty = value; } }

        private bool? haveRFMO;
        public bool? HaveRFMO { get { return haveRFMO; } set { haveRFMO = value; } }

        private string rfmoID;
        public string RFMOID { get { return rfmoID; } set { rfmoID = value; } }

        private string numberOfCrews;
        public string NumberOfCrews { get { return numberOfCrews; } set { numberOfCrews = value; } }

        private int? rfmoTypeID;
        public int? RFMOTypeID { get { return rfmoTypeID; } set { rfmoTypeID = value; } }
        public Category RFMOType { get; set; }

        private string externalID;
        public string ExternalID { get { return externalID; } set { externalID = value; } }

        private string imoID;
        public string IMOID { get { return imoID; } set { imoID = value; } }

        private int? captainID;
        public int? CaptainID { get { return captainID; } set { captainID = value; } }
        public PeopleOnVessel Captain { get; set; }

        private int? agentID;
        public int? AgentID { get { return agentID; } set { agentID = value; } }
        public PeopleOnVessel Agent { get; set; }

        private int? vesselTypeID;
        public int? VesselTypeID { get { return vesselTypeID; } set { vesselTypeID = value; } }
        public Category VesselType { get; set; }

        private int? gearTypeID;
        public int? GearTypeID { get { return gearTypeID; } set { gearTypeID = value; } }
        public Category GearType { get; set; }

        private bool? isIUU;
        public bool? IsIUU { get { return isIUU; } set { isIUU = value; } }

        private DateTime? timeSetIUU;
        public DateTime? TimeSetIUU { get { return timeSetIUU; } set { timeSetIUU = value; } }

        private string otherInfoIUU;

        public string OtherInfoIUU { get { return otherInfoIUU; } set { otherInfoIUU = value; } }
    }
}
