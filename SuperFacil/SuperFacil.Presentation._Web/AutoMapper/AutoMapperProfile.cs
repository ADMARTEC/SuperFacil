using AutoMapper;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Entities.Sistema;
using SuperFacil.Domain.Entities.Sistema.Generico;
using SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels;
using SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel;
using SuperFacil.Presentation._Web.ViewModels.Sistema;
using SuperFacil.Presentation._Web.ViewModels.Sistema.Generico;

namespace SuperFacil.Presentation._Web.AutoMapper
{
    public class AutoMapperProfile
    {
        public static void Register()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Mul_Autor, Autor_ViewModel>().ReverseMap();
                x.CreateMap<Mul_Midia, Midia_ViewModel>().ReverseMap();
                x.CreateMap<Mul_Localizacao, Localizacao_ViewModel>().ReverseMap();

                x.CreateMap<Inq_Inquerito, Inq_Inquerito_ViewModel>().ReverseMap();
                x.CreateMap<Inq_Inquerito_Pergunta, Inq_Inquerito_Pergunta_ViewModel>().ReverseMap();
                x.CreateMap<Inq_Inquerito_Pergunta_Categoria, Inq_Inquerito_Pergunta_Categoria_ViewModel>().ReverseMap();
                x.CreateMap<Inq_Inquerito_Resposta, Inq_Inquerito_Resposta_ViewModel>().ReverseMap();

                x.CreateMap<Inq_Questionario_ViewModel, Inq_Questionario>().ForSourceMember(j => j.Municipio_ID, k => k.Ignore()).ReverseMap();
                x.CreateMap<Inq_Questionario_Resposta, Inq_Questionario_Resposta_ViewModel>().ReverseMap();

                x.CreateMap<Sis_Empresa, Sis_Empresa_ViewModel>().ReverseMap();
                x.CreateMap<Sis_Gen_Pais, Sis_Gen_Pais_ViewModel>().ReverseMap();
            });

            Mapper.AssertConfigurationIsValid();
        }
    }
}