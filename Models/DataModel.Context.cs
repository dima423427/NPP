﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace NPP.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class NPPBASEEntities : DbContext
{
    public NPPBASEEntities()
        : base("name=NPPBASEEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Tool> Tools { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<General> Generals { get; set; }

}

}
