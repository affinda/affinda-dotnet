// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.IO;

namespace Affinda.API.Models
{
    /// <summary> The DocumentCreate. </summary>
    internal partial class DocumentCreate
    {
        /// <summary> Initializes a new instance of DocumentCreate. </summary>
        internal DocumentCreate()
        {
        }

        /// <summary> File as binary data blob. Supported formats: PDF, DOC, DOCX, TXT, RTF, HTML, PNG, JPG, TIFF, ODT, XLS, XLSX, ZIP. </summary>
        public Stream File { get; }
        /// <summary> URL to download the document. </summary>
        public string Url { get; }
        /// <summary> Create resume or job description directly from data. </summary>
        public string Data { get; }
        /// <summary> Uniquely identify a collection. </summary>
        public string Collection { get; }
        /// <summary> Uniquely identify a workspace. </summary>
        public string Workspace { get; }
        /// <summary> If &quot;true&quot; (default), will return a response only after processing has completed. If &quot;false&quot;, will return an empty data object which can be polled at the GET endpoint until processing is complete. </summary>
        public string Wait { get; }
        /// <summary> Deprecated in favor of `customIdentifier`. </summary>
        public string Identifier { get; }
        /// <summary> Specify a custom identifier for the document if you need one, not required to be unique. </summary>
        public string CustomIdentifier { get; }
        /// <summary> Optional filename of the file. </summary>
        public string FileName { get; }
        /// <summary> The date/time in ISO-8601 format when the document will be automatically deleted.  Defaults to no expiry. </summary>
        public string ExpiryTime { get; }
        /// <summary> Language code in ISO 639-1 format. Must specify zh-cn or zh-tw for Chinese. </summary>
        public string Language { get; }
        /// <summary> If &quot;true&quot;, parsing will fail when the uploaded document is duplicate of an existing document, no credits will be consumed. If &quot;false&quot;, will parse the document normally whether its a duplicate or not. If not provided, will fallback to the workspace settings. </summary>
        public string RejectDuplicates { get; }
        /// <summary> A JSON representation of the RegionBias object. </summary>
        public string RegionBias { get; }
        /// <summary> Explicitly mark this document as low priority. </summary>
        public string LowPriority { get; }
        /// <summary> If true, the returned parse result (assuming `wait` is also true) will be a compact version of the full result. </summary>
        public string Compact { get; }
        /// <summary> If true, no data will be stored after parsing. Only compatible with requests where wait: True. </summary>
        public string DeleteAfterParse { get; }
        /// <summary> If true, the document will be viewable in the Affinda Validation Tool. Set to False to optimize parsing speed. </summary>
        public string EnableValidationTool { get; }
    }
}
