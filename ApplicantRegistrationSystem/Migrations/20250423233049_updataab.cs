using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicantRegistrationSystem.Migrations
{
    /// <inheritdoc />
    public partial class updataab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BenefitDocumentDate",
                table: "Abiturients",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BenefitDocumentNumber",
                table: "Abiturients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BenefitIssuedBy",
                table: "Abiturients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BenefitType",
                table: "Abiturients",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BenefitDocumentDate",
                table: "Abiturients");

            migrationBuilder.DropColumn(
                name: "BenefitDocumentNumber",
                table: "Abiturients");

            migrationBuilder.DropColumn(
                name: "BenefitIssuedBy",
                table: "Abiturients");

            migrationBuilder.DropColumn(
                name: "BenefitType",
                table: "Abiturients");
        }
    }
}
