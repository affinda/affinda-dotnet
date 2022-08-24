// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailSkills. </summary>
    public partial class JobDescriptionSearchDetailSkills
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailSkills. </summary>
        internal JobDescriptionSearchDetailSkills()
        {
            Missing = new ChangeTrackingList<ResumeSearchParametersSkill>();
            Value = new ChangeTrackingList<JobDescriptionSearchDetailSkillsValueItem>();
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailSkills. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal JobDescriptionSearchDetailSkills(IReadOnlyList<ResumeSearchParametersSkill> missing, IReadOnlyList<JobDescriptionSearchDetailSkillsValueItem> value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public IReadOnlyList<ResumeSearchParametersSkill> Missing { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<JobDescriptionSearchDetailSkillsValueItem> Value { get; }
    }
}
