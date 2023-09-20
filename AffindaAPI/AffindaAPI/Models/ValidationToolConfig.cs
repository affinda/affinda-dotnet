// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> Configuration of the embeddable validation tool. </summary>
    internal partial class ValidationToolConfig
    {
        /// <summary> Initializes a new instance of ValidationToolConfig. </summary>
        internal ValidationToolConfig()
        {
        }

        /// <summary> Gets the theme. </summary>
        public ThemeConfig Theme { get; }
        /// <summary> Hide the confirm document button and other actions. </summary>
        public bool? HideActions { get; }
        /// <summary> Hide the collection selector. </summary>
        public bool? HideCollection { get; }
        /// <summary> Hide the export menu. </summary>
        public bool? HideExport { get; }
        /// <summary> Hide the filename input. </summary>
        public bool? HideFilename { get; }
        /// <summary> Hide the tags editor. </summary>
        public bool? HideTags { get; }
        /// <summary> Hide the warnings panel. </summary>
        public bool? HideWarnings { get; }
        /// <summary> Disables the page editor after a document has been split once. </summary>
        public bool? RestrictDocumentSplitting { get; }
        /// <summary> Disables currency formatting of decimals values. </summary>
        public bool? DisableCurrencyFormatting { get; }
    }
}
