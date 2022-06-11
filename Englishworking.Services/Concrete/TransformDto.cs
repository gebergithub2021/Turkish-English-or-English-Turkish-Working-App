using Englishworking.Data.Entity;
using Englishworking.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Services.Concrete
{
    public class TransformDto:ITransformDto
    {
        public TurkishDictionaryDto _turkishDictionaryTransform;
        public EnglishDictionaryDto _englishDictionaryDtoTransform;
        public CommonPropsDto _commonPropsDto;
        public TransformDto(TurkishDictionaryDto turkishDictionaryTransform, EnglishDictionaryDto englishDictionaryDtoTransform, CommonPropsDto commonPropsDto)
        {
            _turkishDictionaryTransform = turkishDictionaryTransform;
            _englishDictionaryDtoTransform = englishDictionaryDtoTransform;
            _commonPropsDto = commonPropsDto;
        }

        public TurkishDictionaryDto transformTurkishDto(string turkishWord, string description)
        {
            _turkishDictionaryTransform.TurkishWord = turkishWord.Trim().ToLower();
            _turkishDictionaryTransform.Description = description;
            return _turkishDictionaryTransform;
        }
        public EnglishDictionaryDto transformEnglishDto(string englishWord, string description)
        {
            _englishDictionaryDtoTransform.EnglishWord = englishWord.Trim().ToLower();
            _englishDictionaryDtoTransform.Description = description;
            return _englishDictionaryDtoTransform;
        }

        public CommonPropsDto commonPropsDto(int turId, int engId)
        {
            _commonPropsDto.EnglishId = engId;
            _commonPropsDto.TurkishId = turId;
            return _commonPropsDto;
        }
    }
}
