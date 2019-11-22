using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;
using Forest.Services.IService;
using Forest.Data;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        IList<MusicCategory> GetMusicCategories();

        IList<Music_Recording> GetMusicRecordings(String genre);

        Forest.Data.Music_Recording GetMusicRecording(int id);

        void EditMusicRecording(Music_Recording recording);
    }
}
