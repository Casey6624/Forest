using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data;
using Forest.Data.IDAO;
using Forest.Data.DAO;
using Forest.Services.IService;
using Forest.Data.BEANS;
using Forest.Data;

namespace Forest.Services.Service
{
    public class MusicService : IMusicService
    { 
        private IMusicDAO _musicDAO;

        public MusicService()
        {
            _musicDAO = new MusicDAO();
        }

        public IList<MusicCategory> GetMusicCategories()
        {
            return _musicDAO.GetMusicCategories();
        }

        public void EditMusicRecording(Music_Recording recording)
        {
            _musicDAO.EditMusicRecording(recording);
        }

        IList<MusicBEAN> IMusicService.GetMusicRecordings(int genre)
        {
            return _musicDAO.GetMusicRecordings(genre);
        }

   
        public Music_Recording GetMusicRecording(int id)
        {
            return _musicDAO.GetMusicRecording(id);
        }
    }
}
