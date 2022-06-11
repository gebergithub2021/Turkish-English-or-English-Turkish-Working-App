using AutoMapper;
using Englishworking.Data.Entity;
using Englishworking.DataAccess.Abstract;
using Englishworking.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Services.Concrete
{
    
    public class TurkishEnglishService : ITurkishEnglishService
    {
        protected readonly ICommonPropsRepository _commonPropsRepository;
        protected readonly ITurkishDictionaryRepository _turkishDictionaryRepository;
        public TurkishEnglishService(ICommonPropsRepository commonPropsRepository, ITurkishDictionaryRepository turkishDictionaryRepository)
        {
            _commonPropsRepository = commonPropsRepository;
            _turkishDictionaryRepository = turkishDictionaryRepository;
        }

        public int GetIdByTurkishWord(string turkishDto)
        {
            int s = _turkishDictionaryRepository.GetByFilter(t => t.TurkishWord == turkishDto).
                Select(t => t.TurkishWordId).FirstOrDefault();
            return s;
        }

        public string GetTurkishEngishWord(string turkishWord)
        {
            var tWord = _commonPropsRepository.GetByFilter(t => t.TurkishDictionary.TurkishWord == turkishWord, "TurkishDictionary","EnglishDictionary").Select(t=>t.EnglishDictionary.EnglishWord).FirstOrDefault();
            return tWord;
        }
    }
}
