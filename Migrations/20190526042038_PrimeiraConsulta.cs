using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Original.Migrations
{
    public partial class PrimeiraConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toregister",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    CPF = table.Column<string>(nullable: false ),
                    Peso = table.Column<double>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: true),
                    Sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toregister", x => x.Id);
                });
        }

            protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toregister");

        }
                
            




        }
    }


