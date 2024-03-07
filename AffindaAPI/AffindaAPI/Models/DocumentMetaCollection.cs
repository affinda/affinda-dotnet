// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The DocumentMetaCollection. </summary>
    public partial class DocumentMetaCollection
    {
        /// <summary> Initializes a new instance of DocumentMetaCollection. </summary>
        /// <param name="identifier"> Uniquely identify a collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        public DocumentMetaCollection(string identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }

            Identifier = identifier;
            ValidationRules = new ChangeTrackingList<ValidationRule>();
        }

        /// <summary> Initializes a new instance of DocumentMetaCollection. </summary>
        /// <param name="identifier"> Uniquely identify a collection. </param>
        /// <param name="name"></param>
        /// <param name="extractor"></param>
        /// <param name="validationRules"></param>
        internal DocumentMetaCollection(string identifier, string name, DocumentMetaCollectionExtractor extractor, IList<ValidationRule> validationRules)
        {
            Identifier = identifier;
            Name = name;
            Extractor = extractor;
            ValidationRules = validationRules;
        }

        /// <summary> Uniquely identify a collection. </summary>
        public string Identifier { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the extractor. </summary>
        public DocumentMetaCollectionExtractor Extractor { get; set; }
        /// <summary> Gets the validation rules. </summary>
        public IList<ValidationRule> ValidationRules { get; }
    }
}
