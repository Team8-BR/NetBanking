using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class ModeOfTransaction
    {
        public ModeOfTransaction()
        {
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int ModeId { get; set; }
        public int Modes { get; set; }
        public string MaturityInstruction { get; set; }

        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
