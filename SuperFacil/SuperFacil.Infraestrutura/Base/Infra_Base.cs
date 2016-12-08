using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Dominio.Modelos.Comercial;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Multimidia;
using SuperFacil.Dominio.Modelos.Recursos_Humano;
using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Base
{
    public class Infra_Base : IDisposable
    {

        #region - Construtor -
        public readonly SuperFacilContexto db;

        public Infra_Base()
        {
            db = new SuperFacilContexto();
        }
        #endregion

        #region - Administração -
        public IQueryable<Adm_Empresa> All_Adm_Empresa()
        {
            return db.Adm_Empresa.Where(x => !x.Deleted);
        }

        public IQueryable<Adm_Perfil> All_Adm_Perfil()
        {
            return db.Adm_Perfil.Where(x => !x.Deleted);
        }

        public IQueryable<Adm_Usuario> All_Adm_Usuario()
        {
            return db.Adm_Usuario.Where(x => !x.Deleted);
        }
        #endregion

        #region - Comercial -
        public IQueryable<Com_Localizacao> All_Com_Localizacao()
        {
            return db.Com_Localizacao.Where(x => !x.Deleted);
        }
        #endregion

        #region - Global -
        public IQueryable<Glo_Contacto> All_Glo_Contacto()
        {
            return db.Glo_Contacto.Where(x => !x.Deleted);
        }

        public IQueryable<Glo_Imagem> All_Glo_Imagem()
        {
            return db.Glo_Imagem.Where(x => !x.Deleted);
        }

        public IQueryable<Glo_Morada> All_Glo_Morada()
        {
            return db.Glo_Morada.Where(x => !x.Deleted);
        }

        public IQueryable<Glo_Nota> All_Glo_Nota()
        {
            return db.Glo_Nota.Where(x => !x.Deleted);
        }

        public IQueryable<Glo_Pais> All_Glo_Pais()
        {
            return db.Glo_Pais.Where(x => !x.Deleted);
        }
        #endregion

        #region - Multimidia -
        public IQueryable<Mul_Autor> All_Mul_Autor()
        {
            return db.Mul_Autor.Where(x => !x.Deleted);
        }

        #region - Comercial -
        //public IQueryable<Com_Localizacao> All_Com_Localizacao()
        //{
        //    return db.Com_Localizacao.Where(x => !x.Deleted);
        //}
        #endregion

        public IQueryable<Mul_Midia> All_Glo_Midia()
        {
            return db.Mul_Midia.Where(x => !x.Deleted);
        }
        #endregion

        #region - Recursos Humanos -
        public IQueryable<Reh_Funcionario> All_Reh_Funcionario()
        {
            return db.Reh_Funcionario.Where(x => !x.Deleted);
        }
        #endregion

        #region - Sistema -
        public IQueryable<Sis_Aplicacao> All_Sis_Aplicacao()
        {
            return db.Sis_Aplicacao.Where(x => !x.Deleted);
        }

        public IQueryable<Sis_HorarioAcesso> All_Sis_HorarioAcesso()
        {
            return db.Sis_HorarioAcesso.Where(x => !x.Deleted);
        }

        public IQueryable<Sis_Menu> All_Sis_Menu()
        {
            return db.Sis_Menu.Where(x => !x.Deleted);
        }

        public IQueryable<Sis_Modulo> All_Sis_Modulo()
        {
            return db.Sis_Modulo.Where(x => !x.Deleted);
        }

        public IQueryable<Sis_Sessao> All_Sis_Sessao()
        {
            return db.Sis_Sessao.Where(x => !x.Deleted);
        }
        #endregion

        #region - Destrutor -        
        public void Dispose()
        {
            db.Dispose();
        }

        ~Infra_Base()
        {
            Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion
    }
}
