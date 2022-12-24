using AutoMapper;
using DTO;
using DTO.ContentModels;
using DTO.Friend;
using Models;
using Models.ContentModels;
using Models.Friend;


namespace API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Base
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            //Auth
            CreateMap<UserAuthDto, User>();
            CreateMap<User, UserAuthDto>();

            //ContentModels
            CreateMap<Content, ContentDto>();
            CreateMap<ContentDto, Content>();
            CreateMap<ContentNotification, ContentNotificationDto>();
            CreateMap<ContentNotificationDto, ContentNotification>();
            CreateMap<ContentStatistics,ContentStatisticsDto>();
            CreateMap<ContentStatisticsDto, ContentStatistics>();

            //Friend
            CreateMap<Friendship, FriendshipDto>();
            CreateMap<FriendshipDto, Friendship>();
            CreateMap<FriendshipStatus, FriendshipStatusDto>();
            CreateMap<FriendshipStatusDto, FriendshipStatus>();
        }
    }
}
