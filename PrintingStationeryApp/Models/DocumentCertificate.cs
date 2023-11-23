using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public enum DocumentCertificate
    {
        [Display(Name = "PAN Card")]
        PAN,
        [Display(Name = "GST Certificate")]
        GST,
        [Display(Name = "Cheque Copy")]
        Cheque,
        [Display(Name = "TDS Declaration")]
        TDSDeclaration,
        [Display(Name = "Others")]
        Others,
        [Display(Name = "MSME Certificate")]
        MSMECertificate,
    }
}

