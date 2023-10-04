﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.service.singleton
{
    public class UserCommandServiceSingleton
    {
        private static readonly Lazy<UserCommandService> _instance = new Lazy<UserCommandService>(() => new UserCommandService());

        public static UserCommandService Instance => _instance.Value;

        private UserCommandServiceSingleton() { }

    }
}
