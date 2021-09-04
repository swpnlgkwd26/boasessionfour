using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    // Store the information about pagination :  View have to display
    public class PagingInfo
    {
        // 11
        public int TotalItems { get; set; }

        // 2
        public int ItemsPerPage { get; set; }

        //1
        public int CurrentPage { get; set; }

        // 5
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
