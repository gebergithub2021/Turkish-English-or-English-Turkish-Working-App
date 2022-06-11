using Englishworking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Services.Abstract
{
    public interface ICreateDictionary
    {
        void AddTurkishDictionary(TurkishDictionaryDto turkishWordModel);
        void AddEnglishDictionary(EnglishDictionaryDto englishWordModel);
        void AddCommonProps(CommonPropsDto commonProps);
    }
}
