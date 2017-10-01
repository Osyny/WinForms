using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
   
    enum Level
    {
        LEVEL_1,
        LEVEL_2,
        LEVEL_3
    }


    struct FieldSize
    {
        public FieldSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; }
        public int Height { get; }
    }

    // SINGELTON

    class ControlInfo 
    {
        static public ControlInfo getInstance()
        {
            //doDeserialize();

            if (instance == null)
                instance = new ControlInfo();

            return instance;
        }

        static private ControlInfo instance;

        //------------------
        private Info curentInfo = new Info();
        static private Dictionary<string, Info> infos;

        private string currentUserName = "";

        private LanguageId currentLang = LanguageId.UA;
        private Level currentLevel = Level.LEVEL_1;

        private Dictionary<Level, FieldSize> fieldSizes;

        private ControlInfo()
        {
            infos = new Dictionary<string, Info>();
            fieldSizes = new Dictionary<Level, FieldSize>();

            fieldSizes[Level.LEVEL_1] = new FieldSize(8, 8);
            fieldSizes[Level.LEVEL_2] = new FieldSize(10, 10);
            fieldSizes[Level.LEVEL_3] = new FieldSize(12, 15);
        }

        public Dictionary<string, Info> Infos { get { return infos; } }
        public LanguageId CurrentLang { get { return currentLang;  } set { currentLang = value;  } }
        public Info CurrentInfo { get { return infos[currentUserName]; } }
        public FieldSize GameSize { get { return fieldSizes[currentLevel]; } }
        
        public void setLevel(Level level)
        {
            currentLevel = level;
        }

        public void addInfoName( string name, string level)
        {
            Info info = new Info(name, level);
            currentUserName = name;
            infos[name] = info;
        }

        //ADD TIME
        public void addTimeGame(string time)
        {
            infos[currentUserName].Time = time;
        }

        //DO_SERIALIZE
      /*  static private void doDeserialize()
        {
            if (File.Exists("saperInfo.dat"))
            {
                FileStream stream = File.OpenRead("saperInfo.dat");
                if (stream.Length != 0)
                {
                    BinaryFormatter formater = new BinaryFormatter();

                    instance = formater.Deserialize(stream) as ControlInfo;
                }
                stream.Close();
            }
        }

        //SERIALIZE
        public void doSerialize()
        {
            FileStream stream;

            if (File.Exists("saperInfo.dat"))
                stream = File.OpenWrite("saperInfo.dat");
            else
                stream = File.Create("saperInfo.dat");

            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(stream, instance);
            stream.Close();
        }*/

    }
}
