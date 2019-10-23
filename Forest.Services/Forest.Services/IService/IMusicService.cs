using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;
using Forest.Services.IService;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        IList<Forest.Data.MusicCategory> GetMusicCategories();
    }
}
