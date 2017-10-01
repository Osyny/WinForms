using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    enum TextId
    {
        // FORM NEW USER NAME
        NEW_USER_TITLE,
        NEW_USER_NAME_LABEL,
        NEW_USER_OK_BTN,

        // Form Game menu
        SAPER_TITLE,
        FILE,
        NEW_GAME,
        SETINGS,
        EXIT,

        DIF_LAVAL_GAME,
        LANG_MENU,

        LEVEL_1, 
        LEVEL_2,
        LEVEL_3,

        ENGLISH,
        UA,
        RU,

        CHAMPIONS,

        //Form Game Over
        YOU_WIN,
        TIME_GAME,
        DIFIC_LEVEL_WIN,
        NAME_WIN_USER,

        //Form champions
        TITLE_CHAMPIONS,
        NAME,
        LEVEL,
        TIME
    }

    enum LanguageId
    {
        ENG,
        UA,
        RU
    }

    class Translations
    {
        //Static
        static public Translations getInstance()
        {
            if (instance == null)
                instance = new Translations();
            return instance;
        }

        static private Translations instance;

        private Dictionary<TextId, Dictionary<LanguageId, string>> translations;

        public Translations()
        {
            //*****************    FORM NEW USER NAME  *******************************
            translations = new Dictionary<TextId, Dictionary<LanguageId, string>>();

            Dictionary<LanguageId, string> tmp = new Dictionary<LanguageId, string>();

            //NEW_USER_TITLE            
            tmp[LanguageId.ENG] = "New User";
            tmp[LanguageId.UA] = "Новий користувач";
            tmp[LanguageId.RU] = "Новый пользователь";
            translations[TextId.NEW_USER_TITLE] = new Dictionary<LanguageId, string>(tmp);

            //NEW_USER_NAME_LABEL            
            tmp[LanguageId.ENG] = "User name:";
            tmp[LanguageId.UA] = "Ім'я користувача:";
            tmp[LanguageId.RU] = "Имя пользователя:";
            translations[TextId.NEW_USER_NAME_LABEL] = new Dictionary<LanguageId, string>(tmp);

            //NEW_USER_OK_BTN            
            tmp[LanguageId.ENG] = "Start game";
            tmp[LanguageId.UA] = "Почати гру";
            tmp[LanguageId.RU] = "Начать игру";
            translations[TextId.NEW_USER_OK_BTN] = new Dictionary<LanguageId, string>(tmp);

            //*****************    FORM MENU   *******************************
            //TITLE
            tmp[LanguageId.ENG] = "Saper";
            tmp[LanguageId.UA] = "Сапер";
            tmp[LanguageId.RU] = "Сапер";
            translations[TextId.SAPER_TITLE] = new Dictionary<LanguageId, string>(tmp);

            //FILE
            tmp[LanguageId.ENG] = "File:";
            tmp[LanguageId.UA] = "Файл:";
            tmp[LanguageId.RU] = "Файл:";
            translations[TextId.FILE] = new Dictionary<LanguageId, string>(tmp);

            //NEW_GAME
            tmp[LanguageId.ENG] = "New game";
            tmp[LanguageId.UA] = "Нова гра";
            tmp[LanguageId.RU] = "Новая игра";
            translations[TextId.NEW_GAME] = new Dictionary<LanguageId, string>(tmp);

            //SETINGS
            tmp[LanguageId.ENG] = "Setings:";
            tmp[LanguageId.UA] = "Настройки:";
            tmp[LanguageId.RU] = "Настройки:";
            translations[TextId.SETINGS] = new Dictionary<LanguageId, string>(tmp);

            //Exit
            tmp[LanguageId.ENG] = "Exit";
            tmp[LanguageId.UA] = "Вихід";
            tmp[LanguageId.RU] = "Выход";
            translations[TextId.EXIT] = new Dictionary<LanguageId, string>(tmp);

            //Dific_level
            tmp[LanguageId.ENG] = "Difficulty lavel:";
            tmp[LanguageId.UA] = "Рівень складності:";
            tmp[LanguageId.RU] = "Уровень сложности:";
            translations[TextId.DIF_LAVAL_GAME] = new Dictionary<LanguageId, string>(tmp);

            //Language menu
            tmp[LanguageId.ENG] = "Language menu:";
            tmp[LanguageId.UA] = "Мова меню:";
            tmp[LanguageId.RU] = "Мова меню:";
            translations[TextId.LANG_MENU] = new Dictionary<LanguageId, string>(tmp);

            //Language
            tmp[LanguageId.ENG] = "English";
            tmp[LanguageId.UA] = "Англійська";
            tmp[LanguageId.RU] = "Английський";
            translations[TextId.ENGLISH] = new Dictionary<LanguageId, string>(tmp);
            //Language menu
            tmp[LanguageId.ENG] = "Ukrainian";
            tmp[LanguageId.UA] = "Українська";
            tmp[LanguageId.RU] = "Украинский";
            translations[TextId.UA] = new Dictionary<LanguageId, string>(tmp);
            //
            tmp[LanguageId.ENG] = "Russian";
            tmp[LanguageId.UA] = "Російська";
            tmp[LanguageId.RU] = "Русский";
            translations[TextId.RU] = new Dictionary<LanguageId, string>(tmp);

            //Level
            tmp[LanguageId.ENG] = "Level 1";
            tmp[LanguageId.UA] = "Рівень 1";
            tmp[LanguageId.RU] = "Уровень 1";
            translations[TextId.LEVEL_1] = new Dictionary<LanguageId, string>(tmp);
            //Level
            tmp[LanguageId.ENG] = "Level 2";
            tmp[LanguageId.UA] = "Рівень 2";
            tmp[LanguageId.RU] = "Уровень 2";
            translations[TextId.LEVEL_2] = new Dictionary<LanguageId, string>(tmp);
            //Level
            tmp[LanguageId.ENG] = "Level 3";
            tmp[LanguageId.UA] = "Рівень 3";
            tmp[LanguageId.RU] = "Уровень 3";
            translations[TextId.LEVEL_3] = new Dictionary<LanguageId, string>(tmp);

            //Champion
            tmp[LanguageId.ENG] = "Champions:";
            tmp[LanguageId.UA] = "Чемпіони:";
            tmp[LanguageId.RU] = "Чемпионы:";
            translations[TextId.CHAMPIONS] = new Dictionary<LanguageId, string>(tmp);

            //*****************    FORM OVER GAME   *******************************

            //TITLE            
            tmp[LanguageId.ENG] = "You win!";
            tmp[LanguageId.UA] = "Ви виграли!";
            tmp[LanguageId.RU] = "Вы победитель!";
            translations[TextId.YOU_WIN] = new Dictionary<LanguageId, string>(tmp);

            // time game
            tmp[LanguageId.ENG] = "Game time:";
            tmp[LanguageId.UA] = "Час гри";
            tmp[LanguageId.RU] = "Время игры";
            translations[TextId.TIME_GAME] = new Dictionary<LanguageId, string>(tmp);

            // Level title
            tmp[LanguageId.ENG] = "Difficulty level:";
            tmp[LanguageId.UA] = "Рівень складності:";
            tmp[LanguageId.RU] = "Уровень сложности:";
            translations[TextId.DIFIC_LEVEL_WIN] = new Dictionary<LanguageId, string>(tmp);

            // Name user
            tmp[LanguageId.ENG] = "Winner's name:";
            tmp[LanguageId.UA] = "Виграв:";
            tmp[LanguageId.RU] = "Выиграл:";
            translations[TextId.NAME_WIN_USER] = new Dictionary<LanguageId, string>(tmp);

            //*****************    FORM Chempions grid *******************************
            //TITLE            
            tmp[LanguageId.ENG] = "Champions!";
            tmp[LanguageId.UA] = "Чемпіoни!";
            tmp[LanguageId.RU] = "Чемпиони!";
            translations[TextId.TITLE_CHAMPIONS] = new Dictionary<LanguageId, string>(tmp);

            // Name title
            tmp[LanguageId.ENG] = "Name";
            tmp[LanguageId.UA] = "Ім'я";
            tmp[LanguageId.RU] = "Имя:";
            translations[TextId.NAME] = new Dictionary<LanguageId, string>(tmp);

            tmp[LanguageId.ENG] = "Level";
            tmp[LanguageId.UA] = "Рівень";
            tmp[LanguageId.RU] = "Уровень";
            translations[TextId.LEVEL] = new Dictionary<LanguageId, string>(tmp);

            tmp[LanguageId.ENG] = "Time";
            tmp[LanguageId.UA] = "Час";
            tmp[LanguageId.RU] = "Время";
            translations[TextId.TIME] = new Dictionary<LanguageId, string>(tmp);
        }

        public string getTranslation(TextId textId)
        {
            string result = "MISSING_TRANLATION!!!";
            if (translations.ContainsKey(textId))
            {
                Dictionary<LanguageId, string> langlPack = translations[textId];
                if (langlPack.ContainsKey(ControlInfo.getInstance().CurrentLang))
                {
                    result = langlPack[ControlInfo.getInstance().CurrentLang];
                }
            }
            return result;
        }
    }


}
