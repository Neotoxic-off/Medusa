using System.Collections.Generic;

namespace CHARACTERS
{
    public class characters
    {
        public class Rootobject
        {
            public string[] SURVIVORS { get; set; }
            public string[] KILLERS { get; set; }
        }

        public string GIDS(string name, Rootobject _content_)
        {
            for (int i = 0; i < _content_.SURVIVORS.Length; i++)
            {
                if (_content_.SURVIVORS[i].Split(',')[1].Contains(name))
                {
                    return (_content_.SURVIVORS[i].Split(',')[0]);
                }
            }

            return ("_NOTFOUND_");
        }

        public string GNS(string id, Rootobject _content_)
        {
            for (int i = 0; i < _content_.SURVIVORS.Length; i++)
            {
                if (_content_.SURVIVORS[i].Split(',')[0] == id)
                {
                    return (_content_.SURVIVORS[i].Split(',')[1]);
                }
            }

            return ("_NOTFOUND_");
        }

        public string GIDK(string name, Rootobject _content_)
        {
            for (int i = 0; i < _content_.KILLERS.Length; i++)
            {
                if (_content_.KILLERS[i].Split(',')[1].Contains(name))
                {
                    return (_content_.KILLERS[i].Split(',')[0]);
                }
            }

            return ("_NOTFOUND_");
        }

        public string GNK(string id, Rootobject _content_)
        {
            for (int i = 0; i < _content_.KILLERS.Length; i++)
            {
                if (_content_.KILLERS[i].Split(',')[0] == id)
                {
                    return (_content_.KILLERS[i].Split(',')[1]);
                }
            }

            return ("_NOTFOUND_");
        }
    }
}
