// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_investigationactivity
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioInvestigationactivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInvestigationactivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInvestigationactivity(string _modifiedonbehalfbyValue = default(string), string adoxioName = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioDescription = default(string), System.DateTimeOffset? adoxioActivitydate = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statecode = default(int?), string adoxioInvestigationactivityid = default(string), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string _adoxioComplaintidValue = default(string), int? adoxioType = default(int?), string _adoxioInvestigationidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string adoxioOtheractivitytype = default(string), string _adoxioInspectionidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string _owningteamValue = default(string), int? importsequencenumber = default(int?), long? versionnumber = default(long?), string _adoxioContraventionidValue = default(string), string _modifiedbyValue = default(string), string _owneridValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioInvestigationactivitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationactivityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationactivityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioInvestigationactivityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioInvestigationactivityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioComplianceinvestigation adoxioInvestigationId = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMadoxioComplaint adoxioComplaintId = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioContravention adoxioContraventionId = default(MicrosoftDynamicsCRMadoxioContravention), MicrosoftDynamicsCRMincident adoxioInspectionId = default(MicrosoftDynamicsCRMincident))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioName = adoxioName;
            Modifiedon = modifiedon;
            AdoxioDescription = adoxioDescription;
            AdoxioActivitydate = adoxioActivitydate;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            AdoxioInvestigationactivityid = adoxioInvestigationactivityid;
            this._owninguserValue = _owninguserValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._adoxioComplaintidValue = _adoxioComplaintidValue;
            AdoxioType = adoxioType;
            this._adoxioInvestigationidValue = _adoxioInvestigationidValue;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioOtheractivitytype = adoxioOtheractivitytype;
            this._adoxioInspectionidValue = _adoxioInspectionidValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            this._adoxioContraventionidValue = _adoxioContraventionidValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioInvestigationactivitySyncErrors = adoxioInvestigationactivitySyncErrors;
            AdoxioInvestigationactivityDuplicateMatchingRecord = adoxioInvestigationactivityDuplicateMatchingRecord;
            AdoxioInvestigationactivityDuplicateBaseRecord = adoxioInvestigationactivityDuplicateBaseRecord;
            AdoxioInvestigationactivityAsyncOperations = adoxioInvestigationactivityAsyncOperations;
            AdoxioInvestigationactivityBulkDeleteFailures = adoxioInvestigationactivityBulkDeleteFailures;
            AdoxioInvestigationId = adoxioInvestigationId;
            AdoxioComplaintId = adoxioComplaintId;
            AdoxioContraventionId = adoxioContraventionId;
            AdoxioInspectionId = adoxioInspectionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_description")]
        public string AdoxioDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_activitydate")]
        public System.DateTimeOffset? AdoxioActivitydate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivityid")]
        public string AdoxioInvestigationactivityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_complaintid_value")]
        public string _adoxioComplaintidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_type")]
        public int? AdoxioType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationid_value")]
        public string _adoxioInvestigationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otheractivitytype")]
        public string AdoxioOtheractivitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspectionid_value")]
        public string _adoxioInspectionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contraventionid_value")]
        public string _adoxioContraventionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioInvestigationactivitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationactivityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationactivityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioInvestigationactivityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioInvestigationactivityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationId")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation AdoxioInvestigationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ComplaintId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioComplaintId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContraventionId")]
        public MicrosoftDynamicsCRMadoxioContravention AdoxioContraventionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectionId")]
        public MicrosoftDynamicsCRMincident AdoxioInspectionId { get; set; }

    }
}
