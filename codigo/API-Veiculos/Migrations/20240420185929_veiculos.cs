using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class veiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeiculoIdVeiculo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_Veiculo_Veiculo_VeiculoIdVeiculo",
                        column: x => x.VeiculoIdVeiculo,
                        principalTable: "Veiculo",
                        principalColumn: "IdVeiculo");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VeiculoId = table.Column<int>(type: "int", nullable: false),
                    VeiculoTempId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Veiculo_VeiculoTempId",
                        column: x => x.VeiculoTempId,
                        principalTable: "Veiculo",
                        principalColumn: "IdVeiculo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_VeiculoId",
                table: "Reserva",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_VeiculoTempId",
                table: "Reserva",
                column: "VeiculoTempId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_VeiculoIdVeiculo",
                table: "Veiculo",
                column: "VeiculoIdVeiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
