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

        private LeipzigServices.AuthenticationHeader _authenticationHeader;


        public LeipzigMusicService()
        {
            _authenticationHeader = new LeipzigServices.AuthenticationHeader();
            _proxy = new LeipzigServices.ForestWebService();
        }

        public IList<LeipzigServices.MusicBEAN> GetLeipzigMusicRecordings(int genre)
        {
            _authenticationHeader.username = "test";
            _authenticationHeader.password = "pass";
            _proxy.AuthenticationHeaderValue = _authenticationHeader;
            return _proxy.GetMusicRecordings(genre);
        }
    }
}
