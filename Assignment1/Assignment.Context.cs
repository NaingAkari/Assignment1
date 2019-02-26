﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AssignmentMEntities : DbContext
    {
        public AssignmentMEntities()
            : base("name=AssignmentMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AudioFile> AudioFiles { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Collect> Collects { get; set; }
    
        public virtual int spAddNewAudioFile(string name, Nullable<int> fileSize, string filePath)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var fileSizeParameter = fileSize.HasValue ?
                new ObjectParameter("FileSize", fileSize) :
                new ObjectParameter("FileSize", typeof(int));
    
            var filePathParameter = filePath != null ?
                new ObjectParameter("FilePath", filePath) :
                new ObjectParameter("FilePath", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddNewAudioFile", nameParameter, fileSizeParameter, filePathParameter);
        }
    
        public virtual ObjectResult<spGetAllAudioFile_Result> spGetAllAudioFile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllAudioFile_Result>("spGetAllAudioFile");
        }
    }
}
