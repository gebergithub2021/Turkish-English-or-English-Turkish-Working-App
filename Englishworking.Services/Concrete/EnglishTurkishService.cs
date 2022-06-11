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
    public class EnglishTurkishService : IEnglishTurkishService
    {
        protected readonly ICommonPropsRepository _commonPropsRepository;
        protected readonly IEnglishDictionaryRepository _englishDictionaryRepository;
        public EnglishTurkishService(ICommonPropsRepository commonPropsRepository, IEnglishDictionaryRepository englishDictionaryRepository)
        {
            _commonPropsRepository = commonPropsRepository;
            _englishDictionaryRepository = englishDictionaryRepository;
        }
        public string GetEnglishTurkish(string englishWord)
        {
            var eWord = _commonPropsRepository.GetByFilter(t => t.EnglishDictionary.EnglishWord == englishWord, "TurkishDictionary", "EnglishDictionary").Select(t=>t.TurkishDictionary.TurkishWord).FirstOrDefault();
            return eWord;
        }

        public int GetIdByEnglishWord(string englishDto)
        {
            return _englishDictionaryRepository.GetByFilter(t => t.EnglishWord == englishDto).Select(t => t.EnglishWordId).FirstOrDefault();
        }
    }
}
