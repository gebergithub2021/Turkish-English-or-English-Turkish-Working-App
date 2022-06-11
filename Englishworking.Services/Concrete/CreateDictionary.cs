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
    public class CreateDictionary : ICreateDictionary
    {
        protected readonly ICommonPropsRepository _commonPropsRepository;
        protected readonly ITurkishDictionaryRepository _turkishDictionaryRepository;
        protected readonly IEnglishDictionaryRepository _englishDictionaryRepository;
        public readonly IMapper _mapper;
        public CreateDictionary(ICommonPropsRepository commonPropsRepository, ITurkishDictionaryRepository turkishDictionaryRepository,
                                IEnglishDictionaryRepository englishDictionaryRepository, IMapper mapper)
        {
            _commonPropsRepository = commonPropsRepository;
            _turkishDictionaryRepository = turkishDictionaryRepository;
            _englishDictionaryRepository = englishDictionaryRepository;
            _mapper = mapper;
        }
        public void AddCommonProps(CommonPropsDto commonProps)
        {
            var commonEntity = _mapper.Map<CommonPropsDto, CommonProps>(commonProps);
            _commonPropsRepository.Insert(commonEntity);
        }

        public void AddEnglishDictionary(EnglishDictionaryDto englishWordModel)
        {
            var englishEntity = _mapper.Map<EnglishDictionaryDto, EnglishDictionary>(englishWordModel);
            _englishDictionaryRepository.Insert(englishEntity);
        }

        public void AddTurkishDictionary(TurkishDictionaryDto turkishWordModel)
        {
            var turkishEntity = _mapper.Map<TurkishDictionaryDto, TurkishDictionary>(turkishWordModel);
            _turkishDictionaryRepository.Insert(turkishEntity);
            
        }
    }
}
