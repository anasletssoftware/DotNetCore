using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImadErp.Model
{
   public class TransactionDetails
    {
       
        [Key]
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnOldValue { get; set; }
        public string ColumnNewValue { get; set; }
        public Transactions Transactions { get; set; }
    }
}
