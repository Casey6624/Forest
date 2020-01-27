using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leipzig.Services.IService;
using Leipzig.Services.Service;

namespace Leipzig.Services.Service
{
    public class LeipzigMusicService : ILeipzigMusicService
    {
        private LeipzigServices.ForestWebService _proxy;
        
        public LeipzigMusicService()
        {
            _proxy = new LeipzigServices.ForestWebService();
        }

        public IList<LeipzigServices.MusicBEAN> GetLeipzigMusicRecordings(int genre)
        {
            return _proxy.GetMusicRecordings(genre);
        }
    }
}
