// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceData. </summary>
    public partial class InvoiceData
    {
        /// <summary> Initializes a new instance of InvoiceData. </summary>
        internal InvoiceData()
        {
            Tables = new ChangeTrackingList<InvoiceDataTablesItem>();
            CustomFields = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of InvoiceData. </summary>
        /// <param name="tables"></param>
        /// <param name="invoiceDate"></param>
        /// <param name="invoiceOrderDate"></param>
        /// <param name="paymentDateDue"></param>
        /// <param name="paymentAmountBase"></param>
        /// <param name="paymentAmountTax"></param>
        /// <param name="paymentAmountTotal"></param>
        /// <param name="paymentAmountPaid"></param>
        /// <param name="paymentAmountDue"></param>
        /// <param name="invoiceNumber"></param>
        /// <param name="invoicePurchaseOrderNumber"></param>
        /// <param name="supplierBusinessNumber"></param>
        /// <param name="customerNumber"></param>
        /// <param name="customerBusinessNumber"></param>
        /// <param name="paymentReference"></param>
        /// <param name="bankAccountNumber"></param>
        /// <param name="supplierVat"></param>
        /// <param name="customerVat"></param>
        /// <param name="bpayBillerCode"></param>
        /// <param name="bpayReference"></param>
        /// <param name="bankSortCode"></param>
        /// <param name="bankIban"></param>
        /// <param name="bankSwift"></param>
        /// <param name="bankBsb"></param>
        /// <param name="customerContactName"></param>
        /// <param name="customerCompanyName"></param>
        /// <param name="supplierCompanyName"></param>
        /// <param name="customerBillingAddress"></param>
        /// <param name="customerDeliveryAddress"></param>
        /// <param name="supplierAddress"></param>
        /// <param name="customerPhoneNumber"></param>
        /// <param name="supplierPhoneNumber"></param>
        /// <param name="supplierFax"></param>
        /// <param name="customerEmail"></param>
        /// <param name="supplierEmail"></param>
        /// <param name="supplierWebsite"></param>
        /// <param name="currencyCode"></param>
        /// <param name="customFields"> Dictionary of &lt;any&gt;. </param>
        internal InvoiceData(IReadOnlyList<InvoiceDataTablesItem> tables, DateAnnotationV2 invoiceDate, DateAnnotationV2 invoiceOrderDate, DateAnnotationV2 paymentDateDue, InvoiceDataPaymentAmountBase paymentAmountBase, InvoiceDataPaymentAmountTax paymentAmountTax, InvoiceDataPaymentAmountTotal paymentAmountTotal, InvoiceDataPaymentAmountPaid paymentAmountPaid, InvoiceDataPaymentAmountDue paymentAmountDue, InvoiceDataInvoiceNumber invoiceNumber, InvoiceDataInvoicePurchaseOrderNumber invoicePurchaseOrderNumber, InvoiceDataSupplierBusinessNumber supplierBusinessNumber, InvoiceDataCustomerNumber customerNumber, InvoiceDataCustomerBusinessNumber customerBusinessNumber, InvoiceDataPaymentReference paymentReference, InvoiceDataBankAccountNumber bankAccountNumber, InvoiceDataSupplierVat supplierVat, InvoiceDataCustomerVat customerVat, InvoiceDataBpayBillerCode bpayBillerCode, InvoiceDataBpayReference bpayReference, InvoiceDataBankSortCode bankSortCode, InvoiceDataBankIban bankIban, InvoiceDataBankSwift bankSwift, InvoiceDataBankBsb bankBsb, InvoiceDataCustomerContactName customerContactName, InvoiceDataCustomerCompanyName customerCompanyName, InvoiceDataSupplierCompanyName supplierCompanyName, LocationAnnotationV2 customerBillingAddress, LocationAnnotationV2 customerDeliveryAddress, LocationAnnotationV2 supplierAddress, InvoiceDataCustomerPhoneNumber customerPhoneNumber, InvoiceDataSupplierPhoneNumber supplierPhoneNumber, InvoiceDataSupplierFax supplierFax, InvoiceDataCustomerEmail customerEmail, InvoiceDataSupplierEmail supplierEmail, InvoiceDataSupplierWebsite supplierWebsite, EnumAnnotationSerializerV2 currencyCode, IReadOnlyDictionary<string, object> customFields)
        {
            Tables = tables;
            InvoiceDate = invoiceDate;
            InvoiceOrderDate = invoiceOrderDate;
            PaymentDateDue = paymentDateDue;
            PaymentAmountBase = paymentAmountBase;
            PaymentAmountTax = paymentAmountTax;
            PaymentAmountTotal = paymentAmountTotal;
            PaymentAmountPaid = paymentAmountPaid;
            PaymentAmountDue = paymentAmountDue;
            InvoiceNumber = invoiceNumber;
            InvoicePurchaseOrderNumber = invoicePurchaseOrderNumber;
            SupplierBusinessNumber = supplierBusinessNumber;
            CustomerNumber = customerNumber;
            CustomerBusinessNumber = customerBusinessNumber;
            PaymentReference = paymentReference;
            BankAccountNumber = bankAccountNumber;
            SupplierVat = supplierVat;
            CustomerVat = customerVat;
            BpayBillerCode = bpayBillerCode;
            BpayReference = bpayReference;
            BankSortCode = bankSortCode;
            BankIban = bankIban;
            BankSwift = bankSwift;
            BankBsb = bankBsb;
            CustomerContactName = customerContactName;
            CustomerCompanyName = customerCompanyName;
            SupplierCompanyName = supplierCompanyName;
            CustomerBillingAddress = customerBillingAddress;
            CustomerDeliveryAddress = customerDeliveryAddress;
            SupplierAddress = supplierAddress;
            CustomerPhoneNumber = customerPhoneNumber;
            SupplierPhoneNumber = supplierPhoneNumber;
            SupplierFax = supplierFax;
            CustomerEmail = customerEmail;
            SupplierEmail = supplierEmail;
            SupplierWebsite = supplierWebsite;
            CurrencyCode = currencyCode;
            CustomFields = customFields;
        }

        /// <summary> Gets the tables. </summary>
        public IReadOnlyList<InvoiceDataTablesItem> Tables { get; }
        /// <summary> Gets the invoice date. </summary>
        public DateAnnotationV2 InvoiceDate { get; }
        /// <summary> Gets the invoice order date. </summary>
        public DateAnnotationV2 InvoiceOrderDate { get; }
        /// <summary> Gets the payment date due. </summary>
        public DateAnnotationV2 PaymentDateDue { get; }
        /// <summary> Gets the payment amount base. </summary>
        public InvoiceDataPaymentAmountBase PaymentAmountBase { get; }
        /// <summary> Gets the payment amount tax. </summary>
        public InvoiceDataPaymentAmountTax PaymentAmountTax { get; }
        /// <summary> Gets the payment amount total. </summary>
        public InvoiceDataPaymentAmountTotal PaymentAmountTotal { get; }
        /// <summary> Gets the payment amount paid. </summary>
        public InvoiceDataPaymentAmountPaid PaymentAmountPaid { get; }
        /// <summary> Gets the payment amount due. </summary>
        public InvoiceDataPaymentAmountDue PaymentAmountDue { get; }
        /// <summary> Gets the invoice number. </summary>
        public InvoiceDataInvoiceNumber InvoiceNumber { get; }
        /// <summary> Gets the invoice purchase order number. </summary>
        public InvoiceDataInvoicePurchaseOrderNumber InvoicePurchaseOrderNumber { get; }
        /// <summary> Gets the supplier business number. </summary>
        public InvoiceDataSupplierBusinessNumber SupplierBusinessNumber { get; }
        /// <summary> Gets the customer number. </summary>
        public InvoiceDataCustomerNumber CustomerNumber { get; }
        /// <summary> Gets the customer business number. </summary>
        public InvoiceDataCustomerBusinessNumber CustomerBusinessNumber { get; }
        /// <summary> Gets the payment reference. </summary>
        public InvoiceDataPaymentReference PaymentReference { get; }
        /// <summary> Gets the bank account number. </summary>
        public InvoiceDataBankAccountNumber BankAccountNumber { get; }
        /// <summary> Gets the supplier vat. </summary>
        public InvoiceDataSupplierVat SupplierVat { get; }
        /// <summary> Gets the customer vat. </summary>
        public InvoiceDataCustomerVat CustomerVat { get; }
        /// <summary> Gets the bpay biller code. </summary>
        public InvoiceDataBpayBillerCode BpayBillerCode { get; }
        /// <summary> Gets the bpay reference. </summary>
        public InvoiceDataBpayReference BpayReference { get; }
        /// <summary> Gets the bank sort code. </summary>
        public InvoiceDataBankSortCode BankSortCode { get; }
        /// <summary> Gets the bank iban. </summary>
        public InvoiceDataBankIban BankIban { get; }
        /// <summary> Gets the bank swift. </summary>
        public InvoiceDataBankSwift BankSwift { get; }
        /// <summary> Gets the bank bsb. </summary>
        public InvoiceDataBankBsb BankBsb { get; }
        /// <summary> Gets the customer contact name. </summary>
        public InvoiceDataCustomerContactName CustomerContactName { get; }
        /// <summary> Gets the customer company name. </summary>
        public InvoiceDataCustomerCompanyName CustomerCompanyName { get; }
        /// <summary> Gets the supplier company name. </summary>
        public InvoiceDataSupplierCompanyName SupplierCompanyName { get; }
        /// <summary> Gets the customer billing address. </summary>
        public LocationAnnotationV2 CustomerBillingAddress { get; }
        /// <summary> Gets the customer delivery address. </summary>
        public LocationAnnotationV2 CustomerDeliveryAddress { get; }
        /// <summary> Gets the supplier address. </summary>
        public LocationAnnotationV2 SupplierAddress { get; }
        /// <summary> Gets the customer phone number. </summary>
        public InvoiceDataCustomerPhoneNumber CustomerPhoneNumber { get; }
        /// <summary> Gets the supplier phone number. </summary>
        public InvoiceDataSupplierPhoneNumber SupplierPhoneNumber { get; }
        /// <summary> Gets the supplier fax. </summary>
        public InvoiceDataSupplierFax SupplierFax { get; }
        /// <summary> Gets the customer email. </summary>
        public InvoiceDataCustomerEmail CustomerEmail { get; }
        /// <summary> Gets the supplier email. </summary>
        public InvoiceDataSupplierEmail SupplierEmail { get; }
        /// <summary> Gets the supplier website. </summary>
        public InvoiceDataSupplierWebsite SupplierWebsite { get; }
        /// <summary> Gets the currency code. </summary>
        public EnumAnnotationSerializerV2 CurrencyCode { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> CustomFields { get; }
    }
}
