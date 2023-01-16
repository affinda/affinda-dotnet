// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The DocumentMetaCollectionExtractor. </summary>
    public partial class DocumentMetaCollectionExtractor
    {
        /// <summary> Initializes a new instance of DocumentMetaCollectionExtractor. </summary>
        internal DocumentMetaCollectionExtractor()
        {
        }

        /// <summary> Initializes a new instance of DocumentMetaCollectionExtractor. </summary>
        /// <param name="id"> Extractor&apos;s ID. </param>
        /// <param name="identifier"></param>
        /// <param name="name"></param>
        /// <param name="baseExtractor"> Base extractor&apos;s ID. </param>
        /// <param name="validatable"></param>
        internal DocumentMetaCollectionExtractor(int? id, string identifier, string name, int? baseExtractor, bool? validatable)
        {
            Id = id;
            Identifier = identifier;
            Name = name;
            BaseExtractor = baseExtractor;
            Validatable = validatable;
        }

        /// <summary> Extractor&apos;s ID. </summary>
        public int? Id { get; }
        /// <summary> Gets the identifier. </summary>
        public string Identifier { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Base extractor&apos;s ID. </summary>
        public int? BaseExtractor { get; }
        /// <summary> Gets the validatable. </summary>
        public bool? Validatable { get; }
    }
}
