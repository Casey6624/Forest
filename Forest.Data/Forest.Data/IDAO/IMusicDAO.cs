﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO
    {
        IList<Forest.Data.Music_Recording> GetMusicRecordings(string genre);

        IList<Forest.Data.MusicCategory> GetMusicCategories();

        Music_Recording GetMusicRecording(int id);
    }
}
