// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class PhoneNumberAnnotationParsed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RawText))
            {
                writer.WritePropertyName("rawText");
                writer.WriteStringValue(RawText);
            }
            if (Optional.IsDefined(FormattedNumber))
            {
                if (FormattedNumber != null)
                {
                    writer.WritePropertyName("formattedNumber");
                    writer.WriteStringValue(FormattedNumber);
                }
                else
                {
                    writer.WriteNull("formattedNumber");
                }
            }
            if (Optional.IsDefined(CountryCode))
            {
                if (CountryCode != null)
                {
                    writer.WritePropertyName("countryCode");
                    writer.WriteStringValue(CountryCode);
                }
                else
                {
                    writer.WriteNull("countryCode");
                }
            }
            if (Optional.IsDefined(InternationalCountryCode))
            {
                if (InternationalCountryCode != null)
                {
                    writer.WritePropertyName("internationalCountryCode");
                    writer.WriteNumberValue(InternationalCountryCode.Value);
                }
                else
                {
                    writer.WriteNull("internationalCountryCode");
                }
            }
            if (Optional.IsDefined(NationalNumber))
            {
                if (NationalNumber != null)
                {
                    writer.WritePropertyName("nationalNumber");
                    writer.WriteStringValue(NationalNumber);
                }
                else
                {
                    writer.WriteNull("nationalNumber");
                }
            }
            writer.WriteEndObject();
        }

        internal static PhoneNumberAnnotationParsed DeserializePhoneNumberAnnotationParsed(JsonElement element)
        {
            Optional<string> rawText = default;
            Optional<string> formattedNumber = default;
            Optional<string> countryCode = default;
            Optional<int?> internationalCountryCode = default;
            Optional<string> nationalNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawText"))
                {
                    rawText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("formattedNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        formattedNumber = null;
                        continue;
                    }
                    formattedNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        countryCode = null;
                        continue;
                    }
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internationalCountryCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        internationalCountryCode = null;
                        continue;
                    }
                    internationalCountryCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nationalNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nationalNumber = null;
                        continue;
                    }
                    nationalNumber = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneNumberAnnotationParsed(rawText.Value, formattedNumber.Value, countryCode.Value, Optional.ToNullable(internationalCountryCode), nationalNumber.Value);
        }
    }
}
