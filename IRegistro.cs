using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    public interface IRegistro
    {
        void VerifyContent(string path);
        void SetContent(string path);
        
    }
}
