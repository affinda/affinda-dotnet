// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataFieldField
    {
        internal static DataFieldField DeserializeDataFieldField(JsonElement element)
        {
            string label = default;
            bool mandatory = default;
            bool showDropdown = default;
            float? autoValidationThreshold = default;
            IReadOnlyList<Field> enabledChildFields = default;
            IReadOnlyList<Field> disabledChildFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mandatory"))
                {
                    mandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("showDropdown"))
                {
                    showDropdown = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoValidationThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoValidationThreshold = null;
                        continue;
                    }
                    autoValidationThreshold = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("enabledChildFields"))
                {
                    List<Field> array = new List<Field>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Field.DeserializeField(item));
                    }
                    enabledChildFields = array;
                    continue;
                }
                if (property.NameEquals("disabledChildFields"))
                {
                    List<Field> array = new List<Field>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Field.DeserializeField(item));
                    }
                    disabledChildFields = array;
                    continue;
                }
            }
            return new DataFieldField(label, mandatory, showDropdown, autoValidationThreshold, enabledChildFields, disabledChildFields);
        }
    }
}
