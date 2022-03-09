using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCoreWebAPI.Models
{
    public partial class ColumnSize
    {
        public int Id { get; set; }
        public string NvarChar64 { get; set; }
        public string NvarChar256 { get; set; }
        public string NvarChar1024 { get; set; }
        public string NvarChar4000 { get; set; }
        public string NvarCharMax { get; set; }
        public string VarChar64 { get; set; }
        public string VarChar256 { get; set; }
        public string VarChar1024 { get; set; }
        public string VarChar8000 { get; set; }
        public string VarCharMax { get; set; }
    }
}
