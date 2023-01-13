// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The WorkspaceCollectionsItemExtractor. </summary>
    public partial class WorkspaceCollectionsItemExtractor
    {
        /// <summary> Initializes a new instance of WorkspaceCollectionsItemExtractor. </summary>
        /// <param name="id"> Extractor&apos;s ID. </param>
        /// <param name="identifier"></param>
        /// <param name="name"></param>
        /// <param name="namePlural"></param>
        /// <param name="validatable"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/>, <paramref name="name"/> or <paramref name="namePlural"/> is null. </exception>
        internal WorkspaceCollectionsItemExtractor(int id, string identifier, string name, string namePlural, bool validatable)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (namePlural == null)
            {
                throw new ArgumentNullException(nameof(namePlural));
            }

            Id = id;
            Identifier = identifier;
            Name = name;
            NamePlural = namePlural;
            Validatable = validatable;
        }

        /// <summary> Initializes a new instance of WorkspaceCollectionsItemExtractor. </summary>
        /// <param name="id"> Extractor&apos;s ID. </param>
        /// <param name="identifier"></param>
        /// <param name="name"></param>
        /// <param name="namePlural"></param>
        /// <param name="baseExtractor"></param>
        /// <param name="category"></param>
        /// <param name="validatable"></param>
        /// <param name="isCustom"></param>
        /// <param name="createdDt"></param>
        internal WorkspaceCollectionsItemExtractor(int id, string identifier, string name, string namePlural, BaseExtractor baseExtractor, string category, bool validatable, bool? isCustom, DateTimeOffset? createdDt)
        {
            Id = id;
            Identifier = identifier;
            Name = name;
            NamePlural = namePlural;
            BaseExtractor = baseExtractor;
            Category = category;
            Validatable = validatable;
            IsCustom = isCustom;
            CreatedDt = createdDt;
        }

        /// <summary> Extractor&apos;s ID. </summary>
        public int Id { get; }
        /// <summary> Gets the identifier. </summary>
        public string Identifier { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the name plural. </summary>
        public string NamePlural { get; }
        /// <summary> Gets the base extractor. </summary>
        public BaseExtractor BaseExtractor { get; }
        /// <summary> Gets the category. </summary>
        public string Category { get; }
        /// <summary> Gets the validatable. </summary>
        public bool Validatable { get; }
        /// <summary> Gets the is custom. </summary>
        public bool? IsCustom { get; }
        /// <summary> Gets the created dt. </summary>
        public DateTimeOffset? CreatedDt { get; }
    }
}
