using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leipzig.Services.IService
{
    interface ILeipzigMusicService
    {
        IList<LeipzigServices.MusicBEAN> GetLeipzigMusicRecordings(int genre);
    }
}
