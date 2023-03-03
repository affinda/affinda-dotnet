// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeDataRefereesItem
    {
        internal static ResumeDataRefereesItem DeserializeResumeDataRefereesItem(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> text = default;
            Optional<string> email = default;
            Optional<string> number = default;
            Optional<string> position = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        email = null;
                        continue;
                    }
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("number"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        number = null;
                        continue;
                    }
                    number = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("position"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        position = null;
                        continue;
                    }
                    position = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ResumeDataRefereesItem(name.Value, text.Value, email.Value, number.Value, position.Value, additionalProperties);
        }
    }
}
