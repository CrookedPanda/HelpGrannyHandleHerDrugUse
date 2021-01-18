using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaakJeNietDrugAPI.Model
{
    public class CallResult
    {
        public Meta meta { get; set; }
        public Result[] results { get; set; }
    }

    public class Meta
    {
        public string disclaimer { get; set; }
        public string terms { get; set; }
        public string license { get; set; }
        public string last_updated { get; set; }
        public Results results { get; set; }
    }

    public class Results
    {
        public int skip { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
    }

    public class Result
    {
        public string reporttype { get; set; }
        public string receiptdateformat { get; set; }
        public Receiver receiver { get; set; }
        public string companynumb { get; set; }
        public string occurcountry { get; set; }
        public string safetyreportversion { get; set; }
        public string receivedateformat { get; set; }
        public Primarysource primarysource { get; set; }
        public string duplicate { get; set; }
        public string transmissiondateformat { get; set; }
        public string fulfillexpeditecriteria { get; set; }
        public string safetyreportid { get; set; }
        public Sender sender { get; set; }
        public string receivedate { get; set; }
        public Patient patient { get; set; }
        public string transmissiondate { get; set; }
        public string serious { get; set; }
        public Reportduplicate reportduplicate { get; set; }
        public string receiptdate { get; set; }
        public string primarysourcecountry { get; set; }
        public string seriousnessother { get; set; }
        public string seriousnessdisabling { get; set; }
        public string seriousnesshospitalization { get; set; }
        public string seriousnesslifethreatening { get; set; }
        public string seriousnessdeath { get; set; }
        public string authoritynumb { get; set; }
        public string seriousnesscongenitalanomali { get; set; }
    }

    public class Receiver
    {
        public string receivertype { get; set; }
        public string receiverorganization { get; set; }
    }

    public class Primarysource
    {
        public string reportercountry { get; set; }
        public string qualification { get; set; }
    }

    public class Sender
    {
        public string sendertype { get; set; }
        public string senderorganization { get; set; }
    }

    public class Patient
    {
        public Reaction[] reaction { get; set; }
        public string patientsex { get; set; }
        public Drug[] drug { get; set; }
        public string patientonsetage { get; set; }
        public string patientonsetageunit { get; set; }
        public string patientweight { get; set; }
        public Summary summary { get; set; }
        public string patientagegroup { get; set; }
    }

    public class Summary
    {
        public string narrativeincludeclinical { get; set; }
    }

    public class Reaction
    {
        public string reactionmeddraversionpt { get; set; }
        public string reactionmeddrapt { get; set; }
        public string reactionoutcome { get; set; }
    }

    public class Drug
    {
        public string drugstartdateformat { get; set; }
        public string drugindication { get; set; }
        public string drugintervaldosageunitnumb { get; set; }
        public string drugadministrationroute { get; set; }
        public string drugdosageform { get; set; }
        public string drugstartdate { get; set; }
        public Openfda openfda { get; set; }
        public string drugauthorizationnumb { get; set; }
        public string drugstructuredosageunit { get; set; }
        public string medicinalproduct { get; set; }
        public string drugcharacterization { get; set; }
        public string drugstructuredosagenumb { get; set; }
        public string drugintervaldosagedefinition { get; set; }
        public string drugseparatedosagenumb { get; set; }
        public string actiondrug { get; set; }
        public string drugadditional { get; set; }
        public string drugenddateformat { get; set; }
        public string drugdosagetext { get; set; }
        public string drugenddate { get; set; }
        public string drugrecurreadministration { get; set; }
        public Activesubstance activesubstance { get; set; }
        public string drugbatchnumb { get; set; }
        public string drugtreatmentduration { get; set; }
        public string drugtreatmentdurationunit { get; set; }
    }

    public class Openfda
    {
        public string[] product_ndc { get; set; }
        public string[] package_ndc { get; set; }
        public string[] generic_name { get; set; }
        public string[] spl_set_id { get; set; }
        public string[] brand_name { get; set; }
        public string[] manufacturer_name { get; set; }
        public string[] rxcui { get; set; }
        public string[] unii { get; set; }
        public string[] spl_id { get; set; }
        public string[] substance_name { get; set; }
        public string[] product_type { get; set; }
        public string[] route { get; set; }
        public string[] application_number { get; set; }
        public string[] nui { get; set; }
        public string[] pharm_class_cs { get; set; }
        public string[] pharm_class_epc { get; set; }
        public string[] pharm_class_moa { get; set; }
    }

    public class Activesubstance
    {
        public string activesubstancename { get; set; }
    }

    public class Reportduplicate
    {
        public string duplicatesource { get; set; }
        public string duplicatenumb { get; set; }
    }

}
