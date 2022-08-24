// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetail. </summary>
    public partial class JobDescriptionSearchDetail
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetail. </summary>
        internal JobDescriptionSearchDetail()
        {
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetail. </summary>
        /// <param name="jobTitle"></param>
        /// <param name="location"></param>
        /// <param name="education"></param>
        /// <param name="skills"></param>
        /// <param name="experience"></param>
        /// <param name="occupationGroup"></param>
        /// <param name="languages"></param>
        /// <param name="managementLevel"></param>
        /// <param name="searchExpression"></param>
        internal JobDescriptionSearchDetail(JobDescriptionSearchDetailJobTitle jobTitle, JobDescriptionSearchDetailLocation location, JobDescriptionSearchDetailEducation education, JobDescriptionSearchDetailSkills skills, JobDescriptionSearchDetailExperience experience, JobDescriptionSearchDetailOccupationGroup occupationGroup, JobDescriptionSearchDetailLanguages languages, JobDescriptionSearchDetailManagementLevel managementLevel, JobDescriptionSearchDetailSearchExpression searchExpression)
        {
            JobTitle = jobTitle;
            Location = location;
            Education = education;
            Skills = skills;
            Experience = experience;
            OccupationGroup = occupationGroup;
            Languages = languages;
            ManagementLevel = managementLevel;
            SearchExpression = searchExpression;
        }

        /// <summary> Gets the job title. </summary>
        public JobDescriptionSearchDetailJobTitle JobTitle { get; }
        /// <summary> Gets the location. </summary>
        public JobDescriptionSearchDetailLocation Location { get; }
        /// <summary> Gets the education. </summary>
        public JobDescriptionSearchDetailEducation Education { get; }
        /// <summary> Gets the skills. </summary>
        public JobDescriptionSearchDetailSkills Skills { get; }
        /// <summary> Gets the experience. </summary>
        public JobDescriptionSearchDetailExperience Experience { get; }
        /// <summary> Gets the occupation group. </summary>
        public JobDescriptionSearchDetailOccupationGroup OccupationGroup { get; }
        /// <summary> Gets the languages. </summary>
        public JobDescriptionSearchDetailLanguages Languages { get; }
        /// <summary> Gets the management level. </summary>
        public JobDescriptionSearchDetailManagementLevel ManagementLevel { get; }
        /// <summary> Gets the search expression. </summary>
        public JobDescriptionSearchDetailSearchExpression SearchExpression { get; }
    }
}
