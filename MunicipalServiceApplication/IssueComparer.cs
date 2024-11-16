using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    internal class IssueComparer : IComparer<IssueReport>
    {
        public int Compare(IssueReport x, IssueReport y)
        {
            // Compare by Location
            int locationComparison = string.Compare(x.Location, y.Location, StringComparison.OrdinalIgnoreCase);
            if (locationComparison != 0) return locationComparison;

            // Compare by Category
            int categoryComparison = string.Compare(x.Category, y.Category, StringComparison.OrdinalIgnoreCase);
            if (categoryComparison != 0) return categoryComparison;

            // Compare by Description
            return string.Compare(x.Description, y.Description, StringComparison.OrdinalIgnoreCase);
        }
    }
}
