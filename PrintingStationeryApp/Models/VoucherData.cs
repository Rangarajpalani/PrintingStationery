using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public class VoucherData
    {

        [Key]
        public int VoucherDataId { get; set; }
        public string VoucherDatas { get; set; }

    }
}
