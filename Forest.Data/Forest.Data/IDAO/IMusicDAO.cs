using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.BEANS;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO
    {
        IList<MusicBEAN> GetMusicRecordings(int genre);

        IList<Forest.Data.MusicCategory> GetMusicCategories();

        Music_Recording GetMusicRecording(int id);

        void EditMusicRecording(Music_Recording recording);
    }
}
