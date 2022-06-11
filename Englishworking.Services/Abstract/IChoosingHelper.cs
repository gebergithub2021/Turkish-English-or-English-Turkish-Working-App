using Englishworking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Services.Abstract
{
    public interface IChoosingHelper
    {
        string TurkishChoosedWord();
        string EnglishChoosedWord();
    }
}
