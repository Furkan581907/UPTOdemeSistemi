using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UPT.Common.VModels;
using UPT.DataAccess.DbModels;

namespace UPT.Common.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Users, UsersVM>().ReverseMap();
            CreateMap<Debts, DebtsVM>().ReverseMap();
            CreateMap<Deposits, DepositsVM>().ReverseMap();
            CreateMap<Payments, PaymentsVM>().ReverseMap();
            CreateMap<Subscriptions, SubscriptionsVM>().ReverseMap();
        }
    }
}
