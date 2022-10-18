using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Context;

public class ApplicationDbContext : IdentityDbContext<UserEntity>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<AnimalEntity> Animal { get; set; }
    public DbSet<SpeciesEntity> Species { get; set; }
    public DbSet<BreedEntity> Breed { get; set; }
    public DbSet<AdvertEntity> Advert { get; set; }
    public DbSet<AdKindEntity> AdKind { get; set; }
    public DbSet<UserEntity> User { get; set; }
    public DbSet<MessageEntity> Message { get; set; }
    public DbSet<ImageEntity> Image { get; set; }
    public DbSet<AddressEntity> Address { get; set; }
    public DbSet<ProvinceEntity> Province { get; set; }
    public DbSet<DistrictEntity> District { get; set; }
    public DbSet<NeighborhoodEntity> Neighborhood { get; set; }
    public DbSet<MessageReplyEntity> MessageReply { get; set; }

}

