// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
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
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static JobDescriptionDataUpdate DeserializeJobDescriptionDataUpdate(JsonElement element)
        {
            Optional<JobTitleAnnotationUpdate> jobTitle = default;
            Optional<TextAnnotationV2Update> contactEmail = default;
            Optional<TextAnnotationV2Update> contactName = default;
            Optional<TextAnnotationV2Update> contactPhone = default;
            Optional<DateAnnotationV2Update> startDate = default;
            Optional<DateAnnotationV2Update> endDate = default;
            Optional<TextAnnotationV2Update> jobType = default;
            Optional<IList<LanguageAnnotationV2Update>> languages = default;
            Optional<IList<SkillAnnotationV2Update>> skills = default;
            Optional<TextAnnotationV2Update> organizationName = default;
            Optional<TextAnnotationV2Update> organizationWebsite = default;
            Optional<TextAnnotationV2Update> educationLevel = default;
            Optional<TextAnnotationV2Update> educationAccreditation = default;
            Optional<ExpectedRemunerationAnnotationV2Update> expectedRemuneration = default;
            Optional<LocationAnnotationV2Update> location = default;
            Optional<IList<TextAnnotationV2Update>> certifications = default;
            Optional<YearsExperienceAnnotationV2Update> yearsExperience = default;
            IDictionary<string, Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties> additionalProperties = default;
            Dictionary<string, Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties> additionalPropertiesDictionary = new Dictionary<string, Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobTitle"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobTitle = null;
                        continue;
                    }
                    jobTitle = JobTitleAnnotationUpdate.DeserializeJobTitleAnnotationUpdate(property.Value);
                    continue;
                }
                if (property.NameEquals("contactEmail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contactEmail = null;
                        continue;
                    }
                    contactEmail = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("contactName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contactName = null;
                        continue;
                    }
                    contactName = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("contactPhone"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contactPhone = null;
                        continue;
                    }
                    contactPhone = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("startDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startDate = null;
                        continue;
                    }
                    startDate = DateAnnotationV2Update.DeserializeDateAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("endDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endDate = null;
                        continue;
                    }
                    endDate = DateAnnotationV2Update.DeserializeDateAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("jobType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobType = null;
                        continue;
                    }
                    jobType = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("languages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LanguageAnnotationV2Update> array = new List<LanguageAnnotationV2Update>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(LanguageAnnotationV2Update.DeserializeLanguageAnnotationV2Update(item));
                        }
                    }
                    languages = array;
                    continue;
                }
                if (property.NameEquals("skills"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SkillAnnotationV2Update> array = new List<SkillAnnotationV2Update>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SkillAnnotationV2Update.DeserializeSkillAnnotationV2Update(item));
                        }
                    }
                    skills = array;
                    continue;
                }
                if (property.NameEquals("organizationName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organizationName = null;
                        continue;
                    }
                    organizationName = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("organizationWebsite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organizationWebsite = null;
                        continue;
                    }
                    organizationWebsite = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("educationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        educationLevel = null;
                        continue;
                    }
                    educationLevel = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("educationAccreditation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        educationAccreditation = null;
                        continue;
                    }
                    educationAccreditation = TextAnnotationV2Update.DeserializeTextAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("expectedRemuneration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expectedRemuneration = null;
                        continue;
                    }
                    expectedRemuneration = ExpectedRemunerationAnnotationV2Update.DeserializeExpectedRemunerationAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        location = null;
                        continue;
                    }
                    location = LocationAnnotationV2Update.DeserializeLocationAnnotationV2Update(property.Value);
                    continue;
                }
                if (property.NameEquals("certifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TextAnnotationV2Update> array = new List<TextAnnotationV2Update>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TextAnnotationV2Update.DeserializeTextAnnotationV2Update(item));
                        }
                    }
                    certifications = array;
                    continue;
                }
                if (property.NameEquals("yearsExperience"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        yearsExperience = null;
                        continue;
                    }
                    yearsExperience = YearsExperienceAnnotationV2Update.DeserializeYearsExperienceAnnotationV2Update(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties.DeserializeComponents1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties(property.Value));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new JobDescriptionDataUpdate(jobTitle.Value, contactEmail.Value, contactName.Value, contactPhone.Value, startDate.Value, endDate.Value, jobType.Value, Optional.ToList(languages), Optional.ToList(skills), organizationName.Value, organizationWebsite.Value, educationLevel.Value, educationAccreditation.Value, expectedRemuneration.Value, location.Value, Optional.ToList(certifications), yearsExperience.Value, additionalProperties);
        }
    }
}