// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The SplitRelation. </summary>
    public partial class SplitRelation
    {
        /// <summary> Initializes a new instance of SplitRelation. </summary>
        internal SplitRelation()
        {
        }

        /// <summary> Initializes a new instance of SplitRelation. </summary>
        /// <param name="identifier"> Unique identifier for the document. If creating a document and left blank, one will be automatically generated. </param>
        internal SplitRelation(string identifier)
        {
            Identifier = identifier;
        }

        /// <summary> Unique identifier for the document. If creating a document and left blank, one will be automatically generated. </summary>
        public string Identifier { get; }
    }
}
