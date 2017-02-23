using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Entities.Sistema;
using SuperFacil.Domain.Entities.Sistema.Generico;
using SuperFacil.Infrasctruture.Data.Context;
using System;
using System.Data.Entity.Migrations;

namespace SuperFacil.Infrasctruture.Data.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<SuperFacilContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        string[,] provincia = new string[,]
        {
            {"AO-BGO","Bengo" },{"AO-BGU","Benguela" },{"AO-BIE","Bié" },{"AO-CAB","Cabinda" },
            {"AO-CCU","Cuando-Cubango" },{"AO-CNN","Cunene" },{"AO-HUA","Huambo" },{"AO-HUI","Huíla" },
            {"AO-CNO","Kwanza Norte" },{"AO-CUS","Kwanza Sul" },{"AO-LUA","Luanda" },{"AO-LNO","Lunda Norte" },
            {"AO-LSU","Lunda Sul" },{"AO-MAL","Malange" },{"AO-MOX","Moxico" },{"AO-NAM","Namibe" },
            {"AO-UIG","Uíge" },{"AO-ZAI","Zaire" }
        };
        string[] municipio = new string[] { "Belas", "Viana", "Luanda", "Quiçama", "Icolo e Bengo", "Cazenga" };

        string[] genero = new string[] { "Masculino", "Femenino" };
        string[] ocupacao = new string[] { "Estudante", "Empresado", "Negócio proprio", "Desempregado" };


        protected override void Seed(SuperFacilContext context)
        {
            #region - Gemidia -
            for (int i = 50; i < 3050; i = i + 50)
            {
                context.Mul_Localizacao.AddOrUpdate(
                    p => p.Designacao,

                    new Mul_Localizacao
                    {
                        Designacao = "Bloco nº " + i,
                        Activo = true,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        UpdateDate = DateTime.Now,
                        UpdateUser = 1,
                        Deleted = false,
                        Default = false
                    });
            }
            context.SaveChanges();
            #endregion

            #region - Sistema -
            context.Sis_Empresa.AddOrUpdate(
                    p => p.Designacao,

                    new Sis_Empresa
                    {
                        Designacao = "ADMARTEC,LDA",
                        Activo = true,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        UpdateDate = DateTime.Now,
                        UpdateUser = 1,
                        Deleted = false,
                        DefaultSystem = true
                    });

            #region - Pais, Provincia, Municipio -

            context.Sis_Gen_Pais.AddOrUpdate(
                    p => p.Designacao,
                    new Sis_Gen_Pais
                    {
                        ISO = "ISO 3166-1",
                        Codigo = "AGO",
                        Designacao = "Angola",
                        Gps_Latitude = "-8.817831",
                        Gps_Longitude = "13.235601",
                        Activo = true,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        UpdateDate = DateTime.Now,
                        UpdateUser = 1,
                        Deleted = false,
                        DefaultSystem = true
                    });


            for (int i = 0; i <= 17; i++)
            {
                context.Sis_Gen_Pais.AddOrUpdate(
                    p => p.Designacao,

                    new Sis_Gen_Pais
                    {
                        Provincia_ID = 1,
                        ISO = "ISO 3166-2",
                        Codigo = provincia[i, 0],
                        Designacao = provincia[i, 1],
                        Gps_Latitude = "-8.817831",
                        Gps_Longitude = "13.235601",
                        Activo = true,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        UpdateDate = DateTime.Now,
                        UpdateUser = 1,
                        Deleted = false,
                        DefaultSystem = true
                    });
            };

            for (int i = 0; i < municipio.Length; i++)
            {
                context.Sis_Gen_Pais.AddOrUpdate(
                               p => p.Designacao,
                               new Sis_Gen_Pais
                               {
                                   Provincia_ID = 1,
                                   Municipio_ID = 12,
                                   Designacao = municipio[i],
                                   Gps_Latitude = "-8.817831",
                                   Gps_Longitude = "13.235601",
                                   Activo = true,
                                   CreateDate = DateTime.Now,
                                   CreateUser = 1,
                                   UpdateDate = DateTime.Now,
                                   UpdateUser = 1,
                                   Deleted = false,
                                   DefaultSystem = true
                               });
            }

            #endregion
            context.SaveChanges();
            #endregion

            #region - Inquerito -
            context.Inq_Inquerito.AddOrUpdate(
                    p => p.Designacao,

                    new Inq_Inquerito
                    {
                        Empresa_ID = 1,
                        Designacao = "Causas e consequências dos comportamentos negativos de jovens e adultos em Angola",
                        Activo = true,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        UpdateDate = DateTime.Now,
                        UpdateUser = 1,
                        Deleted = false,
                        DefaultSystem = true
                    });
            context.SaveChanges();

            context.Inq_Inquerito_Pergunta_Categoria.AddOrUpdate(
                    p => p.Designacao,

                    new Inq_Inquerito_Pergunta_Categoria
                    {
                        Inquerito_ID = 1,
                        Designacao = "Dados Sociodemográficos",
                        Observacao = "As próximas perguntas dizem respeito à  sua situação escolar e familiar. Assinala no espaço respondente a opção com um (X) que melhor indica a tua situação.",
                        Activo = true,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        UpdateDate = DateTime.Now,
                        UpdateUser = 1,
                        Deleted = false,
                        DefaultSystem = true
                    },
                     new Inq_Inquerito_Pergunta_Categoria
                     {
                         Inquerito_ID = 1,
                         Designacao = "Indicação de comportamentos",
                         Observacao = "Muitos jovens as vezes fazem coisas que não são totalmente permitidas.",
                         Activo = true,
                         CreateDate = DateTime.Now,
                         CreateUser = 1,
                         UpdateDate = DateTime.Now,
                         UpdateUser = 1,
                         Deleted = false,
                         DefaultSystem = true
                     });
            context.SaveChanges();

            context.Inq_Inquerito_Pergunta.AddOrUpdate(
             p => p.Designacao,

             new Inq_Inquerito_Pergunta
             {
                 Inquerito_Pergunta_Categoria_ID = 1,
                 Designacao = "Qual é a sua idade?",
                 TipoResposta = "unico",
                 NumResposta = 1,
                 Activo = true,
                 CreateDate = DateTime.Now,
                 CreateUser = 1,
                 UpdateDate = DateTime.Now,
                 UpdateUser = 1,
                 Deleted = false,
                 DefaultSystem = true
             },
              new Inq_Inquerito_Pergunta
              {
                  Inquerito_Pergunta_Categoria_ID = 1,
                  Designacao = "Qual é o seu Genero (Sexo)?",
                  TipoResposta = "unico",
                  NumResposta = 1,
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = 1,
                  UpdateDate = DateTime.Now,
                  UpdateUser = 1,
                  Deleted = false,
                  DefaultSystem = true
              },
                new Inq_Inquerito_Pergunta
                {
                    Inquerito_Pergunta_Categoria_ID = 1,
                    Designacao = "Qual é a sua ocupação?",
                    TipoResposta = "multiple",
                    NumResposta = 2,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = 1,
                    UpdateDate = DateTime.Now,
                    UpdateUser = 1,
                    Deleted = false,
                    DefaultSystem = true
                });
            context.SaveChanges();

            for (int i = 18; i < 100; i++)
            {
                context.Inq_Inquerito_Resposta.AddOrUpdate(
                   p => p.Designacao,

                   new Inq_Inquerito_Resposta
                   {
                       Inquerito_Pergunta_ID = 1,
                       Designacao = "" + i + "",
                       Activo = true,
                       CreateDate = DateTime.Now,
                       CreateUser = 1,
                       UpdateDate = DateTime.Now,
                       UpdateUser = 1,
                       Deleted = false,
                       DefaultSystem = true
                   });
            }

            for (int i = 0; i < genero.Length; i++)
            {
                context.Inq_Inquerito_Resposta.AddOrUpdate(
                   p => p.Designacao,

                   new Inq_Inquerito_Resposta
                   {
                       Inquerito_Pergunta_ID = 2,
                       Designacao = genero[i],
                       Activo = true,
                       CreateDate = DateTime.Now,
                       CreateUser = 1,
                       UpdateDate = DateTime.Now,
                       UpdateUser = 1,
                       Deleted = false,
                       DefaultSystem = true
                   });
            }

            for (int i = 0; i < ocupacao.Length; i++)
            {
                context.Inq_Inquerito_Resposta.AddOrUpdate(
                   p => p.Designacao,

                   new Inq_Inquerito_Resposta
                   {
                       Inquerito_Pergunta_ID = 3,
                       Designacao = ocupacao[i],
                       Activo = true,
                       CreateDate = DateTime.Now,
                       CreateUser = 1,
                       UpdateDate = DateTime.Now,
                       UpdateUser = 1,
                       Deleted = false,
                       DefaultSystem = true
                   });
            }

            context.SaveChanges();
            #endregion
        }
    }
}
