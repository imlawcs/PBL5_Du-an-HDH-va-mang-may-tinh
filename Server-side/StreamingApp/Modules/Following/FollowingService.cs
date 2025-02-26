using StreamingApp.Models.Entities;
using StreamingApp.Managers;

namespace StreamingApp.Services {
    public class FollowingService : IFollowingService {
        private readonly FollowingManager followingManager;

        public FollowingService(FollowingManager followingManager) {
            this.followingManager = followingManager ?? throw new ArgumentNullException(nameof(followingManager));
        }

        public Task<Following[]> GetFollowingByChannelIdAsync(int channelId) {
            return followingManager.GetFollowingsByChannelIdAsync(channelId);
        }

        public Task<Following[]> GetAllFollowings() {
            return followingManager.GetAllFollowings();
        }

        public Task<(bool Succeeded, string[] Errors)> FollowUser(int channelId, int followerId) {
            return followingManager.FollowUser(channelId, followerId);
        }

        public Task<(bool Succeeded, string[] Errors)> UnfollowUser(int channelId, int followerId) {
            return followingManager.UnfollowUser(channelId, followerId);
        }

        public Task<bool> IsFollowing(int channelId, int followerId) {
            return followingManager.IsFollowing(channelId, followerId);
        }
    }
}