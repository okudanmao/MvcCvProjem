using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsimSoyisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KısaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Deneyims",
                columns: table => new
                {
                    DeneyimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SirketPozisyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deneyims", x => x.DeneyimId);
                });

            migrationBuilder.CreateTable(
                name: "Egitims",
                columns: table => new
                {
                    EgitimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BölümAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulGirisTRH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulCikisTRH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BitirmePuani = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitims", x => x.EgitimId);
                });

            migrationBuilder.CreateTable(
                name: "ılgiAlanlaris",
                columns: table => new
                {
                    ilgiAlanlarıId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ılgiAlanlaris", x => x.ilgiAlanlarıId);
                });

            migrationBuilder.CreateTable(
                name: "yeteneklers",
                columns: table => new
                {
                    YetenekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yetenekisim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yeteneklers", x => x.YetenekId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Deneyims");

            migrationBuilder.DropTable(
                name: "Egitims");

            migrationBuilder.DropTable(
                name: "ılgiAlanlaris");

            migrationBuilder.DropTable(
                name: "yeteneklers");
        }
    }
}
