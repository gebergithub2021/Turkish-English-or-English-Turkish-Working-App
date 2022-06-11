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
    public class ChoosingHelper : IChoosingHelper
    {
        protected readonly ICommonPropsRepository _commonPropsRepository;
        public ChoosingHelper(ICommonPropsRepository commonPropsRepository)
        {
            _commonPropsRepository = commonPropsRepository;
        }
        int choosedNum = 0;
        public int RandomGeneration(int maxValue)
        {
            
            if (maxValue>20)
            {
                Random random = new Random();
                choosedNum = random.Next(1,maxValue);
            }else
            {
                choosedNum++;
                if (choosedNum>maxValue)
                {
                    choosedNum = 1;
                }
            }
            return choosedNum;
        }
        public string TurkishChoosedWord()
        {
            var current = _commonPropsRepository.GetAll();
            int dictionaryLength = current.Count();
            int choosedId = RandomGeneration(dictionaryLength);
            var choosedWord = _commonPropsRepository.GetByFilter(c => c.TurkishDictionary.TurkishWordId == choosedId,"TurkishDictionary","EnglishDictionary").Select(c=>c.TurkishDictionary.TurkishWord).FirstOrDefault();
            return choosedWord ;
        }

        public string EnglishChoosedWord()
        {
            var current = _commonPropsRepository.GetAll();
            int dictionaryLength = current.Count();
            int choosedId = RandomGeneration(dictionaryLength);
            string choosedWord = _commonPropsRepository.GetByFilter(c=>c.EnglishDictionary.EnglishWordId==choosedId, "TurkishDictionary", "EnglishDictionary").Select(c => c.EnglishDictionary.EnglishWord).FirstOrDefault();
            return choosedWord;
        }
    }
}
