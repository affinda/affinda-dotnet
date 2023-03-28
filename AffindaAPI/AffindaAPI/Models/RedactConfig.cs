// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The RedactConfig. </summary>
    public partial class RedactConfig
    {
        /// <summary> Initializes a new instance of RedactConfig. </summary>
        public RedactConfig()
        {
        }

        /// <summary> Initializes a new instance of RedactConfig. </summary>
        /// <param name="redactHeadshot"></param>
        /// <param name="redactPersonalDetails"></param>
        /// <param name="redactWorkDetails"></param>
        /// <param name="redactReferees"></param>
        /// <param name="redactEducationDetails"></param>
        /// <param name="redactLocations"></param>
        /// <param name="redactDates"></param>
        /// <param name="redactGender"></param>
        internal RedactConfig(bool? redactHeadshot, bool? redactPersonalDetails, bool? redactWorkDetails, bool? redactReferees, bool? redactEducationDetails, bool? redactLocations, bool? redactDates, bool? redactGender)
        {
            RedactHeadshot = redactHeadshot;
            RedactPersonalDetails = redactPersonalDetails;
            RedactWorkDetails = redactWorkDetails;
            RedactReferees = redactReferees;
            RedactEducationDetails = redactEducationDetails;
            RedactLocations = redactLocations;
            RedactDates = redactDates;
            RedactGender = redactGender;
        }

        /// <summary> Gets or sets the redact headshot. </summary>
        public bool? RedactHeadshot { get; set; }
        /// <summary> Gets or sets the redact personal details. </summary>
        public bool? RedactPersonalDetails { get; set; }
        /// <summary> Gets or sets the redact work details. </summary>
        public bool? RedactWorkDetails { get; set; }
        /// <summary> Gets or sets the redact referees. </summary>
        public bool? RedactReferees { get; set; }
        /// <summary> Gets or sets the redact education details. </summary>
        public bool? RedactEducationDetails { get; set; }
        /// <summary> Gets or sets the redact locations. </summary>
        public bool? RedactLocations { get; set; }
        /// <summary> Gets or sets the redact dates. </summary>
        public bool? RedactDates { get; set; }
        /// <summary> Gets or sets the redact gender. </summary>
        public bool? RedactGender { get; set; }
    }
}