// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchParameters. </summary>
    public partial class JobDescriptionSearchParameters
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchParameters. </summary>
        /// <param name="indices"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="indices"/> is null. </exception>
        public JobDescriptionSearchParameters(IEnumerable<string> indices)
        {
            if (indices == null)
            {
                throw new ArgumentNullException(nameof(indices));
            }

            Indices = indices.ToList();
            JobTitles = new ChangeTrackingList<string>();
            Locations = new ChangeTrackingList<ResumeSearchParametersLocation>();
            Skills = new ChangeTrackingList<ResumeSearchParametersSkill>();
            Languages = new ChangeTrackingList<ResumeSearchParametersSkill>();
            Degrees = new ChangeTrackingList<string>();
            DegreeTypes = new ChangeTrackingList<EducationLevel?>();
            SocCodes = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchParameters. </summary>
        /// <param name="indices"></param>
        /// <param name="resume"> A random string that uniquely identify the resource. </param>
        /// <param name="jobTitles"></param>
        /// <param name="jobTitlesRequired"></param>
        /// <param name="jobTitlesWeight"></param>
        /// <param name="totalYearsExperience"></param>
        /// <param name="yearsExperienceRequired"></param>
        /// <param name="yearsExperienceWeight"></param>
        /// <param name="locations"></param>
        /// <param name="locationsWeight"></param>
        /// <param name="locationsRequired"></param>
        /// <param name="skills"></param>
        /// <param name="skillsWeight"></param>
        /// <param name="languages"></param>
        /// <param name="languagesWeight"></param>
        /// <param name="degrees"></param>
        /// <param name="degreesRequired"></param>
        /// <param name="degreeTypes"></param>
        /// <param name="degreeTypesRequired"></param>
        /// <param name="educationWeight"></param>
        /// <param name="searchExpression"></param>
        /// <param name="searchExpressionRequired"></param>
        /// <param name="searchExpressionWeight"></param>
        /// <param name="socCodes"></param>
        /// <param name="socCodesWeight"></param>
        /// <param name="socCodesRequired"></param>
        /// <param name="managementLevel"></param>
        /// <param name="managementLevelRequired"></param>
        /// <param name="managementLevelWeight"></param>
        internal JobDescriptionSearchParameters(IList<string> indices, string resume, IList<string> jobTitles, bool? jobTitlesRequired, float? jobTitlesWeight, float? totalYearsExperience, bool? yearsExperienceRequired, float? yearsExperienceWeight, IList<ResumeSearchParametersLocation> locations, float? locationsWeight, bool? locationsRequired, IList<ResumeSearchParametersSkill> skills, float? skillsWeight, IList<ResumeSearchParametersSkill> languages, float? languagesWeight, IList<string> degrees, bool? degreesRequired, IList<EducationLevel?> degreeTypes, bool? degreeTypesRequired, float? educationWeight, string searchExpression, bool? searchExpressionRequired, float? searchExpressionWeight, IList<int> socCodes, float? socCodesWeight, bool? socCodesRequired, ManagementLevel? managementLevel, bool? managementLevelRequired, float? managementLevelWeight)
        {
            Indices = indices;
            Resume = resume;
            JobTitles = jobTitles;
            JobTitlesRequired = jobTitlesRequired;
            JobTitlesWeight = jobTitlesWeight;
            TotalYearsExperience = totalYearsExperience;
            YearsExperienceRequired = yearsExperienceRequired;
            YearsExperienceWeight = yearsExperienceWeight;
            Locations = locations;
            LocationsWeight = locationsWeight;
            LocationsRequired = locationsRequired;
            Skills = skills;
            SkillsWeight = skillsWeight;
            Languages = languages;
            LanguagesWeight = languagesWeight;
            Degrees = degrees;
            DegreesRequired = degreesRequired;
            DegreeTypes = degreeTypes;
            DegreeTypesRequired = degreeTypesRequired;
            EducationWeight = educationWeight;
            SearchExpression = searchExpression;
            SearchExpressionRequired = searchExpressionRequired;
            SearchExpressionWeight = searchExpressionWeight;
            SocCodes = socCodes;
            SocCodesWeight = socCodesWeight;
            SocCodesRequired = socCodesRequired;
            ManagementLevel = managementLevel;
            ManagementLevelRequired = managementLevelRequired;
            ManagementLevelWeight = managementLevelWeight;
        }

        /// <summary> Gets the indices. </summary>
        public IList<string> Indices { get; }
        /// <summary> A random string that uniquely identify the resource. </summary>
        public string Resume { get; set; }
        /// <summary> Gets the job titles. </summary>
        public IList<string> JobTitles { get; }
        /// <summary> Gets or sets the job titles required. </summary>
        public bool? JobTitlesRequired { get; set; }
        /// <summary> Gets or sets the job titles weight. </summary>
        public float? JobTitlesWeight { get; set; }
        /// <summary> Gets or sets the total years experience. </summary>
        public float? TotalYearsExperience { get; set; }
        /// <summary> Gets or sets the years experience required. </summary>
        public bool? YearsExperienceRequired { get; set; }
        /// <summary> Gets or sets the years experience weight. </summary>
        public float? YearsExperienceWeight { get; set; }
        /// <summary> Gets the locations. </summary>
        public IList<ResumeSearchParametersLocation> Locations { get; }
        /// <summary> Gets or sets the locations weight. </summary>
        public float? LocationsWeight { get; set; }
        /// <summary> Gets or sets the locations required. </summary>
        public bool? LocationsRequired { get; set; }
        /// <summary> Gets the skills. </summary>
        public IList<ResumeSearchParametersSkill> Skills { get; }
        /// <summary> Gets or sets the skills weight. </summary>
        public float? SkillsWeight { get; set; }
        /// <summary> Gets the languages. </summary>
        public IList<ResumeSearchParametersSkill> Languages { get; }
        /// <summary> Gets or sets the languages weight. </summary>
        public float? LanguagesWeight { get; set; }
        /// <summary> Gets the degrees. </summary>
        public IList<string> Degrees { get; }
        /// <summary> Gets or sets the degrees required. </summary>
        public bool? DegreesRequired { get; set; }
        /// <summary> Gets the degree types. </summary>
        public IList<EducationLevel?> DegreeTypes { get; }
        /// <summary> Gets or sets the degree types required. </summary>
        public bool? DegreeTypesRequired { get; set; }
        /// <summary> Gets or sets the education weight. </summary>
        public float? EducationWeight { get; set; }
        /// <summary> Gets or sets the search expression. </summary>
        public string SearchExpression { get; set; }
        /// <summary> Gets or sets the search expression required. </summary>
        public bool? SearchExpressionRequired { get; set; }
        /// <summary> Gets or sets the search expression weight. </summary>
        public float? SearchExpressionWeight { get; set; }
        /// <summary> Gets the soc codes. </summary>
        public IList<int> SocCodes { get; }
        /// <summary> Gets or sets the soc codes weight. </summary>
        public float? SocCodesWeight { get; set; }
        /// <summary> Gets or sets the soc codes required. </summary>
        public bool? SocCodesRequired { get; set; }
        /// <summary> Gets or sets the management level. </summary>
        public ManagementLevel? ManagementLevel { get; set; }
        /// <summary> Gets or sets the management level required. </summary>
        public bool? ManagementLevelRequired { get; set; }
        /// <summary> Gets or sets the management level weight. </summary>
        public float? ManagementLevelWeight { get; set; }
    }
}
