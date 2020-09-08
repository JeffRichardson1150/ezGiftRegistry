using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezGift.Services
{
    public class GiftUrlService
    {
        private readonly int _eventId;

        public GiftUrlService()
        {

        }

        //public GiftUrlService(int? eventId)
        public GiftUrlService(int eventId)
        {
            _eventId = eventId;

        }
        //public IEnumerable<GiftUrlListItem> GetGiftUrlsByEvent()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //            .GiftUrls
        //            .Where(e => e.RegistryEvent.RegistryEventId == _eventId)
        //            .Select(
        //                e =>
        //                    new GiftUrlListItem
        //                    {
        //                        GiftUrlId = e.GiftUrlId,
        //                        GiftUrlName = e.GiftUrlName,
        //                        GiftUrlDescription = e.GiftUrlDescription,
        //                        RegistryEventId = e.RegistryEventId,
        //                        RegistryEvent = e.RegistryEvent
        //                    }
        //                );
        //        return query.ToArray();
        //    }
        //}
        //public bool CreateGiftUrl(GiftUrlCreate model)
        //{
        //    var entity =
        //        new GiftUrl()
        //        {
        //            GiftUrlName = model.GiftUrlName,
        //            GiftUrlDescription = model.GiftUrlDescription,
        //            RegistryEventId = model.RegistryEventId,
        //            //RegistryEvent = model.RegistryEvent
        //        };

        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        ctx.GiftUrls.Add(entity);
        //        return ctx.SaveChanges() == 1;
        //    }
        //}

        //public GiftUrlDetail GetGiftUrlById(int id)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .GiftUrls
        //                .Single(e => e.GiftUrlId == id);
        //        return
        //            new GiftUrlDetail
        //            {
        //                GiftUrlId = entity.GiftUrlId,
        //                GiftUrlName = entity.GiftUrlName,
        //                GiftUrlDescription = entity.GiftUrlDescription,
        //                RegistryEventId = entity.RegistryEventId,
        //                RegistryEvent = entity.RegistryEvent
        //            };
        //    }
        //}

        //public bool UpdateGiftUrl(GiftUrlEdit model)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .GiftUrls
        //                .Single(e => e.GiftUrlId == model.GiftUrlId);

        //        entity.GiftUrlId = model.GiftUrlId;
        //        entity.GiftUrlName = model.GiftUrlName;
        //        entity.GiftUrlDescription = model.GiftUrlDescription;
        //        entity.RegistryEventId = model.RegistryEventId;
        //        entity.RegistryEvent = model.RegistryEvent;

        //        return ctx.SaveChanges() == 1;
        //    }
        //}

        //public bool DeleteGiftUrl(int giftId)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .GiftUrls
        //                .Single(e => e.GiftUrlId == giftId);

        //        ctx.GiftUrls.Remove(entity);

        //        return ctx.SaveChanges() == 1;
        //    }
        //}

        //public IEnumerable<GiftUrlListItem> GetGiftUrls()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //            .GiftUrls
        //            .Where(e => e.UserProfileId == _thisUserProfileId)
        //            .Select(
        //                e =>
        //                    new GiftUrlListItem
        //                    {

        //                        GiftUrlId = e.GiftUrlId,
        //                        UserProfileId = e.UserProfileId,
        //                        UserProfile = e.UserProfile,
        //                        GiftUrlTitle = e.GiftUrlTitle,
        //                        GiftUrlDescription = e.GiftUrlDescription,
        //                        EventLocation = e.EventLocation,
        //                        EventDate = e.EventDate
        //                    }
        //                );
        //        return query.ToArray();
        //    }
        //}


    }
}

