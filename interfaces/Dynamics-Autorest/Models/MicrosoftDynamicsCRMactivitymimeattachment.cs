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
    /// activitymimeattachment
    /// </summary>
    public partial class MicrosoftDynamicsCRMactivitymimeattachment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactivitymimeattachment class.
        /// </summary>
        public MicrosoftDynamicsCRMactivitymimeattachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactivitymimeattachment class.
        /// </summary>
        public MicrosoftDynamicsCRMactivitymimeattachment(long? versionnumber = default(long?), string filename = default(string), string _attachmentidValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? filesize = default(int?), int? attachmentnumber = default(int?), string activitymimeattachmentid = default(string), string activitysubject = default(string), string _owninguserValue = default(string), bool? isfollowed = default(bool?), string objecttypecode = default(string), string activitymimeattachmentidunique = default(string), string mimetype = default(string), int? componentstate = default(int?), string subject = default(string), string _owneridValue = default(string), string _objectidValue = default(string), string solutionid = default(string), string _owningbusinessunitValue = default(string), string body = default(string), object bodyBinary = default(object), string attachmentcontentid = default(string), string anonymouslink = default(string), bool? ismanaged = default(bool?), IList<MicrosoftDynamicsCRMsyncerror> activityMimeAttachmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMemail objectidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMactivitypointer objectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMtemplate objectidTemplate = default(MicrosoftDynamicsCRMtemplate), MicrosoftDynamicsCRMattachment attachmentid = default(MicrosoftDynamicsCRMattachment), MicrosoftDynamicsCRMappointment objectidAppointment = default(MicrosoftDynamicsCRMappointment), IList<MicrosoftDynamicsCRMasyncoperation> activityMimeAttachmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityMimeAttachmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>))
        {
            Versionnumber = versionnumber;
            Filename = filename;
            this._attachmentidValue = _attachmentidValue;
            Overwritetime = overwritetime;
            Filesize = filesize;
            Attachmentnumber = attachmentnumber;
            Activitymimeattachmentid = activitymimeattachmentid;
            Activitysubject = activitysubject;
            this._owninguserValue = _owninguserValue;
            Isfollowed = isfollowed;
            Objecttypecode = objecttypecode;
            Activitymimeattachmentidunique = activitymimeattachmentidunique;
            Mimetype = mimetype;
            Componentstate = componentstate;
            Subject = subject;
            this._owneridValue = _owneridValue;
            this._objectidValue = _objectidValue;
            Solutionid = solutionid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Body = body;
            BodyBinary = bodyBinary;
            Attachmentcontentid = attachmentcontentid;
            Anonymouslink = anonymouslink;
            Ismanaged = ismanaged;
            ActivityMimeAttachmentSyncErrors = activityMimeAttachmentSyncErrors;
            ObjectidEmail = objectidEmail;
            ObjectidActivitypointer = objectidActivitypointer;
            ObjectidTemplate = objectidTemplate;
            Attachmentid = attachmentid;
            ObjectidAppointment = objectidAppointment;
            ActivityMimeAttachmentAsyncOperations = activityMimeAttachmentAsyncOperations;
            ActivityMimeAttachmentBulkDeleteFailures = activityMimeAttachmentBulkDeleteFailures;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_attachmentid_value")]
        public string _attachmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentnumber")]
        public int? Attachmentnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitymimeattachmentid")]
        public string Activitymimeattachmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitysubject")]
        public string Activitysubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isfollowed")]
        public bool? Isfollowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitymimeattachmentidunique")]
        public string Activitymimeattachmentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body_binary")]
        public object BodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentcontentid")]
        public string Attachmentcontentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "anonymouslink")]
        public string Anonymouslink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityMimeAttachment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ActivityMimeAttachmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_email")]
        public MicrosoftDynamicsCRMemail ObjectidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ObjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_template")]
        public MicrosoftDynamicsCRMtemplate ObjectidTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentid")]
        public MicrosoftDynamicsCRMattachment Attachmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_appointment")]
        public MicrosoftDynamicsCRMappointment ObjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityMimeAttachment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ActivityMimeAttachmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityMimeAttachment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ActivityMimeAttachmentBulkDeleteFailures { get; set; }

    }
}
