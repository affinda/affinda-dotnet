// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The Meta. </summary>
    public partial class Meta
    {
        /// <summary> Initializes a new instance of Meta. </summary>
        internal Meta()
        {
            ChildDocuments = new ChangeTrackingList<MetaChildDocumentsItem>();
            Pages = new ChangeTrackingList<PageMeta>();
        }

        /// <summary> Initializes a new instance of Meta. </summary>
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
        /// <param name="isVerified"> This is true if the &apos;confirm&apos; button has been clicked in the Affinda validation tool. </param>
        /// <param name="reviewUrl"> Signed URL (valid for 60 minutes) to access the validation tool.  Not applicable for documents types such a resumes. </param>
        /// <param name="ocrConfidence"> The overall confidence in the conversion of image to text.  (only applicable for images or PDF documents without a text layer). </param>
        /// <param name="createdDt"></param>
        /// <param name="documentType"></param>
        /// <param name="regionBias"></param>
        internal Meta(string identifier, string customIdentifier, string fileName, bool? ready, DateTimeOffset? readyDt, bool? failed, string expiryTime, string language, string pdf, MetaParentDocument parentDocument, IReadOnlyList<MetaChildDocumentsItem> childDocuments, IReadOnlyList<PageMeta> pages, bool? isVerified, string reviewUrl, float? ocrConfidence, DateTimeOffset? createdDt, string documentType, RegionBias regionBias)
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
            IsVerified = isVerified;
            ReviewUrl = reviewUrl;
            OcrConfidence = ocrConfidence;
            CreatedDt = createdDt;
            DocumentType = documentType;
            RegionBias = regionBias;
        }

        /// <summary> Unique identifier for the document. </summary>
        public string Identifier { get; }
        /// <summary> Optional identifier for the document that you can set to track the document in the Affinda system.  Is not required to be unique. </summary>
        public string CustomIdentifier { get; }
        /// <summary> Optional filename of the file. </summary>
        public string FileName { get; }
        /// <summary> If true, the document has finished processing. Particularly useful if an endpoint request specified wait=False, when polling use this variable to determine when to stop polling. </summary>
        public bool? Ready { get; }
        /// <summary> The datetime when the document was ready. </summary>
        public DateTimeOffset? ReadyDt { get; }
        /// <summary> If true, some exception was raised during processing. Check the &apos;error&apos; field of the main return object. </summary>
        public bool? Failed { get; }
        /// <summary> The date/time in ISO-8601 format when the document will be automatically deleted.  Defaults to no expiry. </summary>
        public string ExpiryTime { get; }
        /// <summary> The document&apos;s language. </summary>
        public string Language { get; }
        /// <summary> The URL to the document&apos;s pdf (if the uploaded document is not already pdf, it&apos;s converted to pdf as part of the parsing process). </summary>
        public string Pdf { get; }
        /// <summary> If this document is part of a splitted document, this attribute points to the original document that this document is splitted from. </summary>
        public MetaParentDocument ParentDocument { get; }
        /// <summary> If this document has been splitted into a number of child documents, this attribute points to those child documents. </summary>
        public IReadOnlyList<MetaChildDocumentsItem> ChildDocuments { get; }
        /// <summary> The document&apos;s pages. </summary>
        public IReadOnlyList<PageMeta> Pages { get; }
        /// <summary> This is true if the &apos;confirm&apos; button has been clicked in the Affinda validation tool. </summary>
        public bool? IsVerified { get; }
        /// <summary> Signed URL (valid for 60 minutes) to access the validation tool.  Not applicable for documents types such a resumes. </summary>
        public string ReviewUrl { get; }
        /// <summary> The overall confidence in the conversion of image to text.  (only applicable for images or PDF documents without a text layer). </summary>
        public float? OcrConfidence { get; }
        /// <summary> Gets the created dt. </summary>
        public DateTimeOffset? CreatedDt { get; }
        /// <summary> Gets the document type. </summary>
        public string DocumentType { get; }
        /// <summary> Gets the region bias. </summary>
        public RegionBias RegionBias { get; }
    }
}
