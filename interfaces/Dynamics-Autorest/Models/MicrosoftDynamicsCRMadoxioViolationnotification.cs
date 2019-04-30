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
    /// adoxio_violationnotification
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioViolationnotification
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioViolationnotification class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioViolationnotification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioViolationnotification class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioViolationnotification(object exchangerate = default(object), string _modifiedbyValue = default(string), int? adoxioContravention = default(int?), object adoxioOverridepenaltyamount = default(object), string adoxioName = default(string), int? adoxioPaymentoptions = default(int?), int? timezoneruleversionnumber = default(int?), string _transactioncurrencyidValue = default(string), string _adoxioRespondedpersonValue = default(string), string _owningteamValue = default(string), string adoxioLicenseename = default(string), int? adoxioLicenseeresponse = default(int?), string _owneridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioNotificationpaymentbuttonplaceholder = default(string), int? adoxioPenaltyactiontype = default(int?), string _adoxioRelatedcontraventionValue = default(string), string _owninguserValue = default(string), string _modifiedonbehalfbyValue = default(string), string adoxioPaymentmessage = default(string), int? importsequencenumber = default(int?), string _createdbyValue = default(string), string _adoxioViolationtypeValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), long? versionnumber = default(long?), int? utcconversiontimezonecode = default(int?), object adoxioMonetarypenaltyamount = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object adoxioOverridepenaltyamountBase = default(object), bool? adoxioInvoicepaid = default(bool?), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), bool? adoxioAgreetodenyfault = default(bool?), string adoxioViolationnotificationid = default(string), string adoxioDescription = default(string), string _adoxioLicenceValue = default(string), int? statuscode = default(int?), object adoxioMonetarypenaltyamountBase = default(object), int? adoxioOverridesuspensiondays = default(int?), string _adoxioInvoiceValue = default(string), bool? adoxioAgreetowaiverofacceptance = default(bool?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? adoxioResponsedate = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioViolationnotificationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioViolationnotificationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioViolationnotificationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioViolationnotificationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioViolationnotificationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMadoxioContravention adoxioRelatedContravention = default(MicrosoftDynamicsCRMadoxioContravention), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioViolationtype adoxioViolationType = default(MicrosoftDynamicsCRMadoxioViolationtype), MicrosoftDynamicsCRMcontact adoxioRespondedPerson = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMinvoice adoxioInvoice = default(MicrosoftDynamicsCRMinvoice))
        {
            Exchangerate = exchangerate;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioContravention = adoxioContravention;
            AdoxioOverridepenaltyamount = adoxioOverridepenaltyamount;
            AdoxioName = adoxioName;
            AdoxioPaymentoptions = adoxioPaymentoptions;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._adoxioRespondedpersonValue = _adoxioRespondedpersonValue;
            this._owningteamValue = _owningteamValue;
            AdoxioLicenseename = adoxioLicenseename;
            AdoxioLicenseeresponse = adoxioLicenseeresponse;
            this._owneridValue = _owneridValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioNotificationpaymentbuttonplaceholder = adoxioNotificationpaymentbuttonplaceholder;
            AdoxioPenaltyactiontype = adoxioPenaltyactiontype;
            this._adoxioRelatedcontraventionValue = _adoxioRelatedcontraventionValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioPaymentmessage = adoxioPaymentmessage;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            this._adoxioViolationtypeValue = _adoxioViolationtypeValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioMonetarypenaltyamount = adoxioMonetarypenaltyamount;
            Modifiedon = modifiedon;
            AdoxioOverridepenaltyamountBase = adoxioOverridepenaltyamountBase;
            AdoxioInvoicepaid = adoxioInvoicepaid;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioAgreetodenyfault = adoxioAgreetodenyfault;
            AdoxioViolationnotificationid = adoxioViolationnotificationid;
            AdoxioDescription = adoxioDescription;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            Statuscode = statuscode;
            AdoxioMonetarypenaltyamountBase = adoxioMonetarypenaltyamountBase;
            AdoxioOverridesuspensiondays = adoxioOverridesuspensiondays;
            this._adoxioInvoiceValue = _adoxioInvoiceValue;
            AdoxioAgreetowaiverofacceptance = adoxioAgreetowaiverofacceptance;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioResponsedate = adoxioResponsedate;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioViolationnotificationSyncErrors = adoxioViolationnotificationSyncErrors;
            AdoxioViolationnotificationDuplicateMatchingRecord = adoxioViolationnotificationDuplicateMatchingRecord;
            AdoxioViolationnotificationDuplicateBaseRecord = adoxioViolationnotificationDuplicateBaseRecord;
            AdoxioViolationnotificationAsyncOperations = adoxioViolationnotificationAsyncOperations;
            AdoxioViolationnotificationBulkDeleteFailures = adoxioViolationnotificationBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioRelatedContravention = adoxioRelatedContravention;
            AdoxioLicence = adoxioLicence;
            AdoxioViolationType = adoxioViolationType;
            AdoxioRespondedPerson = adoxioRespondedPerson;
            AdoxioInvoice = adoxioInvoice;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention")]
        public int? AdoxioContravention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_overridepenaltyamount")]
        public object AdoxioOverridepenaltyamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentoptions")]
        public int? AdoxioPaymentoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_respondedperson_value")]
        public string _adoxioRespondedpersonValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseename")]
        public string AdoxioLicenseename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseeresponse")]
        public int? AdoxioLicenseeresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_notificationpaymentbuttonplaceholder")]
        public string AdoxioNotificationpaymentbuttonplaceholder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltyactiontype")]
        public int? AdoxioPenaltyactiontype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedcontravention_value")]
        public string _adoxioRelatedcontraventionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentmessage")]
        public string AdoxioPaymentmessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_violationtype_value")]
        public string _adoxioViolationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_monetarypenaltyamount")]
        public object AdoxioMonetarypenaltyamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_overridepenaltyamount_base")]
        public object AdoxioOverridepenaltyamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_invoicepaid")]
        public bool? AdoxioInvoicepaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agreetodenyfault")]
        public bool? AdoxioAgreetodenyfault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotificationid")]
        public string AdoxioViolationnotificationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_description")]
        public string AdoxioDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_monetarypenaltyamount_base")]
        public object AdoxioMonetarypenaltyamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_overridesuspensiondays")]
        public int? AdoxioOverridesuspensiondays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_invoice_value")]
        public string _adoxioInvoiceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agreetowaiverofacceptance")]
        public bool? AdoxioAgreetowaiverofacceptance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsedate")]
        public System.DateTimeOffset? AdoxioResponsedate { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_violationnotification_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioViolationnotificationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioViolationnotificationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioViolationnotificationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioViolationnotificationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioViolationnotificationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedContravention")]
        public MicrosoftDynamicsCRMadoxioContravention AdoxioRelatedContravention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ViolationType")]
        public MicrosoftDynamicsCRMadoxioViolationtype AdoxioViolationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RespondedPerson")]
        public MicrosoftDynamicsCRMcontact AdoxioRespondedPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Invoice")]
        public MicrosoftDynamicsCRMinvoice AdoxioInvoice { get; set; }

    }
}
