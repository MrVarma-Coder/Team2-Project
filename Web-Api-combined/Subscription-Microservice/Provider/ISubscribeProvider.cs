using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubscriptionService.Models;
namespace SubscriptionService.Provider
{
    public interface ISubscribeProvider
    {
        Boolean Subscribe(PrescriptionDetails subscription, string PolicyDetails, int MemberId, string auth);
        //string auth
        SubscriptionDetails UnSubscribe(int Member_Id, int Subscription_Id,string auth);
    }
}
