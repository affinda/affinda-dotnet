// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The DocumentMetaChildDocumentsItem. </summary>
    public partial class DocumentMetaChildDocumentsItem
    {
        /// <summary> Initializes a new instance of DocumentMetaChildDocumentsItem. </summary>
        public DocumentMetaChildDocumentsItem()
        {
        }

        /// <summary> Initializes a new instance of DocumentMetaChildDocumentsItem. </summary>
        /// <param name="identifier"> Uniquely identify a document. </param>
        internal DocumentMetaChildDocumentsItem(string identifier)
        {
            Identifier = identifier;
        }

        /// <summary> Uniquely identify a document. </summary>
        public string Identifier { get; set; }
    }
}
