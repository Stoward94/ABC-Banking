﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashierSystem.Startup))]
namespace CashierSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
