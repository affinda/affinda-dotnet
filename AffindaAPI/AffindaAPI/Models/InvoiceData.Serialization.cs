// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class InvoiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tables))
            {
                writer.WritePropertyName("tables");
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesBeta))
            {
                writer.WritePropertyName("tablesBeta");
                writer.WriteStartArray();
                foreach (var item in TablesBeta)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InvoiceDate))
            {
                if (InvoiceDate != null)
                {
                    writer.WritePropertyName("invoiceDate");
                    writer.WriteObjectValue(InvoiceDate);
                }
                else
                {
                    writer.WriteNull("invoiceDate");
                }
            }
            if (Optional.IsDefined(InvoiceOrderDate))
            {
                if (InvoiceOrderDate != null)
                {
                    writer.WritePropertyName("invoiceOrderDate");
                    writer.WriteObjectValue(InvoiceOrderDate);
                }
                else
                {
                    writer.WriteNull("invoiceOrderDate");
                }
            }
            if (Optional.IsDefined(PaymentDateDue))
            {
                if (PaymentDateDue != null)
                {
                    writer.WritePropertyName("paymentDateDue");
                    writer.WriteObjectValue(PaymentDateDue);
                }
                else
                {
                    writer.WriteNull("paymentDateDue");
                }
            }
            if (Optional.IsDefined(PaymentAmountBase))
            {
                if (PaymentAmountBase != null)
                {
                    writer.WritePropertyName("paymentAmountBase");
                    writer.WriteObjectValue(PaymentAmountBase);
                }
                else
                {
                    writer.WriteNull("paymentAmountBase");
                }
            }
            if (Optional.IsDefined(PaymentAmountTax))
            {
                if (PaymentAmountTax != null)
                {
                    writer.WritePropertyName("paymentAmountTax");
                    writer.WriteObjectValue(PaymentAmountTax);
                }
                else
                {
                    writer.WriteNull("paymentAmountTax");
                }
            }
            if (Optional.IsDefined(PaymentAmountTotal))
            {
                if (PaymentAmountTotal != null)
                {
                    writer.WritePropertyName("paymentAmountTotal");
                    writer.WriteObjectValue(PaymentAmountTotal);
                }
                else
                {
                    writer.WriteNull("paymentAmountTotal");
                }
            }
            if (Optional.IsDefined(PaymentAmountPaid))
            {
                if (PaymentAmountPaid != null)
                {
                    writer.WritePropertyName("paymentAmountPaid");
                    writer.WriteObjectValue(PaymentAmountPaid);
                }
                else
                {
                    writer.WriteNull("paymentAmountPaid");
                }
            }
            if (Optional.IsDefined(PaymentAmountDue))
            {
                if (PaymentAmountDue != null)
                {
                    writer.WritePropertyName("paymentAmountDue");
                    writer.WriteObjectValue(PaymentAmountDue);
                }
                else
                {
                    writer.WriteNull("paymentAmountDue");
                }
            }
            if (Optional.IsDefined(InvoiceNumber))
            {
                if (InvoiceNumber != null)
                {
                    writer.WritePropertyName("invoiceNumber");
                    writer.WriteObjectValue(InvoiceNumber);
                }
                else
                {
                    writer.WriteNull("invoiceNumber");
                }
            }
            if (Optional.IsDefined(InvoicePurchaseOrderNumber))
            {
                if (InvoicePurchaseOrderNumber != null)
                {
                    writer.WritePropertyName("invoicePurchaseOrderNumber");
                    writer.WriteObjectValue(InvoicePurchaseOrderNumber);
                }
                else
                {
                    writer.WriteNull("invoicePurchaseOrderNumber");
                }
            }
            if (Optional.IsDefined(SupplierBusinessNumber))
            {
                if (SupplierBusinessNumber != null)
                {
                    writer.WritePropertyName("supplierBusinessNumber");
                    writer.WriteObjectValue(SupplierBusinessNumber);
                }
                else
                {
                    writer.WriteNull("supplierBusinessNumber");
                }
            }
            if (Optional.IsDefined(CustomerNumber))
            {
                if (CustomerNumber != null)
                {
                    writer.WritePropertyName("customerNumber");
                    writer.WriteObjectValue(CustomerNumber);
                }
                else
                {
                    writer.WriteNull("customerNumber");
                }
            }
            if (Optional.IsDefined(CustomerBusinessNumber))
            {
                if (CustomerBusinessNumber != null)
                {
                    writer.WritePropertyName("customerBusinessNumber");
                    writer.WriteObjectValue(CustomerBusinessNumber);
                }
                else
                {
                    writer.WriteNull("customerBusinessNumber");
                }
            }
            if (Optional.IsDefined(PaymentReference))
            {
                if (PaymentReference != null)
                {
                    writer.WritePropertyName("paymentReference");
                    writer.WriteObjectValue(PaymentReference);
                }
                else
                {
                    writer.WriteNull("paymentReference");
                }
            }
            if (Optional.IsDefined(BankAccountNumber))
            {
                if (BankAccountNumber != null)
                {
                    writer.WritePropertyName("bankAccountNumber");
                    writer.WriteObjectValue(BankAccountNumber);
                }
                else
                {
                    writer.WriteNull("bankAccountNumber");
                }
            }
            if (Optional.IsDefined(SupplierVat))
            {
                if (SupplierVat != null)
                {
                    writer.WritePropertyName("supplierVat");
                    writer.WriteObjectValue(SupplierVat);
                }
                else
                {
                    writer.WriteNull("supplierVat");
                }
            }
            if (Optional.IsDefined(CustomerVat))
            {
                if (CustomerVat != null)
                {
                    writer.WritePropertyName("customerVat");
                    writer.WriteObjectValue(CustomerVat);
                }
                else
                {
                    writer.WriteNull("customerVat");
                }
            }
            if (Optional.IsDefined(BpayBillerCode))
            {
                if (BpayBillerCode != null)
                {
                    writer.WritePropertyName("bpayBillerCode");
                    writer.WriteObjectValue(BpayBillerCode);
                }
                else
                {
                    writer.WriteNull("bpayBillerCode");
                }
            }
            if (Optional.IsDefined(BpayReference))
            {
                if (BpayReference != null)
                {
                    writer.WritePropertyName("bpayReference");
                    writer.WriteObjectValue(BpayReference);
                }
                else
                {
                    writer.WriteNull("bpayReference");
                }
            }
            if (Optional.IsDefined(BankSortCode))
            {
                if (BankSortCode != null)
                {
                    writer.WritePropertyName("bankSortCode");
                    writer.WriteObjectValue(BankSortCode);
                }
                else
                {
                    writer.WriteNull("bankSortCode");
                }
            }
            if (Optional.IsDefined(BankIban))
            {
                if (BankIban != null)
                {
                    writer.WritePropertyName("bankIban");
                    writer.WriteObjectValue(BankIban);
                }
                else
                {
                    writer.WriteNull("bankIban");
                }
            }
            if (Optional.IsDefined(BankSwift))
            {
                if (BankSwift != null)
                {
                    writer.WritePropertyName("bankSwift");
                    writer.WriteObjectValue(BankSwift);
                }
                else
                {
                    writer.WriteNull("bankSwift");
                }
            }
            if (Optional.IsDefined(BankBsb))
            {
                if (BankBsb != null)
                {
                    writer.WritePropertyName("bankBsb");
                    writer.WriteObjectValue(BankBsb);
                }
                else
                {
                    writer.WriteNull("bankBsb");
                }
            }
            if (Optional.IsDefined(CustomerContactName))
            {
                if (CustomerContactName != null)
                {
                    writer.WritePropertyName("customerContactName");
                    writer.WriteObjectValue(CustomerContactName);
                }
                else
                {
                    writer.WriteNull("customerContactName");
                }
            }
            if (Optional.IsDefined(CustomerCompanyName))
            {
                if (CustomerCompanyName != null)
                {
                    writer.WritePropertyName("customerCompanyName");
                    writer.WriteObjectValue(CustomerCompanyName);
                }
                else
                {
                    writer.WriteNull("customerCompanyName");
                }
            }
            if (Optional.IsDefined(SupplierCompanyName))
            {
                if (SupplierCompanyName != null)
                {
                    writer.WritePropertyName("supplierCompanyName");
                    writer.WriteObjectValue(SupplierCompanyName);
                }
                else
                {
                    writer.WriteNull("supplierCompanyName");
                }
            }
            if (Optional.IsDefined(CustomerBillingAddress))
            {
                if (CustomerBillingAddress != null)
                {
                    writer.WritePropertyName("customerBillingAddress");
                    writer.WriteObjectValue(CustomerBillingAddress);
                }
                else
                {
                    writer.WriteNull("customerBillingAddress");
                }
            }
            if (Optional.IsDefined(CustomerDeliveryAddress))
            {
                if (CustomerDeliveryAddress != null)
                {
                    writer.WritePropertyName("customerDeliveryAddress");
                    writer.WriteObjectValue(CustomerDeliveryAddress);
                }
                else
                {
                    writer.WriteNull("customerDeliveryAddress");
                }
            }
            if (Optional.IsDefined(SupplierAddress))
            {
                if (SupplierAddress != null)
                {
                    writer.WritePropertyName("supplierAddress");
                    writer.WriteObjectValue(SupplierAddress);
                }
                else
                {
                    writer.WriteNull("supplierAddress");
                }
            }
            if (Optional.IsDefined(CustomerPhoneNumber))
            {
                if (CustomerPhoneNumber != null)
                {
                    writer.WritePropertyName("customerPhoneNumber");
                    writer.WriteObjectValue(CustomerPhoneNumber);
                }
                else
                {
                    writer.WriteNull("customerPhoneNumber");
                }
            }
            if (Optional.IsDefined(SupplierPhoneNumber))
            {
                if (SupplierPhoneNumber != null)
                {
                    writer.WritePropertyName("supplierPhoneNumber");
                    writer.WriteObjectValue(SupplierPhoneNumber);
                }
                else
                {
                    writer.WriteNull("supplierPhoneNumber");
                }
            }
            if (Optional.IsDefined(SupplierFax))
            {
                if (SupplierFax != null)
                {
                    writer.WritePropertyName("supplierFax");
                    writer.WriteObjectValue(SupplierFax);
                }
                else
                {
                    writer.WriteNull("supplierFax");
                }
            }
            if (Optional.IsDefined(CustomerEmail))
            {
                if (CustomerEmail != null)
                {
                    writer.WritePropertyName("customerEmail");
                    writer.WriteObjectValue(CustomerEmail);
                }
                else
                {
                    writer.WriteNull("customerEmail");
                }
            }
            if (Optional.IsDefined(SupplierEmail))
            {
                if (SupplierEmail != null)
                {
                    writer.WritePropertyName("supplierEmail");
                    writer.WriteObjectValue(SupplierEmail);
                }
                else
                {
                    writer.WriteNull("supplierEmail");
                }
            }
            if (Optional.IsDefined(SupplierWebsite))
            {
                if (SupplierWebsite != null)
                {
                    writer.WritePropertyName("supplierWebsite");
                    writer.WriteObjectValue(SupplierWebsite);
                }
                else
                {
                    writer.WriteNull("supplierWebsite");
                }
            }
            if (Optional.IsDefined(CurrencyCode))
            {
                if (CurrencyCode != null)
                {
                    writer.WritePropertyName("currencyCode");
                    writer.WriteObjectValue(CurrencyCode);
                }
                else
                {
                    writer.WriteNull("currencyCode");
                }
            }
            if (Optional.IsCollectionDefined(CustomFields))
            {
                if (CustomFields != null)
                {
                    writer.WritePropertyName("customFields");
                    writer.WriteStartObject();
                    foreach (var item in CustomFields)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("customFields");
                }
            }
            if (Optional.IsDefined(RawText))
            {
                writer.WritePropertyName("rawText");
                writer.WriteStringValue(RawText);
            }
            writer.WriteEndObject();
        }

        internal static InvoiceData DeserializeInvoiceData(JsonElement element)
        {
            Optional<IList<TableAnnotation>> tables = default;
            Optional<IList<TableBetaAnnotation>> tablesBeta = default;
            Optional<DateAnnotation> invoiceDate = default;
            Optional<DateAnnotation> invoiceOrderDate = default;
            Optional<DateAnnotation> paymentDateDue = default;
            Optional<TextAnnotation> paymentAmountBase = default;
            Optional<TextAnnotation> paymentAmountTax = default;
            Optional<TextAnnotation> paymentAmountTotal = default;
            Optional<TextAnnotation> paymentAmountPaid = default;
            Optional<TextAnnotation> paymentAmountDue = default;
            Optional<TextAnnotation> invoiceNumber = default;
            Optional<TextAnnotation> invoicePurchaseOrderNumber = default;
            Optional<TextAnnotation> supplierBusinessNumber = default;
            Optional<TextAnnotation> customerNumber = default;
            Optional<TextAnnotation> customerBusinessNumber = default;
            Optional<TextAnnotation> paymentReference = default;
            Optional<TextAnnotation> bankAccountNumber = default;
            Optional<TextAnnotation> supplierVat = default;
            Optional<TextAnnotation> customerVat = default;
            Optional<TextAnnotation> bpayBillerCode = default;
            Optional<TextAnnotation> bpayReference = default;
            Optional<TextAnnotation> bankSortCode = default;
            Optional<TextAnnotation> bankIban = default;
            Optional<TextAnnotation> bankSwift = default;
            Optional<TextAnnotation> bankBsb = default;
            Optional<TextAnnotation> customerContactName = default;
            Optional<TextAnnotation> customerCompanyName = default;
            Optional<TextAnnotation> supplierCompanyName = default;
            Optional<LocationAnnotation> customerBillingAddress = default;
            Optional<LocationAnnotation> customerDeliveryAddress = default;
            Optional<LocationAnnotation> supplierAddress = default;
            Optional<TextAnnotation> customerPhoneNumber = default;
            Optional<TextAnnotation> supplierPhoneNumber = default;
            Optional<TextAnnotation> supplierFax = default;
            Optional<TextAnnotation> customerEmail = default;
            Optional<TextAnnotation> supplierEmail = default;
            Optional<TextAnnotation> supplierWebsite = default;
            Optional<CurrencyCodeAnnotation> currencyCode = default;
            Optional<IDictionary<string, object>> customFields = default;
            Optional<string> rawText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TableAnnotation> array = new List<TableAnnotation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TableAnnotation.DeserializeTableAnnotation(item));
                        }
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("tablesBeta"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TableBetaAnnotation> array = new List<TableBetaAnnotation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TableBetaAnnotation.DeserializeTableBetaAnnotation(item));
                        }
                    }
                    tablesBeta = array;
                    continue;
                }
                if (property.NameEquals("invoiceDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        invoiceDate = null;
                        continue;
                    }
                    invoiceDate = DateAnnotation.DeserializeDateAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("invoiceOrderDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        invoiceOrderDate = null;
                        continue;
                    }
                    invoiceOrderDate = DateAnnotation.DeserializeDateAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentDateDue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentDateDue = null;
                        continue;
                    }
                    paymentDateDue = DateAnnotation.DeserializeDateAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountBase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentAmountBase = null;
                        continue;
                    }
                    paymentAmountBase = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountTax"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentAmountTax = null;
                        continue;
                    }
                    paymentAmountTax = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentAmountTotal = null;
                        continue;
                    }
                    paymentAmountTotal = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountPaid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentAmountPaid = null;
                        continue;
                    }
                    paymentAmountPaid = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountDue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentAmountDue = null;
                        continue;
                    }
                    paymentAmountDue = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("invoiceNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        invoiceNumber = null;
                        continue;
                    }
                    invoiceNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("invoicePurchaseOrderNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        invoicePurchaseOrderNumber = null;
                        continue;
                    }
                    invoicePurchaseOrderNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierBusinessNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierBusinessNumber = null;
                        continue;
                    }
                    supplierBusinessNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerNumber = null;
                        continue;
                    }
                    customerNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerBusinessNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerBusinessNumber = null;
                        continue;
                    }
                    customerBusinessNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentReference = null;
                        continue;
                    }
                    paymentReference = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bankAccountNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bankAccountNumber = null;
                        continue;
                    }
                    bankAccountNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierVat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierVat = null;
                        continue;
                    }
                    supplierVat = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerVat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerVat = null;
                        continue;
                    }
                    customerVat = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bpayBillerCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bpayBillerCode = null;
                        continue;
                    }
                    bpayBillerCode = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bpayReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bpayReference = null;
                        continue;
                    }
                    bpayReference = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bankSortCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bankSortCode = null;
                        continue;
                    }
                    bankSortCode = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bankIban"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bankIban = null;
                        continue;
                    }
                    bankIban = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bankSwift"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bankSwift = null;
                        continue;
                    }
                    bankSwift = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("bankBsb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bankBsb = null;
                        continue;
                    }
                    bankBsb = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerContactName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerContactName = null;
                        continue;
                    }
                    customerContactName = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerCompanyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerCompanyName = null;
                        continue;
                    }
                    customerCompanyName = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierCompanyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierCompanyName = null;
                        continue;
                    }
                    supplierCompanyName = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerBillingAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerBillingAddress = null;
                        continue;
                    }
                    customerBillingAddress = LocationAnnotation.DeserializeLocationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerDeliveryAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerDeliveryAddress = null;
                        continue;
                    }
                    customerDeliveryAddress = LocationAnnotation.DeserializeLocationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierAddress = null;
                        continue;
                    }
                    supplierAddress = LocationAnnotation.DeserializeLocationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerPhoneNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerPhoneNumber = null;
                        continue;
                    }
                    customerPhoneNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierPhoneNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierPhoneNumber = null;
                        continue;
                    }
                    supplierPhoneNumber = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierFax"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierFax = null;
                        continue;
                    }
                    supplierFax = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerEmail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customerEmail = null;
                        continue;
                    }
                    customerEmail = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierEmail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierEmail = null;
                        continue;
                    }
                    supplierEmail = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierWebsite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supplierWebsite = null;
                        continue;
                    }
                    supplierWebsite = TextAnnotation.DeserializeTextAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("currencyCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        currencyCode = null;
                        continue;
                    }
                    currencyCode = CurrencyCodeAnnotation.DeserializeCurrencyCodeAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customFields = null;
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    customFields = dictionary;
                    continue;
                }
                if (property.NameEquals("rawText"))
                {
                    rawText = property.Value.GetString();
                    continue;
                }
            }
            return new InvoiceData(Optional.ToList(tables), Optional.ToList(tablesBeta), invoiceDate.Value, invoiceOrderDate.Value, paymentDateDue.Value, paymentAmountBase.Value, paymentAmountTax.Value, paymentAmountTotal.Value, paymentAmountPaid.Value, paymentAmountDue.Value, invoiceNumber.Value, invoicePurchaseOrderNumber.Value, supplierBusinessNumber.Value, customerNumber.Value, customerBusinessNumber.Value, paymentReference.Value, bankAccountNumber.Value, supplierVat.Value, customerVat.Value, bpayBillerCode.Value, bpayReference.Value, bankSortCode.Value, bankIban.Value, bankSwift.Value, bankBsb.Value, customerContactName.Value, customerCompanyName.Value, supplierCompanyName.Value, customerBillingAddress.Value, customerDeliveryAddress.Value, supplierAddress.Value, customerPhoneNumber.Value, supplierPhoneNumber.Value, supplierFax.Value, customerEmail.Value, supplierEmail.Value, supplierWebsite.Value, currencyCode.Value, Optional.ToDictionary(customFields), rawText.Value);
        }
    }
}
