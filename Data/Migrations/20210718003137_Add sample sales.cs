using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MLDemo.Data.Migrations
{
    public partial class Addsamplesales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.CreateTable(
                name: "sales_data_sample",
                columns: table => new
                {
                    ORDERNUMBER = table.Column<int>(type: "int", nullable: false),
                    QUANTITYORDERED = table.Column<int>(type: "int", nullable: false),
                    PRICEEACH = table.Column<double>(type: "float", nullable: false),
                    ORDERLINENUMBER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SALES = table.Column<double>(type: "float", nullable: false),
                    ORDERDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QTR_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MONTH_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YEAR_ID = table.Column<int>(type: "int", nullable: false),
                    PRODUCTLINE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MSRP = table.Column<int>(type: "int", nullable: false),
                    PRODUCTCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CUSTOMERNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ADDRESSLINE1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ADDRESSLINE2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    POSTALCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COUNTRY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TERRITORY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CONTACTLASTNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CONTACTFIRSTNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DEALSIZE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sales_data_sample");

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");
        }
    }
}
