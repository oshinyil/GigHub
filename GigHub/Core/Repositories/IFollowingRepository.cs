using GigHub.Core.Models;

namespace GigHub.Repositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string followerId, string followeeId);
        void Add(Following following);
        void Remove(Following following);
    }
}