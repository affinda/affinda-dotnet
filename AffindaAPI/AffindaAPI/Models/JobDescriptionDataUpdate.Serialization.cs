// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class JobDescriptionDataUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(JobTitle))
            {
                if (JobTitle != null)
                {
                    writer.WritePropertyName("jobTitle");
                    writer.WriteObjectValue(JobTitle);
                }
                else
                {
                    writer.WriteNull("jobTitle");
                }
            }
            if (Optional.IsDefined(ContactEmail))
            {
                if (ContactEmail != null)
                {
                    writer.WritePropertyName("contactEmail");
                    writer.WriteObjectValue(ContactEmail);
                }
                else
                {
                    writer.WriteNull("contactEmail");
                }
            }
            if (Optional.IsDefined(ContactName))
            {
                if (ContactName != null)
                {
                    writer.WritePropertyName("contactName");
                    writer.WriteObjectValue(ContactName);
                }
                else
                {
                    writer.WriteNull("contactName");
                }
            }
            if (Optional.IsDefined(ContactPhone))
            {
                if (ContactPhone != null)
                {
                    writer.WritePropertyName("contactPhone");
                    writer.WriteObjectValue(ContactPhone);
                }
                else
                {
                    writer.WriteNull("contactPhone");
                }
            }
            if (Optional.IsDefined(StartDate))
            {
                if (StartDate != null)
                {
                    writer.WritePropertyName("startDate");
                    writer.WriteObjectValue(StartDate);
                }
                else
                {
                    writer.WriteNull("startDate");
                }
            }
            if (Optional.IsDefined(EndDate))
            {
                if (EndDate != null)
                {
                    writer.WritePropertyName("endDate");
                    writer.WriteObjectValue(EndDate);
                }
                else
                {
                    writer.WriteNull("endDate");
                }
            }
            if (Optional.IsDefined(JobType))
            {
                if (JobType != null)
                {
                    writer.WritePropertyName("jobType");
                    writer.WriteObjectValue(JobType);
                }
                else
                {
                    writer.WriteNull("jobType");
                }
            }
            if (Optional.IsCollectionDefined(Languages))
            {
                writer.WritePropertyName("languages");
                writer.WriteStartArray();
                foreach (var item in Languages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Skills))
            {
                writer.WritePropertyName("skills");
                writer.WriteStartArray();
                foreach (var item in Skills)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OrganizationName))
            {
                if (OrganizationName != null)
                {
                    writer.WritePropertyName("organizationName");
                    writer.WriteObjectValue(OrganizationName);
                }
                else
                {
                    writer.WriteNull("organizationName");
                }
            }
            if (Optional.IsDefined(OrganizationWebsite))
            {
                if (OrganizationWebsite != null)
                {
                    writer.WritePropertyName("organizationWebsite");
                    writer.WriteObjectValue(OrganizationWebsite);
                }
                else
                {
                    writer.WriteNull("organizationWebsite");
                }
            }
            if (Optional.IsDefined(EducationLevel))
            {
                if (EducationLevel != null)
                {
                    writer.WritePropertyName("educationLevel");
                    writer.WriteObjectValue(EducationLevel);
                }
                else
                {
                    writer.WriteNull("educationLevel");
                }
            }
            if (Optional.IsDefined(EducationAccreditation))
            {
                if (EducationAccreditation != null)
                {
                    writer.WritePropertyName("educationAccreditation");
                    writer.WriteObjectValue(EducationAccreditation);
                }
                else
                {
                    writer.WriteNull("educationAccreditation");
                }
            }
            if (Optional.IsDefined(ExpectedRemuneration))
            {
                if (ExpectedRemuneration != null)
                {
                    writer.WritePropertyName("expectedRemuneration");
                    writer.WriteObjectValue(ExpectedRemuneration);
                }
                else
                {
                    writer.WriteNull("expectedRemuneration");
                }
            }
            if (Optional.IsDefined(Location))
            {
                if (Location != null)
                {
                    writer.WritePropertyName("location");
                    writer.WriteObjectValue(Location);
                }
                else
                {
                    writer.WriteNull("location");
                }
            }
            if (Optional.IsCollectionDefined(Certifications))
            {
                writer.WritePropertyName("certifications");
                writer.WriteStartArray();
                foreach (var item in Certifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(YearsExperience))
            {
                if (YearsExperience != null)
                {
                    writer.WritePropertyName("yearsExperience");
                    writer.WriteObjectValue(YearsExperience);
                }
                else
                {
                    writer.WriteNull("yearsExperience");
                }
            }
            writer.WriteEndObject();
        }
    }
}
