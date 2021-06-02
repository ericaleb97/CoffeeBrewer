using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredCoffeeBrewer
{
    public interface IMessage
    {
        bool BeginBrewing();
        bool EndBrewing();
        bool StopBrewing();
        DateTime brewDate { get; set; }
    }
}
