using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
   public class ConfigMapper
    {
        public static IMapper Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingContainer());
            });
            return config.CreateMapper();
        }
    }
}
