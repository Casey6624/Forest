using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;

namespace Forest.Data.IDAO
{
    public class MusicDAO : IMusicDAO
    {
        private ForestEntities _context;
        public MusicDAO()
        {
            _context = new ForestEntities();
        }

        public IList<MusicCategory> GetMusicCategory()
        {
            IQueryable<MusicCategory> _categories;
            _categories = from category in _context.MusicCategory select category;
            return _categories.ToList<MusicCategory>();
        }
    }
}
