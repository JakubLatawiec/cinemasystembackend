﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly) 
        {
            var types = assembly.GetExportedTypes().Where(type =>
                typeof(IMap).IsAssignableFrom(type) && !type.IsInterface).ToList();

            foreach (var type in types) 
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
