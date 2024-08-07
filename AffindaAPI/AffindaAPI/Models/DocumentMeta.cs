// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The DocumentMeta. </summary>
    public partial class DocumentMeta
    {
        /// <summary> Initializes a new instance of DocumentMeta. </summary>
        /// <param name="identifier"> Unique identifier for the document. </param>
        /// <param name="pages"> The document&apos;s pages. </param>
        /// <param name="workspace"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/>, <paramref name="pages"/> or <paramref name="workspace"/> is null. </exception>
        public DocumentMeta(string identifier, IEnumerable<PageMeta> pages, DocumentMetaWorkspace workspace)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }
            if (pages == null)
            {
                throw new ArgumentNullException(nameof(pages));
            }
            if (workspace == null)
            {
                throw new ArgumentNullException(nameof(workspace));
            }

            Identifier = identifier;
            ChildDocuments = new ChangeTrackingList<DocumentMetaChildDocumentsItem>();
            Pages = pages.ToList();
            Workspace = workspace;
            Tags = new ChangeTrackingList<Tag>();
        }

        /// <summary> Initializes a new instance of DocumentMeta. </summary>
        /// <param name="identifier"> Unique identifier for the document. </param>
        /// <param name="customIdentifier"> Optional identifier for the document that you can set to track the document in the Affinda system.  Is not required to be unique. </param>
        /// <param name="fileName"> Optional filename of the file. </param>
        /// <param name="ready"> If true, the document has finished processing. Particularly useful if an endpoint request specified wait=False, when polling use this variable to determine when to stop polling. </param>
        /// <param name="readyDt"> The datetime when the document was ready. </param>
        /// <param name="failed"> If true, some exception was raised during processing. Check the &apos;error&apos; field of the main return object. </param>
        /// <param name="expiryTime"> The date/time in ISO-8601 format when the document will be automatically deleted.  Defaults to no expiry. </param>
        /// <param name="language"> The document&apos;s language. </param>
        /// <param name="pdf"> The URL to the document&apos;s pdf (if the uploaded document is not already pdf, it&apos;s converted to pdf as part of the parsing process). </param>
        /// <param name="parentDocument"> If this document is part of a splitted document, this attribute points to the original document that this document is splitted from. </param>
        /// <param name="childDocuments"> If this document has been splitted into a number of child documents, this attribute points to those child documents. </param>
        /// <param name="pages"> The document&apos;s pages. </param>
        /// <param name="isOcrd"></param>
        /// <param name="ocrConfidence"></param>
        /// <param name="reviewUrl"></param>
        /// <param name="collection"></param>
        /// <param name="workspace"></param>
        /// <param name="archivedDt"></param>
        /// <param name="isArchived"></param>
        /// <param name="skipParse"></param>
        /// <param name="confirmedDt"></param>
        /// <param name="confirmedBy"></param>
        /// <param name="isConfirmed"></param>
        /// <param name="rejectedDt"></param>
        /// <param name="rejectedBy"></param>
        /// <param name="isRejected"></param>
        /// <param name="createdDt"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorDetail"></param>
        /// <param name="file"> URL to view the file. </param>
        /// <param name="html"> URL to view the file converted to HTML. </param>
        /// <param name="tags"></param>
        /// <param name="createdBy"></param>
        /// <param name="sourceEmail"> If the document is created via email ingestion, this field stores the email file&apos;s URL. </param>
        /// <param name="sourceEmailAddress"> If the document is created via email ingestion, this field stores the email&apos;s From address. </param>
        /// <param name="regionBias"></param>
        internal DocumentMeta(string identifier, string customIdentifier, string fileName, bool? ready, DateTimeOffset? readyDt, bool? failed, string expiryTime, string language, string pdf, DocumentMetaParentDocument parentDocument, IList<DocumentMetaChildDocumentsItem> childDocuments, IList<PageMeta> pages, bool? isOcrd, float? ocrConfidence, string reviewUrl, DocumentMetaCollection collection, DocumentMetaWorkspace workspace, DateTimeOffset? archivedDt, bool? isArchived, bool? skipParse, DateTimeOffset? confirmedDt, UserNullable confirmedBy, bool? isConfirmed, DateTimeOffset? rejectedDt, UserNullable rejectedBy, bool? isRejected, DateTimeOffset? createdDt, string errorCode, string errorDetail, string file, string html, IList<Tag> tags, User createdBy, string sourceEmail, string sourceEmailAddress, RegionBias regionBias)
        {
            Identifier = identifier;
            CustomIdentifier = customIdentifier;
            FileName = fileName;
            Ready = ready;
            ReadyDt = readyDt;
            Failed = failed;
            ExpiryTime = expiryTime;
            Language = language;
            Pdf = pdf;
            ParentDocument = parentDocument;
            ChildDocuments = childDocuments;
            Pages = pages;
            IsOcrd = isOcrd;
            OcrConfidence = ocrConfidence;
            ReviewUrl = reviewUrl;
            Collection = collection;
            Workspace = workspace;
            ArchivedDt = archivedDt;
            IsArchived = isArchived;
            SkipParse = skipParse;
            ConfirmedDt = confirmedDt;
            ConfirmedBy = confirmedBy;
            IsConfirmed = isConfirmed;
            RejectedDt = rejectedDt;
            RejectedBy = rejectedBy;
            IsRejected = isRejected;
            CreatedDt = createdDt;
            ErrorCode = errorCode;
            ErrorDetail = errorDetail;
            File = file;
            Html = html;
            Tags = tags;
            CreatedBy = createdBy;
            SourceEmail = sourceEmail;
            SourceEmailAddress = sourceEmailAddress;
            RegionBias = regionBias;
        }

        /// <summary> Unique identifier for the document. </summary>
        public string Identifier { get; set; }
        /// <summary> Optional identifier for the document that you can set to track the document in the Affinda system.  Is not required to be unique. </summary>
        public string CustomIdentifier { get; set; }
        /// <summary> Optional filename of the file. </summary>
        public string FileName { get; set; }
        /// <summary> If true, the document has finished processing. Particularly useful if an endpoint request specified wait=False, when polling use this variable to determine when to stop polling. </summary>
        public bool? Ready { get; set; }
        /// <summary> The datetime when the document was ready. </summary>
        public DateTimeOffset? ReadyDt { get; set; }
        /// <summary> If true, some exception was raised during processing. Check the &apos;error&apos; field of the main return object. </summary>
        public bool? Failed { get; set; }
        /// <summary> The date/time in ISO-8601 format when the document will be automatically deleted.  Defaults to no expiry. </summary>
        public string ExpiryTime { get; set; }
        /// <summary> The document&apos;s language. </summary>
        public string Language { get; set; }
        /// <summary> The URL to the document&apos;s pdf (if the uploaded document is not already pdf, it&apos;s converted to pdf as part of the parsing process). </summary>
        public string Pdf { get; set; }
        /// <summary> If this document is part of a splitted document, this attribute points to the original document that this document is splitted from. </summary>
        public DocumentMetaParentDocument ParentDocument { get; set; }
        /// <summary> If this document has been splitted into a number of child documents, this attribute points to those child documents. </summary>
        public IList<DocumentMetaChildDocumentsItem> ChildDocuments { get; }
        /// <summary> The document&apos;s pages. </summary>
        public IList<PageMeta> Pages { get; }
        /// <summary> Gets or sets the is ocrd. </summary>
        public bool? IsOcrd { get; set; }
        /// <summary> Gets or sets the ocr confidence. </summary>
        public float? OcrConfidence { get; set; }
        /// <summary> Gets or sets the review url. </summary>
        public string ReviewUrl { get; set; }
        /// <summary> Gets or sets the collection. </summary>
        public DocumentMetaCollection Collection { get; set; }
        /// <summary> Gets or sets the workspace. </summary>
        public DocumentMetaWorkspace Workspace { get; set; }
        /// <summary> Gets or sets the archived dt. </summary>
        public DateTimeOffset? ArchivedDt { get; set; }
        /// <summary> Gets or sets the is archived. </summary>
        public bool? IsArchived { get; set; }
        /// <summary> Gets or sets the skip parse. </summary>
        public bool? SkipParse { get; set; }
        /// <summary> Gets or sets the confirmed dt. </summary>
        public DateTimeOffset? ConfirmedDt { get; set; }
        /// <summary> Gets or sets the confirmed by. </summary>
        public UserNullable ConfirmedBy { get; set; }
        /// <summary> Gets or sets the is confirmed. </summary>
        public bool? IsConfirmed { get; set; }
        /// <summary> Gets or sets the rejected dt. </summary>
        public DateTimeOffset? RejectedDt { get; set; }
        /// <summary> Gets or sets the rejected by. </summary>
        public UserNullable RejectedBy { get; set; }
        /// <summary> Gets or sets the is rejected. </summary>
        public bool? IsRejected { get; set; }
        /// <summary> Gets or sets the created dt. </summary>
        public DateTimeOffset? CreatedDt { get; set; }
        /// <summary> Gets or sets the error code. </summary>
        public string ErrorCode { get; set; }
        /// <summary> Gets or sets the error detail. </summary>
        public string ErrorDetail { get; set; }
        /// <summary> URL to view the file. </summary>
        public string File { get; set; }
        /// <summary> URL to view the file converted to HTML. </summary>
        public string Html { get; set; }
        /// <summary> Gets the tags. </summary>
        public IList<Tag> Tags { get; }
        /// <summary> Gets or sets the created by. </summary>
        public User CreatedBy { get; set; }
        /// <summary> If the document is created via email ingestion, this field stores the email file&apos;s URL. </summary>
        public string SourceEmail { get; set; }
        /// <summary> If the document is created via email ingestion, this field stores the email&apos;s From address. </summary>
        public string SourceEmailAddress { get; set; }
        /// <summary> Gets or sets the region bias. </summary>
        public RegionBias RegionBias { get; set; }
    }
}
