// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchParametersLocationCoordinates. </summary>
    public partial class ResumeSearchParametersLocationCoordinates
    {
        /// <summary> Initializes a new instance of ResumeSearchParametersLocationCoordinates. </summary>
        public ResumeSearchParametersLocationCoordinates()
        {
        }

        /// <summary> Initializes a new instance of ResumeSearchParametersLocationCoordinates. </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        internal ResumeSearchParametersLocationCoordinates(float? latitude, float? longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary> Gets or sets the latitude. </summary>
        public float? Latitude { get; set; }
        /// <summary> Gets or sets the longitude. </summary>
        public float? Longitude { get; set; }
    }
}
