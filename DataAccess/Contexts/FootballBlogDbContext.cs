using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Identity;

namespace DataAccess.Contexts
{
    public class FootballBlogDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public FootballBlogDbContext(DbContextOptions<FootballBlogDbContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Fluent API validation
            builder.Entity<Article>().Property("Title").IsRequired().HasMaxLength(200);
            builder.Entity<Article>().Property("Summary").IsRequired().HasMaxLength(500);
            builder.Entity<Category>().Property("Name").IsRequired().HasMaxLength(100);
            builder.Entity<Tag>().Property("Content").IsRequired().HasMaxLength(20);
            builder.Entity<Comment>().Property("Content").IsRequired();

            //Seed Data
            builder.Entity<Category>().HasData(
                    new Category() { Id = 1, Name = "Fenerbahçe", Description = "Türkiye'nin en köklü spor kulüplerinden biri olan Fenerbahçe, 1907 yılında kurulmuştur. Futbol, basketbol, voleybol ve daha birçok branşta başarılar elde etmiştir." },
                    new Category() { Id = 2, Name = "Galatasaray", Description = "Galatasaray Spor Kulübü, 1905 yılında kurulmuş olup, futbol takımıyla Türkiye ve Avrupa'da birçok başarıya imza atmıştır. Sarı-kırmızılı renklere sahip kulüp, Süper Lig'in önemli takımlarındandır." },
                    new Category() { Id = 3, Name = "Trabzonspor", Description = "Trabzonspor, 1967 yılında Trabzon'da kurulmuş bir spor kulübüdür. Karadeniz'in güçlü temsilcisi olan Trabzonspor, Süper Lig'de birçok şampiyonluk yaşamış ve taraftarlarıyla dikkat çekmiştir." }
                );

            builder.Entity<Article>().HasData(
                    new Article() { Id = 1, Title = "Fenerbahçe'nin Tarihi", Summary = "Fenerbahçe Spor Kulübü'nün kuruluşundan bugüne kadar olan tarihini anlatan makale.", Content = "Fenerbahçe Spor Kulübü, 1907 yılında İstanbul'da kuruldu. Kuruluşundan bu yana birçok başarıya imza atan kulüp, Türkiye'nin en önemli spor kulüplerinden biridir...", CategoryId = 1, UserId = 1, PictureUrl = "/images/7.jpg" },
                    new Article() { Id = 2, Title = "Fenerbahçe'nin Başarıları", Summary = "Fenerbahçe'nin futbol, basketbol ve voleyboldaki başarılarını ele alan makale.", Content = "Fenerbahçe, futbol takımıyla Süper Lig'de birçok şampiyonluk yaşadı. Ayrıca basketbol ve voleybol branşlarında da ulusal ve uluslararası başarılar elde etti...", CategoryId = 1, UserId = 1, PictureUrl = "/images/7.jpg" },
                    new Article() { Id = 3, Title = "Galatasaray'ın Tarihi", Summary = "Galatasaray Spor Kulübü'nün köklü tarihini anlatan makale.", Content = "Galatasaray Spor Kulübü, 1905 yılında Ali Sami Yen ve arkadaşları tarafından kurulmuştur. Sarı-kırmızılı renklere sahip olan kulüp, Türkiye'nin ve Avrupa'nın en önemli kulüplerinden biridir...", CategoryId = 2, UserId = 1, PictureUrl = "/images/7.jpg" },
                    new Article() { Id = 4, Title = "Galatasaray'ın Avrupa Başarıları", Summary = "Galatasaray'ın Avrupa kupalarındaki başarılarını ele alan makale.", Content = "Galatasaray, 2000 yılında UEFA Kupası'nı kazanarak büyük bir başarıya imza atmıştır. Aynı yıl UEFA Süper Kupa'yı da kazanarak Türk futbol tarihine geçmiştir...", CategoryId = 2, UserId = 1, PictureUrl = "/images/7.jpg" },
                    new Article() { Id = 5, Title = "Trabzonspor'un Şampiyonlukları", Summary = "Trabzonspor'un Süper Lig'deki şampiyonluklarını anlatan makale.", Content = "Trabzonspor, 1975-76 sezonunda Süper Lig'de ilk şampiyonluğunu kazanmış ve Anadolu'dan şampiyon çıkan ilk takım olmuştur. Bu başarıyı takip eden yıllarda birçok şampiyonluk yaşamıştır...", CategoryId = 3, UserId = 1, PictureUrl = "/images/7.jpg" },
                    new Article() { Id = 6, Title = "Trabzonspor'un Unutulmaz Maçları", Summary = "Trabzonspor'un tarihindeki unutulmaz maçlarını ele alan makale.", Content = "Trabzonspor, Süper Lig'deki birçok unutulmaz maça imza atmıştır. Özellikle 1996-97 sezonunda Fenerbahçe'ye karşı oynadığı ve 4-3 kazandığı maç, kulüp tarihinin en unutulmaz anlarından biridir...", CategoryId = 3, UserId = 1, PictureUrl = "/images/7.jpg" }
                );



            base.OnModelCreating(builder);
        }

    }

}