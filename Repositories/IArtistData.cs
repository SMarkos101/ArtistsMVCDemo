using ArtistsMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistsMVCDemo.Repositories
{
    interface IArtistData :IDisposable
    {
        IEnumerable<Artist> GetAll();

    }
}
