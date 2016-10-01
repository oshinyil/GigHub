using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string artistId);
        void Add(Gig gig);
    }
}
