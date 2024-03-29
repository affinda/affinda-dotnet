// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataWorkExperienceItemOccupation. </summary>
    public partial class ResumeDataWorkExperienceItemOccupation
    {
        /// <summary> Initializes a new instance of ResumeDataWorkExperienceItemOccupation. </summary>
        internal ResumeDataWorkExperienceItemOccupation()
        {
        }

        /// <summary> Initializes a new instance of ResumeDataWorkExperienceItemOccupation. </summary>
        /// <param name="jobTitle"> The raw (not normalized) job title pulled from the work experience entry. </param>
        /// <param name="jobTitleNormalized"> Mapped onto the EMSI job title taxonomy if a sufficiently close match exists. </param>
        /// <param name="emsiId"> EMSI id of the normalised job title. </param>
        /// <param name="managementLevel"></param>
        /// <param name="classification"></param>
        internal ResumeDataWorkExperienceItemOccupation(string jobTitle, string jobTitleNormalized, string emsiId, ManagementLevel? managementLevel, Components1TryetgSchemasResumedataPropertiesWorkexperienceItemsPropertiesOccupationPropertiesClassification classification)
        {
            JobTitle = jobTitle;
            JobTitleNormalized = jobTitleNormalized;
            EmsiId = emsiId;
            ManagementLevel = managementLevel;
            Classification = classification;
        }

        /// <summary> The raw (not normalized) job title pulled from the work experience entry. </summary>
        public string JobTitle { get; }
        /// <summary> Mapped onto the EMSI job title taxonomy if a sufficiently close match exists. </summary>
        public string JobTitleNormalized { get; }
        /// <summary> EMSI id of the normalised job title. </summary>
        public string EmsiId { get; }
        /// <summary> Gets the management level. </summary>
        public ManagementLevel? ManagementLevel { get; }
        /// <summary> Gets the classification. </summary>
        public Components1TryetgSchemasResumedataPropertiesWorkexperienceItemsPropertiesOccupationPropertiesClassification Classification { get; }
    }
}
