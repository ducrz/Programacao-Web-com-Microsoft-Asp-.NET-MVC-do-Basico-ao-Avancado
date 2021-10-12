using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LojaWeb.Models;
using LojaWeb.Models.ModeloDados;

namespace LojaWeb.Automapper
{
    public class AutomapperProfile : Profile
    {
        //Construtor
        public AutomapperProfile()
        {
            CreateMap<ClienteModel, ClienteViewModel>().ReverseMap();
        }
    }
}
