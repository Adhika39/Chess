using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.View
{
    public interface ISpriteRenderer
    {
        void RenderAt(double x, double y);
    }
}
