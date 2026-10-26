using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class TelNoEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MusteriIletisim",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "MusteriTelefonNumarasi",
                table: "Musteriler");

            migrationBuilder.AlterColumn<string>(
                name: "MusteriSoyadi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MusteriCinsiyet",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MusteriAdi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MusteriAcikAdresi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MusteriEletisim",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriTelNo",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "Id", "MusteriAcikAdresi", "MusteriAdi", "MusteriCinsiyet", "MusteriEletisim", "MusteriSoyadi", "MusteriTelNo" },
                values: new object[,]
                {
                    { 1, "Ankara", "Nur", "Kadın", "gul@all.com", "Kılıç", "05390006040" },
                    { 2, "İstanbul", "Sevgi", "Kadın", "elanur@all.com", "Helin", "0539985459" },
                    { 3, "Ankara", "Sevilay", "Kadın", "sevilay@all.com", "Kalaycı", "0539888438" },
                    { 4, "İzmir", "Ada", "Kadın", "sura@all.com", "Çetin", "05391112273" },
                    { 5, "Bursa", "Eren", "Kadın", "ekin@all.com", "Kılıç", "05392223364" },
                    { 6, "Zeytintepe", "Fatmanur", "Kadın", "fatmanur@all.com", "Çelik", "05390004040" },
                    { 7, "Zonguldak", "Ayda", "Kadın", "ayda@all.com", "Çetinkaya", "0539885459" },
                    { 8, "Zonguldak", "Ayça", "Kadın", "ayca@all.com", "Çetinkaya", "0539885538" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "MusteriEletisim",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "MusteriTelNo",
                table: "Musteriler");

            migrationBuilder.AlterColumn<string>(
                name: "MusteriSoyadi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriCinsiyet",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriAdi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriAcikAdresi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriIletisim",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MusteriTelefonNumarasi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
