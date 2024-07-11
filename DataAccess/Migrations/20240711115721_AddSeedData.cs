using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6068), "Türkiye'nin en köklü spor kulüplerinden biri olan Fenerbahçe, 1907 yılında kurulmuştur. Futbol, basketbol, voleybol ve daha birçok branşta başarılar elde etmiştir.", false, "Fenerbahçe" },
                    { 2, new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6077), "Galatasaray Spor Kulübü, 1905 yılında kurulmuş olup, futbol takımıyla Türkiye ve Avrupa'da birçok başarıya imza atmıştır. Sarı-kırmızılı renklere sahip kulüp, Süper Lig'in önemli takımlarındandır.", false, "Galatasaray" },
                    { 3, new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6078), "Trabzonspor, 1967 yılında Trabzon'da kurulmuş bir spor kulübüdür. Karadeniz'in güçlü temsilcisi olan Trabzonspor, Süper Lig'de birçok şampiyonluk yaşamış ve taraftarlarıyla dikkat çekmiştir.", false, "Trabzonspor" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "IsDeleted", "PictureUrl", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Fenerbahçe Spor Kulübü, 1907 yılında İstanbul'da kuruldu. Kuruluşundan bu yana birçok başarıya imza atan kulüp, Türkiye'nin en önemli spor kulüplerinden biridir...", new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6167), false, "/images/7.jpg", "Fenerbahçe Spor Kulübü'nün kuruluşundan bugüne kadar olan tarihini anlatan makale.", "Fenerbahçe'nin Tarihi", 1 },
                    { 2, 1, "Fenerbahçe, futbol takımıyla Süper Lig'de birçok şampiyonluk yaşadı. Ayrıca basketbol ve voleybol branşlarında da ulusal ve uluslararası başarılar elde etti...", new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6172), false, "/images/7.jpg", "Fenerbahçe'nin futbol, basketbol ve voleyboldaki başarılarını ele alan makale.", "Fenerbahçe'nin Başarıları", 1 },
                    { 3, 2, "Galatasaray Spor Kulübü, 1905 yılında Ali Sami Yen ve arkadaşları tarafından kurulmuştur. Sarı-kırmızılı renklere sahip olan kulüp, Türkiye'nin ve Avrupa'nın en önemli kulüplerinden biridir...", new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6174), false, "/images/7.jpg", "Galatasaray Spor Kulübü'nün köklü tarihini anlatan makale.", "Galatasaray'ın Tarihi", 1 },
                    { 4, 2, "Galatasaray, 2000 yılında UEFA Kupası'nı kazanarak büyük bir başarıya imza atmıştır. Aynı yıl UEFA Süper Kupa'yı da kazanarak Türk futbol tarihine geçmiştir...", new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6176), false, "/images/7.jpg", "Galatasaray'ın Avrupa kupalarındaki başarılarını ele alan makale.", "Galatasaray'ın Avrupa Başarıları", 1 },
                    { 5, 3, "Trabzonspor, 1975-76 sezonunda Süper Lig'de ilk şampiyonluğunu kazanmış ve Anadolu'dan şampiyon çıkan ilk takım olmuştur. Bu başarıyı takip eden yıllarda birçok şampiyonluk yaşamıştır...", new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6177), false, "/images/7.jpg", "Trabzonspor'un Süper Lig'deki şampiyonluklarını anlatan makale.", "Trabzonspor'un Şampiyonlukları", 1 },
                    { 6, 3, "Trabzonspor, Süper Lig'deki birçok unutulmaz maça imza atmıştır. Özellikle 1996-97 sezonunda Fenerbahçe'ye karşı oynadığı ve 4-3 kazandığı maç, kulüp tarihinin en unutulmaz anlarından biridir...", new DateTime(2024, 7, 11, 14, 57, 21, 443, DateTimeKind.Local).AddTicks(6178), false, "/images/7.jpg", "Trabzonspor'un tarihindeki unutulmaz maçlarını ele alan makale.", "Trabzonspor'un Unutulmaz Maçları", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
