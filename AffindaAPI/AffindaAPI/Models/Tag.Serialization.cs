// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Tag : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteNumberValue(Id);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("workspace");
            writer.WriteStringValue(Workspace);
            writer.WritePropertyName("documentCount");
            writer.WriteNumberValue(DocumentCount);
            writer.WriteEndObject();
        }

        internal static Tag DeserializeTag(JsonElement element)
        {
            int id = default;
            string name = default;
            string workspace = default;
            int documentCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspace"))
                {
                    workspace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentCount"))
                {
                    documentCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new Tag(id, name, workspace, documentCount);
        }
    }
}