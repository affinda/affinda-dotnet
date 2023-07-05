// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The Collection. </summary>
    public partial class Collection
    {
        /// <summary> Initializes a new instance of Collection. </summary>
        /// <param name="identifier"> Uniquely identify a collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        internal Collection(string identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }

            Identifier = identifier;
            Fields = new ChangeTrackingList<FieldGroup>();
        }

        /// <summary> Initializes a new instance of Collection. </summary>
        /// <param name="identifier"> Uniquely identify a collection. </param>
        /// <param name="name"></param>
        /// <param name="workspace"></param>
        /// <param name="extractor"></param>
        /// <param name="autoValidationThreshold"></param>
        /// <param name="fields"></param>
        /// <param name="fieldsLayout"></param>
        /// <param name="fieldsConfigured"></param>
        /// <param name="dateFormatPreference"></param>
        /// <param name="dateFormatFromDocument"> Predict the date format from any dates in the document that is not ambiguous. </param>
        /// <param name="extractorConfig"> Extra configurations specific to an extractor. </param>
        /// <param name="unvalidatedDocsCount"> Number of unvalidated documents in the collection. </param>
        /// <param name="confirmedDocsCount"> Number of validated documents in the collection. </param>
        /// <param name="ingestEmail"> When you send email to this address, any document attached in the body will be uploaded to this collection. </param>
        /// <param name="tailoredExtractorRequested"> Whether a tailored extractor has been requested for this collection. </param>
        /// <param name="allowOpenai"> Whether to allow OpenAI API to be used to assist in creating a model for this collection. </param>
        internal Collection(string identifier, string name, CollectionWorkspace workspace, Extractor extractor, float? autoValidationThreshold, IReadOnlyList<FieldGroup> fields, FieldsLayout fieldsLayout, bool? fieldsConfigured, CollectionDateFormatPreference? dateFormatPreference, bool? dateFormatFromDocument, ExtractorConfig extractorConfig, int? unvalidatedDocsCount, int? confirmedDocsCount, string ingestEmail, bool? tailoredExtractorRequested, bool? allowOpenai)
        {
            Identifier = identifier;
            Name = name;
            Workspace = workspace;
            Extractor = extractor;
            AutoValidationThreshold = autoValidationThreshold;
            Fields = fields;
            FieldsLayout = fieldsLayout;
            FieldsConfigured = fieldsConfigured;
            DateFormatPreference = dateFormatPreference;
            DateFormatFromDocument = dateFormatFromDocument;
            ExtractorConfig = extractorConfig;
            UnvalidatedDocsCount = unvalidatedDocsCount;
            ConfirmedDocsCount = confirmedDocsCount;
            IngestEmail = ingestEmail;
            TailoredExtractorRequested = tailoredExtractorRequested;
            AllowOpenai = allowOpenai;
        }

        /// <summary> Uniquely identify a collection. </summary>
        public string Identifier { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the workspace. </summary>
        public CollectionWorkspace Workspace { get; }
        /// <summary> Gets the extractor. </summary>
        public Extractor Extractor { get; }
        /// <summary> Gets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; }
        /// <summary> Gets the fields. </summary>
        public IReadOnlyList<FieldGroup> Fields { get; }
        /// <summary> Gets the fields layout. </summary>
        public FieldsLayout FieldsLayout { get; }
        /// <summary> Gets the fields configured. </summary>
        public bool? FieldsConfigured { get; }
        /// <summary> Gets the date format preference. </summary>
        public CollectionDateFormatPreference? DateFormatPreference { get; }
        /// <summary> Predict the date format from any dates in the document that is not ambiguous. </summary>
        public bool? DateFormatFromDocument { get; }
        /// <summary> Extra configurations specific to an extractor. </summary>
        public ExtractorConfig ExtractorConfig { get; }
        /// <summary> Number of unvalidated documents in the collection. </summary>
        public int? UnvalidatedDocsCount { get; }
        /// <summary> Number of validated documents in the collection. </summary>
        public int? ConfirmedDocsCount { get; }
        /// <summary> When you send email to this address, any document attached in the body will be uploaded to this collection. </summary>
        public string IngestEmail { get; }
        /// <summary> Whether a tailored extractor has been requested for this collection. </summary>
        public bool? TailoredExtractorRequested { get; }
        /// <summary> Whether to allow OpenAI API to be used to assist in creating a model for this collection. </summary>
        public bool? AllowOpenai { get; }
    }
}
