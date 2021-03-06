// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionData. </summary>
    public partial class JobDescriptionData
    {
        /// <summary> Initializes a new instance of JobDescriptionData. </summary>
        internal JobDescriptionData()
        {
            Languages = new ChangeTrackingList<LanguageAnnotation>();
            Skills = new ChangeTrackingList<SkillAnnotation>();
            Certifications = new ChangeTrackingList<TextAnnotation>();
        }

        /// <summary> Initializes a new instance of JobDescriptionData. </summary>
        /// <param name="contactEmail"></param>
        /// <param name="contactName"></param>
        /// <param name="contactPhone"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="jobType"></param>
        /// <param name="languages"></param>
        /// <param name="skills"></param>
        /// <param name="organizationName"></param>
        /// <param name="organizationWebsite"></param>
        /// <param name="educationLevel"></param>
        /// <param name="educationAccreditation"></param>
        /// <param name="expectedRemuneration"></param>
        /// <param name="location"></param>
        /// <param name="certifications"></param>
        internal JobDescriptionData(TextAnnotation contactEmail, TextAnnotation contactName, TextAnnotation contactPhone, DateAnnotation startDate, DateAnnotation endDate, TextAnnotation jobType, IReadOnlyList<LanguageAnnotation> languages, IReadOnlyList<SkillAnnotation> skills, TextAnnotation organizationName, TextAnnotation organizationWebsite, TextAnnotation educationLevel, TextAnnotation educationAccreditation, ExpectedRemunerationAnnotation expectedRemuneration, LocationAnnotation location, IReadOnlyList<TextAnnotation> certifications)
        {
            ContactEmail = contactEmail;
            ContactName = contactName;
            ContactPhone = contactPhone;
            StartDate = startDate;
            EndDate = endDate;
            JobType = jobType;
            Languages = languages;
            Skills = skills;
            OrganizationName = organizationName;
            OrganizationWebsite = organizationWebsite;
            EducationLevel = educationLevel;
            EducationAccreditation = educationAccreditation;
            ExpectedRemuneration = expectedRemuneration;
            Location = location;
            Certifications = certifications;
        }

        /// <summary> Gets the contact email. </summary>
        public TextAnnotation ContactEmail { get; }
        /// <summary> Gets the contact name. </summary>
        public TextAnnotation ContactName { get; }
        /// <summary> Gets the contact phone. </summary>
        public TextAnnotation ContactPhone { get; }
        /// <summary> Gets the start date. </summary>
        public DateAnnotation StartDate { get; }
        /// <summary> Gets the end date. </summary>
        public DateAnnotation EndDate { get; }
        /// <summary> Gets the job type. </summary>
        public TextAnnotation JobType { get; }
        /// <summary> Gets the languages. </summary>
        public IReadOnlyList<LanguageAnnotation> Languages { get; }
        /// <summary> Gets the skills. </summary>
        public IReadOnlyList<SkillAnnotation> Skills { get; }
        /// <summary> Gets the organization name. </summary>
        public TextAnnotation OrganizationName { get; }
        /// <summary> Gets the organization website. </summary>
        public TextAnnotation OrganizationWebsite { get; }
        /// <summary> Gets the education level. </summary>
        public TextAnnotation EducationLevel { get; }
        /// <summary> Gets the education accreditation. </summary>
        public TextAnnotation EducationAccreditation { get; }
        /// <summary> Gets the expected remuneration. </summary>
        public ExpectedRemunerationAnnotation ExpectedRemuneration { get; }
        /// <summary> Gets the location. </summary>
        public LocationAnnotation Location { get; }
        /// <summary> Gets the certifications. </summary>
        public IReadOnlyList<TextAnnotation> Certifications { get; }
    }
}
