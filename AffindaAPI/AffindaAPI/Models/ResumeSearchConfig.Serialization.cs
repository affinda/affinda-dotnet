// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowPdfDownload))
            {
                writer.WritePropertyName("allowPdfDownload");
                writer.WriteBooleanValue(AllowPdfDownload.Value);
            }
            if (Optional.IsDefined(MaxResults))
            {
                if (MaxResults != null)
                {
                    writer.WritePropertyName("maxResults");
                    writer.WriteNumberValue(MaxResults.Value);
                }
                else
                {
                    writer.WriteNull("maxResults");
                }
            }
            if (Optional.IsDefined(DisplayJobTitle))
            {
                writer.WritePropertyName("displayJobTitle");
                writer.WriteBooleanValue(DisplayJobTitle.Value);
            }
            if (Optional.IsDefined(DisplayLocation))
            {
                writer.WritePropertyName("displayLocation");
                writer.WriteBooleanValue(DisplayLocation.Value);
            }
            if (Optional.IsDefined(DisplayYearsExperience))
            {
                writer.WritePropertyName("displayYearsExperience");
                writer.WriteBooleanValue(DisplayYearsExperience.Value);
            }
            if (Optional.IsDefined(DisplayOccupationGroup))
            {
                writer.WritePropertyName("displayOccupationGroup");
                writer.WriteBooleanValue(DisplayOccupationGroup.Value);
            }
            if (Optional.IsDefined(DisplayEducation))
            {
                writer.WritePropertyName("displayEducation");
                writer.WriteBooleanValue(DisplayEducation.Value);
            }
            if (Optional.IsDefined(DisplaySkills))
            {
                writer.WritePropertyName("displaySkills");
                writer.WriteBooleanValue(DisplaySkills.Value);
            }
            if (Optional.IsDefined(DisplayLanguages))
            {
                writer.WritePropertyName("displayLanguages");
                writer.WriteBooleanValue(DisplayLanguages.Value);
            }
            if (Optional.IsDefined(DisplayManagementLevel))
            {
                writer.WritePropertyName("displayManagementLevel");
                writer.WriteBooleanValue(DisplayManagementLevel.Value);
            }
            if (Optional.IsDefined(DisplayKeywords))
            {
                writer.WritePropertyName("displayKeywords");
                writer.WriteBooleanValue(DisplayKeywords.Value);
            }
            if (Optional.IsDefined(WeightJobTitle))
            {
                writer.WritePropertyName("weightJobTitle");
                writer.WriteNumberValue(WeightJobTitle.Value);
            }
            if (Optional.IsDefined(WeightLocation))
            {
                writer.WritePropertyName("weightLocation");
                writer.WriteNumberValue(WeightLocation.Value);
            }
            if (Optional.IsDefined(WeightYearsExperience))
            {
                writer.WritePropertyName("weightYearsExperience");
                writer.WriteNumberValue(WeightYearsExperience.Value);
            }
            if (Optional.IsDefined(WeightOccupationGroup))
            {
                writer.WritePropertyName("weightOccupationGroup");
                writer.WriteNumberValue(WeightOccupationGroup.Value);
            }
            if (Optional.IsDefined(WeightEducation))
            {
                writer.WritePropertyName("weightEducation");
                writer.WriteNumberValue(WeightEducation.Value);
            }
            if (Optional.IsDefined(WeightSkills))
            {
                writer.WritePropertyName("weightSkills");
                writer.WriteNumberValue(WeightSkills.Value);
            }
            if (Optional.IsDefined(WeightLanguages))
            {
                writer.WritePropertyName("weightLanguages");
                writer.WriteNumberValue(WeightLanguages.Value);
            }
            if (Optional.IsDefined(WeightManagementLevel))
            {
                writer.WritePropertyName("weightManagementLevel");
                writer.WriteNumberValue(WeightManagementLevel.Value);
            }
            if (Optional.IsDefined(WeightKeywords))
            {
                writer.WritePropertyName("weightKeywords");
                writer.WriteNumberValue(WeightKeywords.Value);
            }
            if (Optional.IsCollectionDefined(Indices))
            {
                writer.WritePropertyName("indices");
                writer.WriteStartArray();
                foreach (var item in Indices)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ShowIndexDropdown))
            {
                if (ShowIndexDropdown != null)
                {
                    writer.WritePropertyName("showIndexDropdown");
                    writer.WriteBooleanValue(ShowIndexDropdown.Value);
                }
                else
                {
                    writer.WriteNull("showIndexDropdown");
                }
            }
            if (Optional.IsCollectionDefined(SearchToolTheme))
            {
                if (SearchToolTheme != null)
                {
                    writer.WritePropertyName("searchToolTheme");
                    writer.WriteStartObject();
                    foreach (var item in SearchToolTheme)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("searchToolTheme");
                }
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                if (Actions != null)
                {
                    writer.WritePropertyName("actions");
                    writer.WriteStartArray();
                    foreach (var item in Actions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("actions");
                }
            }
            if (Optional.IsCollectionDefined(CustomFieldsConfig))
            {
                if (CustomFieldsConfig != null)
                {
                    writer.WritePropertyName("customFieldsConfig");
                    writer.WriteStartArray();
                    foreach (var item in CustomFieldsConfig)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("customFieldsConfig");
                }
            }
            if (Optional.IsDefined(DistanceUnit))
            {
                writer.WritePropertyName("distanceUnit");
                writer.WriteStringValue(DistanceUnit.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ResumeSearchConfig DeserializeResumeSearchConfig(JsonElement element)
        {
            Optional<bool> allowPdfDownload = default;
            Optional<int?> maxResults = default;
            Optional<bool> displayJobTitle = default;
            Optional<bool> displayLocation = default;
            Optional<bool> displayYearsExperience = default;
            Optional<bool> displayOccupationGroup = default;
            Optional<bool> displayEducation = default;
            Optional<bool> displaySkills = default;
            Optional<bool> displayLanguages = default;
            Optional<bool> displayManagementLevel = default;
            Optional<bool> displayKeywords = default;
            Optional<float> weightJobTitle = default;
            Optional<float> weightLocation = default;
            Optional<float> weightYearsExperience = default;
            Optional<float> weightOccupationGroup = default;
            Optional<float> weightEducation = default;
            Optional<float> weightSkills = default;
            Optional<float> weightLanguages = default;
            Optional<float> weightManagementLevel = default;
            Optional<float> weightKeywords = default;
            Optional<IList<string>> indices = default;
            Optional<bool?> showIndexDropdown = default;
            Optional<IDictionary<string, object>> searchToolTheme = default;
            Optional<int> userId = default;
            Optional<string> username = default;
            Optional<IList<ResumeSearchConfigActionsItem>> actions = default;
            Optional<IList<CustomFieldConfig>> customFieldsConfig = default;
            Optional<ResumeSearchConfigDistanceUnit> distanceUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowPdfDownload"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowPdfDownload = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxResults = null;
                        continue;
                    }
                    maxResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayJobTitle"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayJobTitle = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayLocation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayYearsExperience"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayYearsExperience = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayOccupationGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayOccupationGroup = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayEducation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayEducation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displaySkills"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displaySkills = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayLanguages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayLanguages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayManagementLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayManagementLevel = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayKeywords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayKeywords = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("weightJobTitle"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightJobTitle = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightLocation = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightYearsExperience"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightYearsExperience = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightOccupationGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightOccupationGroup = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightEducation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightEducation = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightSkills"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightSkills = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightLanguages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightLanguages = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightManagementLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightManagementLevel = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("weightKeywords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightKeywords = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("indices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    indices = array;
                    continue;
                }
                if (property.NameEquals("showIndexDropdown"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        showIndexDropdown = null;
                        continue;
                    }
                    showIndexDropdown = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("searchToolTheme"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchToolTheme = null;
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    searchToolTheme = dictionary;
                    continue;
                }
                if (property.NameEquals("userId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        actions = null;
                        continue;
                    }
                    List<ResumeSearchConfigActionsItem> array = new List<ResumeSearchConfigActionsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResumeSearchConfigActionsItem.DeserializeResumeSearchConfigActionsItem(item));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("customFieldsConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customFieldsConfig = null;
                        continue;
                    }
                    List<CustomFieldConfig> array = new List<CustomFieldConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomFieldConfig.DeserializeCustomFieldConfig(item));
                    }
                    customFieldsConfig = array;
                    continue;
                }
                if (property.NameEquals("distanceUnit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distanceUnit = new ResumeSearchConfigDistanceUnit(property.Value.GetString());
                    continue;
                }
            }
            return new ResumeSearchConfig(Optional.ToNullable(allowPdfDownload), Optional.ToNullable(maxResults), Optional.ToNullable(displayJobTitle), Optional.ToNullable(displayLocation), Optional.ToNullable(displayYearsExperience), Optional.ToNullable(displayOccupationGroup), Optional.ToNullable(displayEducation), Optional.ToNullable(displaySkills), Optional.ToNullable(displayLanguages), Optional.ToNullable(displayManagementLevel), Optional.ToNullable(displayKeywords), Optional.ToNullable(weightJobTitle), Optional.ToNullable(weightLocation), Optional.ToNullable(weightYearsExperience), Optional.ToNullable(weightOccupationGroup), Optional.ToNullable(weightEducation), Optional.ToNullable(weightSkills), Optional.ToNullable(weightLanguages), Optional.ToNullable(weightManagementLevel), Optional.ToNullable(weightKeywords), Optional.ToList(indices), Optional.ToNullable(showIndexDropdown), Optional.ToDictionary(searchToolTheme), Optional.ToNullable(userId), username.Value, Optional.ToList(actions), Optional.ToList(customFieldsConfig), Optional.ToNullable(distanceUnit));
        }
    }
}
