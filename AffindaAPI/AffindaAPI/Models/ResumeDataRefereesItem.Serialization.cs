// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeDataRefereesItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name");
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text");
                writer.WriteStringValue(Text);
            }
            if (Optional.IsDefined(Email))
            {
                if (Email != null)
                {
                    writer.WritePropertyName("email");
                    writer.WriteStringValue(Email);
                }
                else
                {
                    writer.WriteNull("email");
                }
            }
            if (Optional.IsDefined(Number))
            {
                if (Number != null)
                {
                    writer.WritePropertyName("number");
                    writer.WriteStringValue(Number);
                }
                else
                {
                    writer.WriteNull("number");
                }
            }
            writer.WriteEndObject();
        }

        internal static ResumeDataRefereesItem DeserializeResumeDataRefereesItem(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> text = default;
            Optional<string> email = default;
            Optional<string> number = default;
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
            }
            return new ResumeDataRefereesItem(name.Value, text.Value, email.Value, number.Value);
        }
    }
}
