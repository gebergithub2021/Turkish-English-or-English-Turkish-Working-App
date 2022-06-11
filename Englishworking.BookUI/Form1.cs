using Englishworking.Services.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Englishworking.Services.Concrete;
using Englishworking.BookUI.Helper;
using Englishworking.Data.Entity;
using System.Threading;

namespace Englishworking.BookUI
{
    public partial class Form1 : Form
    {
        string sentenceTur = "";
        string sentenceEng = "";
        public IChoosingHelper _choosingHelper;
        public IEnglishTurkishService _englishTurkishService;
        public ITurkishEnglishService _turkishEnglishService;
        public ICreateDictionary _createDictionary;
        public ITransformDto _transformDto;
        
        //IChoosingHelper choosingHelper, ITurkishEnglishService turkishEnglishService, IEnglishTurkishService englishTurkishService, ICreateDictionary createDictionary, ITransformDto transformDto
        //_choosingHelper = choosingHelper;
        //    _turkishEnglishService = turkishEnglishService;
        //    _englishTurkishService = englishTurkishService;
        //    _createDictionary = createDictionary;
        //    _transformDto = transformDto;

        //Form1 e kesinlikle contructora parametre ekleyemiyoruz. Eklediğimiz anda IMapper exception atıyor.
        public Form1(IChoosingHelper choosingHelper, ITurkishEnglishService turkishEnglishService, IEnglishTurkishService englishTurkishService, ITransformDto transformDto, ICreateDictionary createDictionary)
        {
            InitializeComponent();
            _choosingHelper = choosingHelper;
            _turkishEnglishService = turkishEnglishService;
            _englishTurkishService = englishTurkishService;
            _transformDto = transformDto;
            _createDictionary = createDictionary;

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
           
            var word = _choosingHelper.TurkishChoosedWord();
            if (word!=null)
            {
                lbl_Card.Text = word.Trim().ToUpper();
                sentenceTur = word;
            }
            else
            {
                MessageBox.Show("Lütfen önce kelime ekleyiniz.");
            }
            
        }
        private string ReverseString(string word)
        {
           
            return _turkishEnglishService.GetTurkishEngishWord(word);
        }
        private string ReverseStringEng(string word)
        {
            return _englishTurkishService.GetEnglishTurkish(word);
        }

        private void btn_Reverser_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sentenceTur))
            {
                string reverseWord = ReverseString(sentenceTur);
                MessageBox.Show(reverseWord);
            }
            else MessageBox.Show("Önce BAŞLA VE İLERLE yapınız.");
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_getEnglishWord_Click(object sender, EventArgs e)
        {
            var word = _choosingHelper.EnglishChoosedWord();
            if (word!=null)
            {
                lbl_englishWord.Text = word.Trim().ToUpper();
                sentenceEng = word;
            }
            else
            {
                MessageBox.Show("please, firstly add to word");
            }

        }

        private void btn_getTurkishWord_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sentenceEng))
            {
                string reverseWord = ReverseStringEng(sentenceEng);
                MessageBox.Show(reverseWord);
            }
            else MessageBox.Show("firstly press START AND CONTINUE button");
        }
        private void TurkishSave(TurkishDictionaryDto turkishDictionaryDto)
        {
             _createDictionary.AddTurkishDictionary(turkishDictionaryDto);
        }
        private void EnglishSave(EnglishDictionaryDto englishDictionaryDto)
        {
             _createDictionary.AddEnglishDictionary(englishDictionaryDto);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = "";
            if (!String.IsNullOrEmpty(txt_turkishWord.Text.Trim()) && !String.IsNullOrEmpty(txt_turkishDescription.Text.Trim()) &&
                !String.IsNullOrEmpty(txt_englishWord.Text.Trim()) && !String.IsNullOrEmpty(txt_englishDescription.Text.Trim()))
            {
                var turkishDto = _transformDto.transformTurkishDto(txt_turkishWord.Text, txt_turkishDescription.Text);
                var englishDto = _transformDto.transformEnglishDto(txt_englishWord.Text, txt_englishDescription.Text);
                TurkishSave(turkishDto);
                EnglishSave(englishDto);
                //burada id'leri getirirken veri tabanından sıfır getiriyor. Çözüm bulunduğunda işin bitecek mustafa...
                int getTurkishWordId = _turkishEnglishService.GetIdByTurkishWord(turkishDto.TurkishWord);
                int getEnglishWordId = _englishTurkishService.GetIdByEnglishWord(englishDto.EnglishWord);
                var commonpropsDto = _transformDto.commonPropsDto(getTurkishWordId, getEnglishWordId);
                _createDictionary.AddCommonProps(commonpropsDto);
                message = string.Format("Sözlüğe eklemek istediğiniz Türkçesi {0} olan ve İngilizce karşılığı {1} olan kelime eklendi.", turkishDto.TurkishWord, englishDto.EnglishWord);
                MessageBox.Show(message);

                ClearTxt();
            }
            else if (String.IsNullOrEmpty(txt_turkishWord.Text.Trim()) || String.IsNullOrEmpty(txt_turkishDescription.Text.Trim()) ||
               String.IsNullOrEmpty(txt_englishWord.Text.Trim()) || !String.IsNullOrEmpty(txt_englishDescription.Text.Trim()))
            {
                MessageBox.Show("Hiçbir bilgi boş bırakılamaz. Lütfen tüm bilgileri doldurunuz.");
            }

        }
        private void ClearTxt()
        {
            txt_turkishWord.Text = "";
            txt_englishWord.Text = "";
            txt_turkishDescription.Text = "";
            txt_englishDescription.Text = "";
        }
    }
}
