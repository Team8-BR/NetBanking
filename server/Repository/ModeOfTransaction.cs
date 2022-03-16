using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace server.Repository
{
    public partial class ModeOfTransaction
    {
        public int ModeId { get; set; }
        public int Modes { get; set; }
        public string MaturityInstruction { get; set; }
    }
}
