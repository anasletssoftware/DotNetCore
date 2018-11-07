using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImadErp.Model
{
    public class Transactions
    {
        [Key]
        [Required]
        [StringLength(100)]
        public string TransactionType { get; set; }

        [Required]
        [StringLength(1024)]
        public string TransactionDetails { get; set; }



    }
}
