﻿using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
    }
}