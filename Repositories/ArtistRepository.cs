using ArtistsMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistsMVCDemo.Repositories
{
    public class ArtistRepository : IArtistData
    {
        private readonly ApplicationDbContext _context;

        public ArtistRepository()
        {
            _context = new ApplicationDbContext();
        }       

        public IEnumerable<Artist> GetAll()
        {            
            return _context.Artists.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}