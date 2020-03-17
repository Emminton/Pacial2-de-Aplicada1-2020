using Microsoft.EntityFrameworkCore.Migrations;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Llamadas",
                columns: table => new
                {
                    LlamadasId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamadas", x => x.LlamadasId);
                });

            migrationBuilder.CreateTable(
                name: "LLamadasDetalle",
                columns: table => new
                {
                    LLamadaDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LlamadasId = table.Column<int>(nullable: false),
                    Problema = table.Column<string>(nullable: true),
                    Solucion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LLamadasDetalle", x => x.LLamadaDetalleId);
                    table.ForeignKey(
                        name: "FK_LLamadasDetalle_Llamadas_LlamadasId",
                        column: x => x.LlamadasId,
                        principalTable: "Llamadas",
                        principalColumn: "LlamadasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LLamadasDetalle_LlamadasId",
                table: "LLamadasDetalle",
                column: "LlamadasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LLamadasDetalle");

            migrationBuilder.DropTable(
                name: "Llamadas");
        }
    }
}
