﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc.Startup))]
namespace Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
