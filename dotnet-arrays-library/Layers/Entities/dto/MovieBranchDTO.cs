using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.Entities.dto
{
    public class MovieBranchDTO
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public Manager BranchManager { get; set; }
        public string BranchAddress { get; set; }
        public string BranchPhone { get; set; }
        public bool BranchActive { get; set; }

        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public CategoryMovie MovieCategory { get; set; }
        public int MovieYear { get; set; }
        public string MovieLanguage { get; set; }

        public int Quantity { get; set; }
    }
}
