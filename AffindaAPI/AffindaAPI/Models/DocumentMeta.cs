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
        /// <param name="identifier"> Uniquely identify a document. </param>
        /// <param name="pages"> The document&apos;s pages. </param>
        /// <param name="workspace"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/>, <paramref name="pages"/> or <paramref name="workspace"/> is null. </exception>
        internal DocumentMeta(string identifier, IEnumerable<PageMeta> pages, DocumentMetaWorkspace workspace)
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
        /// <param name="identifier"> Uniquely identify a document. </param>
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
        /// <param name="confirmedDt"></param>
        /// <param name="isConfirmed"></param>
        /// <param name="rejectedDt"></param>
        /// <param name="isRejected"></param>
        /// <param name="createdDt"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorDetail"></param>
        /// <param name="file"> URL to view the file. </param>
        /// <param name="tags"></param>
        internal DocumentMeta(string identifier, string fileName, bool? ready, DateTimeOffset? readyDt, bool? failed, string expiryTime, string language, string pdf, DocumentMetaParentDocument parentDocument, IReadOnlyList<DocumentMetaChildDocumentsItem> childDocuments, IReadOnlyList<PageMeta> pages, bool? isOcrd, float? ocrConfidence, string reviewUrl, DocumentMetaCollection collection, DocumentMetaWorkspace workspace, DateTimeOffset? archivedDt, bool? isArchived, DateTimeOffset? confirmedDt, bool? isConfirmed, DateTimeOffset? rejectedDt, bool? isRejected, DateTimeOffset? createdDt, string errorCode, string errorDetail, string file, IReadOnlyList<Tag> tags)
        {
            Identifier = identifier;
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
            ConfirmedDt = confirmedDt;
            IsConfirmed = isConfirmed;
            RejectedDt = rejectedDt;
            IsRejected = isRejected;
            CreatedDt = createdDt;
            ErrorCode = errorCode;
            ErrorDetail = errorDetail;
            File = file;
            Tags = tags;
        }

        /// <summary> Uniquely identify a document. </summary>
        public string Identifier { get; }
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
        public DocumentMetaParentDocument ParentDocument { get; }
        /// <summary> If this document has been splitted into a number of child documents, this attribute points to those child documents. </summary>
        public IReadOnlyList<DocumentMetaChildDocumentsItem> ChildDocuments { get; }
        /// <summary> The document&apos;s pages. </summary>
        public IReadOnlyList<PageMeta> Pages { get; }
        /// <summary> Gets the is ocrd. </summary>
        public bool? IsOcrd { get; }
        /// <summary> Gets the ocr confidence. </summary>
        public float? OcrConfidence { get; }
        /// <summary> Gets the review url. </summary>
        public string ReviewUrl { get; }
        /// <summary> Gets the collection. </summary>
        public DocumentMetaCollection Collection { get; }
        /// <summary> Gets the workspace. </summary>
        public DocumentMetaWorkspace Workspace { get; }
        /// <summary> Gets the archived dt. </summary>
        public DateTimeOffset? ArchivedDt { get; }
        /// <summary> Gets the is archived. </summary>
        public bool? IsArchived { get; }
        /// <summary> Gets the confirmed dt. </summary>
        public DateTimeOffset? ConfirmedDt { get; }
        /// <summary> Gets the is confirmed. </summary>
        public bool? IsConfirmed { get; }
        /// <summary> Gets the rejected dt. </summary>
        public DateTimeOffset? RejectedDt { get; }
        /// <summary> Gets the is rejected. </summary>
        public bool? IsRejected { get; }
        /// <summary> Gets the created dt. </summary>
        public DateTimeOffset? CreatedDt { get; }
        /// <summary> Gets the error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Gets the error detail. </summary>
        public string ErrorDetail { get; }
        /// <summary> URL to view the file. </summary>
        public string File { get; }
        /// <summary> Gets the tags. </summary>
        public IReadOnlyList<Tag> Tags { get; }
    }
}