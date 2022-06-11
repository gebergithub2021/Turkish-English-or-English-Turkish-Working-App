using Englishworking.Core.RepositoryCore.Concrete;
using Englishworking.Data.Context;
using Englishworking.Data.Entity;
using Englishworking.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.DataAccess.Concrete
{
    public class EfTurkishDictionaryRepository:EfRepositoryBase<TurkishDictionary, EnglishworkingContext>, ITurkishDictionaryRepository
    {
    }
}
