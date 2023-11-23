using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    
    public enum DocumentType
        {
            [Display(Name = "Invoice")]
            Invoice,
            [Display(Name = "EWay Bill")]
            EWayBill,
            [Display(Name = "Lorry Receipt")]
            LorryReceipt,
            [Display(Name = "Others")]
            Others,
            [Display(Name = "Photo")]
            Photo,
            [Display(Name = "Contract")]
            Contract,
            [Display(Name = "Test Report")]
            TestReport,
            [Display(Name = "Packing List")]
            PackingList,
            [Display(Name = "POD Copy")]
            POD,
            [Display(Name = "Debit Note")]
            DebitNote,
            [Display(Name = "Credit Note")]
            CreditNote
        }
}

