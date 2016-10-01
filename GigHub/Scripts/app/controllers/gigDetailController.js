﻿var GigDetailController = function (followingService) {
    var followButton;

    var init = function () {
        $(".js-toggle-follow").click(toggleFollowing);
    };

    var toggleFollowing = function (e) {
        followButton = $(e.target);
        var followeeId = followButton.attr("data-user-id");

        if (followButton.hasClass("btn-default")) {
            followingService.createFollowing(followeeId, done, fail);
        } else {
            followingService.deleteFollowing(followeeId, done, fail);
        }
    };

    var fail = function () {
        alert("Something failed!");
    };

    var done = function () {
        var text = followButton.text() === "Follow" ? "Following" : "Follow";
        followButton.toggleClass("btn-info").toggleClass("btn-default").text(text);
    };

    return {
        init: init
    }
}(FollowingService);