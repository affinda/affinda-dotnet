// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The InvoiceData. </summary>
    public partial class InvoiceData
    {
        /// <summary> Initializes a new instance of InvoiceData. </summary>
        internal InvoiceData()
        {
        }

        /// <summary> Initializes a new instance of InvoiceData. </summary>
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
        /// <param name="supplierVAT"></param>
        /// <param name="customerVAT"></param>
        /// <param name="bpayBillerCode"></param>
        /// <param name="bpayReference"></param>
        /// <param name="bankSortCode"></param>
        /// <param name="bankIban"></param>
        /// <param name="bankSwift"></param>
        /// <param name="bankBSB"></param>
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
        internal InvoiceData(DateAnnotation invoiceDate, DateAnnotation invoiceOrderDate, DateAnnotation paymentDateDue, InvoiceDataPaymentAmountBase paymentAmountBase, InvoiceDataPaymentAmountTax paymentAmountTax, InvoiceDataPaymentAmountTotal paymentAmountTotal, InvoiceDataPaymentAmountPaid paymentAmountPaid, InvoiceDataPaymentAmountDue paymentAmountDue, InvoiceDataInvoiceNumber invoiceNumber, InvoiceDataInvoicePurchaseOrderNumber invoicePurchaseOrderNumber, InvoiceDataSupplierBusinessNumber supplierBusinessNumber, InvoiceDataCustomerNumber customerNumber, InvoiceDataCustomerBusinessNumber customerBusinessNumber, InvoiceDataPaymentReference paymentReference, InvoiceDataBankAccountNumber bankAccountNumber, InvoiceDataSupplierVAT supplierVAT, InvoiceDataCustomerVAT customerVAT, InvoiceDataBpayBillerCode bpayBillerCode, InvoiceDataBpayReference bpayReference, InvoiceDataBankSortCode bankSortCode, InvoiceDataBankIban bankIban, InvoiceDataBankSwift bankSwift, InvoiceDataBankBSB bankBSB, InvoiceDataCustomerContactName customerContactName, InvoiceDataCustomerCompanyName customerCompanyName, InvoiceDataSupplierCompanyName supplierCompanyName, LocationAnnotation customerBillingAddress, LocationAnnotation customerDeliveryAddress, LocationAnnotation supplierAddress, InvoiceDataCustomerPhoneNumber customerPhoneNumber, InvoiceDataSupplierPhoneNumber supplierPhoneNumber, InvoiceDataSupplierFax supplierFax, InvoiceDataCustomerEmail customerEmail, InvoiceDataSupplierEmail supplierEmail, InvoiceDataSupplierWebsite supplierWebsite)
        {
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
            SupplierVAT = supplierVAT;
            CustomerVAT = customerVAT;
            BpayBillerCode = bpayBillerCode;
            BpayReference = bpayReference;
            BankSortCode = bankSortCode;
            BankIban = bankIban;
            BankSwift = bankSwift;
            BankBSB = bankBSB;
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
        }

        /// <summary> Gets the invoice date. </summary>
        public DateAnnotation InvoiceDate { get; }
        /// <summary> Gets the invoice order date. </summary>
        public DateAnnotation InvoiceOrderDate { get; }
        /// <summary> Gets the payment date due. </summary>
        public DateAnnotation PaymentDateDue { get; }
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
        public InvoiceDataSupplierVAT SupplierVAT { get; }
        /// <summary> Gets the customer vat. </summary>
        public InvoiceDataCustomerVAT CustomerVAT { get; }
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
        public InvoiceDataBankBSB BankBSB { get; }
        /// <summary> Gets the customer contact name. </summary>
        public InvoiceDataCustomerContactName CustomerContactName { get; }
        /// <summary> Gets the customer company name. </summary>
        public InvoiceDataCustomerCompanyName CustomerCompanyName { get; }
        /// <summary> Gets the supplier company name. </summary>
        public InvoiceDataSupplierCompanyName SupplierCompanyName { get; }
        /// <summary> Gets the customer billing address. </summary>
        public LocationAnnotation CustomerBillingAddress { get; }
        /// <summary> Gets the customer delivery address. </summary>
        public LocationAnnotation CustomerDeliveryAddress { get; }
        /// <summary> Gets the supplier address. </summary>
        public LocationAnnotation SupplierAddress { get; }
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
    }
}
