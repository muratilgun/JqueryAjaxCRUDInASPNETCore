using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JqueryAjaxCRUDInASPNETCore.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        public string AccountNumber { get; set; }
        [DisplayName("Beneficiary Name")]

        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [DisplayName("Bank Name")]

        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }
        [DisplayName("SWIFT Code")]

        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
