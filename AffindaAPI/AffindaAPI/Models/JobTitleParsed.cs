// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobTitleParsed. </summary>
    internal partial class JobTitleParsed
    {
        /// <summary> Initializes a new instance of JobTitleParsed. </summary>
        internal JobTitleParsed()
        {
        }

        /// <summary> Initializes a new instance of JobTitleParsed. </summary>
        /// <param name="parsed"> Matching job title to extracted text. </param>
        internal JobTitleParsed(JobTitleParsedParsed parsed)
        {
            Parsed = parsed;
        }

        /// <summary> Matching job title to extracted text. </summary>
        public JobTitleParsedParsed Parsed { get; }
    }
}
