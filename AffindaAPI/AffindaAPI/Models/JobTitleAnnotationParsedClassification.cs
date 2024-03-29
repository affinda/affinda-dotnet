// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobTitleAnnotationParsedClassification. </summary>
    public partial class JobTitleAnnotationParsedClassification
    {
        /// <summary> Initializes a new instance of JobTitleAnnotationParsedClassification. </summary>
        public JobTitleAnnotationParsedClassification()
        {
        }

        /// <summary> Initializes a new instance of JobTitleAnnotationParsedClassification. </summary>
        /// <param name="socCode"></param>
        /// <param name="title"></param>
        /// <param name="minorGroup"></param>
        /// <param name="subMajorGroup"></param>
        /// <param name="majorGroup"></param>
        /// <param name="minorGroupCode"> The 4 digit code representing the SOC2020 classification for this job title. </param>
        /// <param name="subMajorGroupCode"> The 4 digit code representing the SOC2020 classification for this job title. </param>
        /// <param name="majorGroupCode"> The 4 digit code representing the SOC2020 classification for this job title. </param>
        internal JobTitleAnnotationParsedClassification(float? socCode, string title, string minorGroup, string subMajorGroup, string majorGroup, int? minorGroupCode, int? subMajorGroupCode, int? majorGroupCode)
        {
            SocCode = socCode;
            Title = title;
            MinorGroup = minorGroup;
            SubMajorGroup = subMajorGroup;
            MajorGroup = majorGroup;
            MinorGroupCode = minorGroupCode;
            SubMajorGroupCode = subMajorGroupCode;
            MajorGroupCode = majorGroupCode;
        }

        /// <summary> Gets or sets the soc code. </summary>
        public float? SocCode { get; set; }
        /// <summary> Gets or sets the title. </summary>
        public string Title { get; set; }
        /// <summary> Gets or sets the minor group. </summary>
        public string MinorGroup { get; set; }
        /// <summary> Gets or sets the sub major group. </summary>
        public string SubMajorGroup { get; set; }
        /// <summary> Gets or sets the major group. </summary>
        public string MajorGroup { get; set; }
        /// <summary> The 4 digit code representing the SOC2020 classification for this job title. </summary>
        public int? MinorGroupCode { get; set; }
        /// <summary> The 4 digit code representing the SOC2020 classification for this job title. </summary>
        public int? SubMajorGroupCode { get; set; }
        /// <summary> The 4 digit code representing the SOC2020 classification for this job title. </summary>
        public int? MajorGroupCode { get; set; }
    }
}
