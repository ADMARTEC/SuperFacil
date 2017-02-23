using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Infraestructure.IoC;
using SuperFacil.Presentation._Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.Controllers
{
    public class Base_InqueritoController : BaseController
    {
        internal readonly IInq_Inquerito_AppService _InqueritoAppService;
        internal readonly IInq_Inquerito_Pergunta_Categoria_AppService _InqPergCategoriaAppService;
        internal readonly IInq_Inquerito_Resposta_AppService _InqRespostaAppService;
        internal readonly IInq_Inquerito_Pergunta_AppService _InqPerguntaAppService;

        internal readonly IInq_Questionario_AppService _QuestionarioAppService;
        internal readonly IInq_Questionario_Resposta_AppService _QuestRespostaAppService;


        public Base_InqueritoController()
        {
            var container = IoC.Start();
            _InqueritoAppService = container.GetService<IInq_Inquerito_AppService>();
            _InqPergCategoriaAppService = container.GetService<IInq_Inquerito_Pergunta_Categoria_AppService>();
            _InqPerguntaAppService = container.GetService<IInq_Inquerito_Pergunta_AppService>();
            _InqRespostaAppService = container.GetService<IInq_Inquerito_Resposta_AppService>();
            _QuestionarioAppService = container.GetService<IInq_Questionario_AppService>();
            _QuestRespostaAppService = container.GetService<IInq_Questionario_Resposta_AppService>();
        }       

    }
}