﻿using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Multimidia
    {
    public class Mul_Autor_Map : EntityTypeConfiguration<Mul_Autor>
        {
        public Mul_Autor_Map()
            {

            Property(x => x.Autor_ID)
            .HasColumnOrder(1)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
           .HasColumnOrder(2)
           .IsRequired();

            Property(x => x.Biografia_ID)
           .HasColumnOrder(3)
           .IsRequired();

            Property(x => x.Nome)
           .HasColumnOrder(4)
           .IsRequired()
           .HasMaxLength(250)
           .HasColumnType("nvarchar");

            Property(x => x.Sobrenome)
           .HasColumnOrder(4)
           .IsRequired()
           .HasMaxLength(250)
           .HasColumnType("nvarchar");

            Property(x => x.Alcunha)
           .HasColumnOrder(4)
           .IsRequired()
           .HasMaxLength(250)
           .HasColumnType("nvarchar");
            }
        }
    }