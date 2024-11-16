using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApplication
{
    public class TransparentPanel : Panel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do nothing to prevent background painting, making it transparent
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Optional: Add any custom drawing logic here, if needed
            base.OnPaint(e);
        }
    }
}
