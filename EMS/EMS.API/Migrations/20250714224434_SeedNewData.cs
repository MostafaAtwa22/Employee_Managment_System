using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 41, new DateTime(1983, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Sarah Smith", "07695320486" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1972, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbara Jackson", "07143491540" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 33, new DateTime(1991, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Richard Thomas", "07767423367" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 60, new DateTime(1965, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Linda Anderson", "07926017989" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 55, new DateTime(1969, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Johnson", "07486283553" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1982, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Robert Johnson", "07812472212" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 60, new DateTime(1965, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbara Brown", "07511486996" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1993, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Mary Brown", "07983373472" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 41, new DateTime(1984, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Taylor", "07965569550" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 23, new DateTime(2002, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Johnson", "07489075523" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2001, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Karen Jackson", "07858694593" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 40, new DateTime(1984, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "John Brown", "07694507912" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 44, new DateTime(1980, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Robert Martin", "07130098638" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 45, new DateTime(1979, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Richard Johnson", "07663514636" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 60, new DateTime(1965, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Anderson", "07755726564" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1968, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Robert Anderson", "07991760208" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 36, new DateTime(1989, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Michael Johnson", "07179720222" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 22, new DateTime(2003, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Richard Jackson", "07721160011" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1971, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Linda Martin", "07806733447" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { new DateTime(1988, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles Smith", "07871702311" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1971, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Jackson", "07664214158" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 51, new DateTime(1973, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joseph White", "07946662610" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 35, new DateTime(1989, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Elizabeth White", "07298836046" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 23, new DateTime(2001, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "James Brown", "07829835112" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1968, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "James Thomas", "07783889556" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1971, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Robert White", "07367039105" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2001, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Smith", "07167582280" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 44, new DateTime(1980, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda Harris", "07276621943" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 26, new DateTime(1999, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "William Brown", "07942401533" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 60, new DateTime(1965, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Patricia Johnson", "07476909706" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1968, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Mary White", "07299544286" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 56, new DateTime(1968, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Barbara Smith", "07436892403" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 43, new DateTime(1982, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Anderson", "07533870203" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1992, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Taylor", "07933218621" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 49, new DateTime(1976, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Linda Jackson", "07864294117" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 60, new DateTime(1965, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Robert Taylor", "07905062071" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 50, new DateTime(1974, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Richard Johnson", "07423893918" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 45, new DateTime(1980, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Linda Johnson", "07501123556" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 44, new DateTime(1981, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Linda Harris", "07142891434" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1967, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda White", "07873993623" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 44, new DateTime(1980, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jennifer Taylor", "07112763652" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 39, new DateTime(1985, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Mary Jackson", "07809440678" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 59, new DateTime(1966, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Charles Johnson", "07515701565" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1976, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Patricia Smith", "07295766357" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 28, new DateTime(1996, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Richard Thomas", "07189213834" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 35, new DateTime(1990, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Charles Jackson", "07354381546" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 49, new DateTime(1975, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Linda Taylor", "07393683831" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2000, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "David Martin", "07938114324" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1992, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph Anderson", "07438370544" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 47, new DateTime(1977, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Karen Jackson", "07619855262" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1993, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Brown", "07665997179" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 40, new DateTime(1985, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan Anderson", "07575445575" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1970, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Susan Taylor", "07764959885" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 45, new DateTime(1979, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Barbara Martin", "07780587811" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 30, new DateTime(1994, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Joseph Taylor", "07178052764" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1973, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Thomas Jackson", "07752053235" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "David Taylor", "07245747201" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { new DateTime(1977, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Charles White", "07303455811" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 28, new DateTime(1997, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Linda Taylor", "07709308060" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 59, new DateTime(1965, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Susan Taylor", "07149782620" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 26, new DateTime(1999, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Thomas Jackson", "07327945511" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 21, new DateTime(2003, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Robert Harris", "07322378945" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 35, new DateTime(1990, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Jennifer Brown", "07713776747" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 55, new DateTime(1970, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Johnson", "07896295716" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1971, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Brown", "07217516363" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 58, new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Barbara Harris", "07822917085" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 34, new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Brown", "07935526390" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 36, new DateTime(1989, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Linda Thomas", "07446206109" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 30, new DateTime(1994, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "John White", "07350053471" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 33, new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara Martin", "07268169821" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 23, new DateTime(2002, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles Smith", "07952583390" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 20, new DateTime(2004, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Michael Martin", "07720060198" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 46, new DateTime(1979, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Michael Taylor", "07760548711" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 30, new DateTime(1994, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Mary Harris", "07291567777" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 46, new DateTime(1978, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Elizabeth Thomas", "07591707754" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 35, new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Elizabeth Smith", "07810697546" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 55, new DateTime(1970, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Robert Thomas", "07878496294" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 44, new DateTime(1981, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Patricia Taylor", "07802997713" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1971, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mary Martin", "07488512072" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 34, new DateTime(1990, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Barbara Jackson", "07204005367" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { new DateTime(1973, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "John Anderson", "07896963789" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1982, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Joseph Jackson", "07348157129" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 41, new DateTime(1984, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Linda Taylor", "07241592095" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1971, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Joseph Anderson", "07247351858" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 59, new DateTime(1965, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Linda Smith", "07351188602" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 45, new DateTime(1980, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Thomas Smith", "07432283263" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 40, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Karen Martin", "07416899863" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1972, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "John Brown", "07363328494" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 26, new DateTime(1998, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Robert Smith", "07123541611" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 36, new DateTime(1989, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Joseph Smith", "07882857045" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1977, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Patricia Thomas", "07787216653" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 31, new DateTime(1993, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Karen Jackson", "07804222199" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 37, new DateTime(1987, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Thomas Johnson", "07122513913" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 37, new DateTime(1988, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Linda Anderson", "07490864478" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 45, new DateTime(1979, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "William White", "07723815472" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 46, new DateTime(1979, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Brown", "07643768389" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1983, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Brown", "07109797061" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1968, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Michael Thomas", "07799205240" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1973, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jennifer Martin", "07366111993" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 28, new DateTime(1997, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "James Johnson", "07665461531" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 101, 57, new DateTime(1967, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "John White", "07348732659" },
                    { 102, 24, new DateTime(2000, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Robert Thomas", "07988525908" },
                    { 103, 52, new DateTime(1972, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Joseph Johnson", "07788347662" },
                    { 104, 59, new DateTime(1966, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Barbara Johnson", "07363810641" },
                    { 105, 42, new DateTime(1982, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Charles Harris", "07137369938" },
                    { 106, 41, new DateTime(1983, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Charles Harris", "07607558570" },
                    { 107, 33, new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Joseph Jackson", "07155180496" },
                    { 108, 45, new DateTime(1980, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Susan Anderson", "07378457968" },
                    { 109, 58, new DateTime(1966, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charles Brown", "07612480716" },
                    { 110, 51, new DateTime(1974, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Susan Harris", "07318507493" },
                    { 111, 39, new DateTime(1985, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Joseph White", "07837045810" },
                    { 112, 59, new DateTime(1966, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Robert Taylor", "07268995765" },
                    { 113, 52, new DateTime(1973, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Joseph Smith", "07391889587" },
                    { 114, 55, new DateTime(1969, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Charles Martin", "07682808150" },
                    { 115, 27, new DateTime(1998, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Patricia Jackson", "07719440841" },
                    { 116, 36, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Jackson", "07793109779" },
                    { 117, 56, new DateTime(1969, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Michael Johnson", "07324549533" },
                    { 118, 54, new DateTime(1970, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Susan Martin", "07802340271" },
                    { 119, 59, new DateTime(1966, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Richard Thomas", "07806071411" },
                    { 120, 57, new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Susan Harris", "07202401574" },
                    { 121, 42, new DateTime(1982, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Patricia Smith", "07943380427" },
                    { 122, 32, new DateTime(1992, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Susan Anderson", "07752150130" },
                    { 123, 27, new DateTime(1997, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Charles Johnson", "07624002096" },
                    { 124, 36, new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Jessica Harris", "07174291275" },
                    { 125, 24, new DateTime(2000, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Elizabeth Johnson", "07884693532" },
                    { 126, 37, new DateTime(1988, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Mary Martin", "07841360949" },
                    { 127, 37, new DateTime(1987, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Linda Martin", "07535988288" },
                    { 128, 55, new DateTime(1969, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charles Johnson", "07444376710" },
                    { 129, 50, new DateTime(1975, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Harris", "07615508290" },
                    { 130, 43, new DateTime(1982, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Patricia White", "07459074149" },
                    { 131, 57, new DateTime(1968, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Patricia Smith", "07458152390" },
                    { 132, 55, new DateTime(1969, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Patricia Martin", "07170311676" },
                    { 133, 47, new DateTime(1977, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Charles Harris", "07366775910" },
                    { 134, 35, new DateTime(1989, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Charles Jackson", "07568897314" },
                    { 135, 24, new DateTime(2001, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Elizabeth Martin", "07292311833" },
                    { 136, 53, new DateTime(1972, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Jackson", "07159324837" },
                    { 137, 30, new DateTime(1995, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Richard Smith", "07658331451" },
                    { 138, 32, new DateTime(1993, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Patricia Jackson", "07566174998" },
                    { 139, 41, new DateTime(1983, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Johnson", "07982936646" },
                    { 140, 33, new DateTime(1991, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Karen Anderson", "07905421487" },
                    { 141, 26, new DateTime(1999, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "John Martin", "07366987261" },
                    { 142, 44, new DateTime(1981, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Joseph Harris", "07941980378" },
                    { 143, 42, new DateTime(1982, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Karen Brown", "07715856451" },
                    { 144, 28, new DateTime(1997, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jennifer Smith", "07117697045" },
                    { 145, 25, new DateTime(2000, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jennifer Jackson", "07495340832" },
                    { 146, 20, new DateTime(2004, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Johnson", "07453175206" },
                    { 147, 23, new DateTime(2002, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Michael Taylor", "07789627754" },
                    { 148, 28, new DateTime(1996, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Karen White", "07107421640" },
                    { 149, 23, new DateTime(2002, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Michael Anderson", "07177200808" },
                    { 150, 53, new DateTime(1971, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "William Anderson", "07919932916" },
                    { 151, 23, new DateTime(2002, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Michael Smith", "07741389230" },
                    { 152, 58, new DateTime(1966, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Susan White", "07884100613" },
                    { 153, 21, new DateTime(2004, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "James Martin", "07175050208" },
                    { 154, 42, new DateTime(1982, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Joseph Jackson", "07655747012" },
                    { 155, 53, new DateTime(1972, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Joseph Brown", "07717416160" },
                    { 156, 54, new DateTime(1970, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "John Thomas", "07420979597" },
                    { 157, 23, new DateTime(2002, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Sarah Thomas", "07608337939" },
                    { 158, 21, new DateTime(2003, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charles Johnson", "07550676661" },
                    { 159, 54, new DateTime(1971, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "James Martin", "07544907565" },
                    { 160, 45, new DateTime(1979, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Charles Harris", "07958394981" },
                    { 161, 36, new DateTime(1989, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Joseph Harris", "07144865701" },
                    { 162, 32, new DateTime(1993, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "James Anderson", "07972270004" },
                    { 163, 59, new DateTime(1966, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Susan Taylor", "07926658751" },
                    { 164, 27, new DateTime(1997, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Robert Brown", "07550108171" },
                    { 165, 22, new DateTime(2003, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Karen Johnson", "07207627647" },
                    { 166, 25, new DateTime(1999, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Thomas", "07174025125" },
                    { 167, 38, new DateTime(1987, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "James Thomas", "07306381739" },
                    { 168, 20, new DateTime(2004, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Patricia Jackson", "07233058417" },
                    { 169, 24, new DateTime(2001, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Susan Jackson", "07429243015" },
                    { 170, 50, new DateTime(1974, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Linda Thomas", "07907757277" },
                    { 171, 52, new DateTime(1972, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Linda White", "07364589659" },
                    { 172, 23, new DateTime(2001, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda Johnson", "07839709965" },
                    { 173, 50, new DateTime(1975, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Elizabeth White", "07471737613" },
                    { 174, 54, new DateTime(1970, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Robert Anderson", "07335494288" },
                    { 175, 28, new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Smith", "07256036703" },
                    { 176, 33, new DateTime(1992, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Thomas Anderson", "07157261735" },
                    { 177, 32, new DateTime(1993, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Robert Johnson", "07144181800" },
                    { 178, 20, new DateTime(2004, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "David Taylor", "07923588517" },
                    { 179, 23, new DateTime(2002, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara White", "07305700400" },
                    { 180, 28, new DateTime(1997, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Mary Anderson", "07578775297" },
                    { 181, 34, new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Thomas Anderson", "07755692076" },
                    { 182, 41, new DateTime(1984, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Linda Jackson", "07437666945" },
                    { 183, 55, new DateTime(1970, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Thomas", "07377092518" },
                    { 184, 53, new DateTime(1971, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Michael Brown", "07238430446" },
                    { 185, 41, new DateTime(1983, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "William Taylor", "07132694272" },
                    { 186, 35, new DateTime(1989, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Karen Jackson", "07509414896" },
                    { 187, 46, new DateTime(1978, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Sarah Thomas", "07707567824" },
                    { 188, 49, new DateTime(1975, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Sarah Thomas", "07213410584" },
                    { 189, 41, new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Patricia White", "07708948874" },
                    { 190, 35, new DateTime(1989, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jessica Taylor", "07143067167" },
                    { 191, 36, new DateTime(1988, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Michael Harris", "07456332922" },
                    { 192, 52, new DateTime(1973, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Robert Brown", "07472216013" },
                    { 193, 52, new DateTime(1973, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Michael White", "07661992372" },
                    { 194, 44, new DateTime(1980, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James White", "07964093750" },
                    { 195, 44, new DateTime(1981, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "William Johnson", "07930357454" },
                    { 196, 26, new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Elizabeth Smith", "07609859644" },
                    { 197, 43, new DateTime(1982, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Elizabeth Taylor", "07890137631" },
                    { 198, 50, new DateTime(1974, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jessica Martin", "07920912838" },
                    { 199, 23, new DateTime(2002, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Thomas Brown", "07197520281" },
                    { 200, 24, new DateTime(2000, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "David Anderson", "07494378409" },
                    { 201, 48, new DateTime(1977, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Karen Thomas", "07394097750" },
                    { 202, 43, new DateTime(1982, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jennifer Thomas", "07431452580" },
                    { 203, 34, new DateTime(1991, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Thomas", "07811254362" },
                    { 204, 29, new DateTime(1995, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Michael White", "07572248658" },
                    { 205, 30, new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Karen Smith", "07548178520" },
                    { 206, 23, new DateTime(2002, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jennifer Jackson", "07288368904" },
                    { 207, 32, new DateTime(1992, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jessica Taylor", "07953796158" },
                    { 208, 41, new DateTime(1984, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Joseph Harris", "07426563856" },
                    { 209, 32, new DateTime(1993, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Charles Johnson", "07984247566" },
                    { 210, 49, new DateTime(1976, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jennifer Smith", "07392391197" },
                    { 211, 43, new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Elizabeth Martin", "07704567245" },
                    { 212, 51, new DateTime(1974, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Susan Harris", "07209852355" },
                    { 213, 23, new DateTime(2001, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "William Johnson", "07190801091" },
                    { 214, 48, new DateTime(1977, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Susan Martin", "07376774959" },
                    { 215, 42, new DateTime(1983, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Barbara Taylor", "07966187851" },
                    { 216, 53, new DateTime(1971, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Karen Anderson", "07368829454" },
                    { 217, 37, new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Barbara Martin", "07758333437" },
                    { 218, 57, new DateTime(1968, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "William Brown", "07488281382" },
                    { 219, 41, new DateTime(1984, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Richard Anderson", "07766230411" },
                    { 220, 27, new DateTime(1998, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Patricia Jackson", "07552335506" },
                    { 221, 48, new DateTime(1977, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Patricia Thomas", "07627268049" },
                    { 222, 26, new DateTime(1999, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Sarah Harris", "07431551280" },
                    { 223, 27, new DateTime(1997, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "William Johnson", "07175233514" },
                    { 224, 50, new DateTime(1975, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Charles Jackson", "07745434349" },
                    { 225, 22, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Richard Taylor", "07183620128" },
                    { 226, 32, new DateTime(1993, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joseph Martin", "07359264442" },
                    { 227, 32, new DateTime(1993, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Karen Johnson", "07819816521" },
                    { 228, 57, new DateTime(1968, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Thomas Anderson", "07161247700" },
                    { 229, 31, new DateTime(1993, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Robert Jackson", "07228220080" },
                    { 230, 24, new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Elizabeth Jackson", "07682387402" },
                    { 231, 57, new DateTime(1968, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jennifer Anderson", "07182756354" },
                    { 232, 50, new DateTime(1974, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Martin", "07624694610" },
                    { 233, 57, new DateTime(1968, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Mary Brown", "07624236025" },
                    { 234, 41, new DateTime(1983, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Karen Martin", "07138695946" },
                    { 235, 46, new DateTime(1978, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Patricia Harris", "07439267659" },
                    { 236, 44, new DateTime(1981, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Karen Anderson", "07336714590" },
                    { 237, 38, new DateTime(1986, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Michael White", "07259804684" },
                    { 238, 37, new DateTime(1988, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Joseph Anderson", "07746492496" },
                    { 239, 43, new DateTime(1981, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jessica Smith", "07757550243" },
                    { 240, 60, new DateTime(1965, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "John Brown", "07368461529" },
                    { 241, 39, new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Karen Brown", "07115284696" },
                    { 242, 23, new DateTime(2001, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Robert Jackson", "07201609637" },
                    { 243, 48, new DateTime(1977, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Elizabeth White", "07790101998" },
                    { 244, 40, new DateTime(1985, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Jackson", "07108994156" },
                    { 245, 38, new DateTime(1987, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Linda Thomas", "07484553098" },
                    { 246, 56, new DateTime(1969, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Patricia Smith", "07168118839" },
                    { 247, 45, new DateTime(1979, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Elizabeth Taylor", "07887787365" },
                    { 248, 52, new DateTime(1973, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "James White", "07141050357" },
                    { 249, 50, new DateTime(1975, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Charles Anderson", "07620913720" },
                    { 250, 32, new DateTime(1993, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Mary Anderson", "07215583652" },
                    { 251, 55, new DateTime(1969, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Michael Thomas", "07196176668" },
                    { 252, 50, new DateTime(1975, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Karen Anderson", "07902980689" },
                    { 253, 55, new DateTime(1969, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Sarah White", "07431414660" },
                    { 254, 56, new DateTime(1969, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Susan Harris", "07385885020" },
                    { 255, 33, new DateTime(1991, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jennifer Thomas", "07689154782" },
                    { 256, 34, new DateTime(1991, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Elizabeth Martin", "07907344889" },
                    { 257, 41, new DateTime(1984, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Susan Martin", "07925186830" },
                    { 258, 25, new DateTime(1999, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Jessica Taylor", "07592657953" },
                    { 259, 24, new DateTime(2001, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda Harris", "07204211003" },
                    { 260, 43, new DateTime(1982, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Karen Anderson", "07786914817" },
                    { 261, 31, new DateTime(1993, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "David Johnson", "07344505464" },
                    { 262, 45, new DateTime(1980, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Sarah Taylor", "07959608687" },
                    { 263, 25, new DateTime(2000, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Susan Thomas", "07971177052" },
                    { 264, 33, new DateTime(1991, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda Jackson", "07547540821" },
                    { 265, 26, new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "William Smith", "07805935321" },
                    { 266, 58, new DateTime(1967, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Robert Martin", "07434024326" },
                    { 267, 43, new DateTime(1981, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jennifer Thomas", "07971571075" },
                    { 268, 44, new DateTime(1981, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Susan Harris", "07956696286" },
                    { 269, 33, new DateTime(1991, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Robert Martin", "07333644932" },
                    { 270, 45, new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Elizabeth Anderson", "07619682021" },
                    { 271, 56, new DateTime(1969, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Richard Harris", "07719225394" },
                    { 272, 21, new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jennifer White", "07661102961" },
                    { 273, 41, new DateTime(1984, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "James Harris", "07626355224" },
                    { 274, 49, new DateTime(1976, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Thomas Martin", "07209387547" },
                    { 275, 50, new DateTime(1974, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Karen Anderson", "07204455521" },
                    { 276, 34, new DateTime(1991, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Jennifer Smith", "07477878067" },
                    { 277, 37, new DateTime(1987, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Jessica Smith", "07237573948" },
                    { 278, 43, new DateTime(1981, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Thomas", "07963457618" },
                    { 279, 59, new DateTime(1966, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Sarah White", "07817191746" },
                    { 280, 53, new DateTime(1972, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jennifer Martin", "07237464805" },
                    { 281, 40, new DateTime(1984, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "David Martin", "07788965151" },
                    { 282, 39, new DateTime(1986, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Susan Smith", "07111846291" },
                    { 283, 38, new DateTime(1986, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charles Johnson", "07330664510" },
                    { 284, 36, new DateTime(1989, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jennifer Johnson", "07957587002" },
                    { 285, 37, new DateTime(1987, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Mary White", "07585402089" },
                    { 286, 21, new DateTime(2004, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "John Brown", "07484213842" },
                    { 287, 33, new DateTime(1991, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "John Thomas", "07505338559" },
                    { 288, 27, new DateTime(1998, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Jennifer Jackson", "07522388696" },
                    { 289, 56, new DateTime(1968, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "James Jackson", "07849585551" },
                    { 290, 48, new DateTime(1976, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "William Jackson", "07304957127" },
                    { 291, 50, new DateTime(1975, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda Johnson", "07143491142" },
                    { 292, 24, new DateTime(2001, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Patricia Brown", "07992271229" },
                    { 293, 49, new DateTime(1975, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "David White", "07238554455" },
                    { 294, 57, new DateTime(1968, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Robert Martin", "07397155741" },
                    { 295, 54, new DateTime(1971, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jennifer Martin", "07114369789" },
                    { 296, 29, new DateTime(1996, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "William Johnson", "07848390965" },
                    { 297, 41, new DateTime(1983, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Jessica Anderson", "07342088259" },
                    { 298, 54, new DateTime(1970, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara Smith", "07152335798" },
                    { 299, 31, new DateTime(1994, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Martin", "07602009144" },
                    { 300, 29, new DateTime(1995, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Richard Anderson", "07392645084" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 22, new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Sarah White", "07779031884" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1972, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Smith", "07405996016" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1982, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Barbara White", "07723366584" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1967, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "David Brown", "07927847324" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 31, new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Joseph Jackson", "07181099521" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 22, new DateTime(2003, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Susan Harris", "07591909908" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 21, new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Brown", "07703138056" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 40, new DateTime(1984, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "John Harris", "07553537983" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1977, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Martin", "07181776514" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 25, new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Thomas", "07810253031" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1971, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Elizabeth Thomas", "07511913220" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 38, new DateTime(1986, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charles Johnson", "07127276230" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 34, new DateTime(1991, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Elizabeth Thomas", "07845105766" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 27, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Barbara Harris", "07597040756" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth Smith", "07705949211" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 43, new DateTime(1982, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Thomas", "07750723106" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 31, new DateTime(1994, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "David Jackson", "07609234811" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1971, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Michael Taylor", "07854362849" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 36, new DateTime(1988, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Smith", "07759790344" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica Jackson", "07148887791" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 22, new DateTime(2003, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Harris", "07237076891" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2001, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Thomas Martin", "07756386023" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 36, new DateTime(1988, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "James Jackson", "07803841951" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 30, new DateTime(1994, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "David Harris", "07473674841" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 25, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Charles Harris", "07669455070" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 56, new DateTime(1969, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "James White", "07919480245" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 41, new DateTime(1984, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Patricia White", "07762186566" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 50, new DateTime(1975, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda Smith", "07617023123" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 55, new DateTime(1969, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Karen Martin", "07926549427" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 21, new DateTime(2003, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "William Johnson", "07423900169" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1971, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Richard White", "07843478129" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 45, new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jennifer Taylor", "07965796452" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 50, new DateTime(1974, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Michael Taylor", "07696515560" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 56, new DateTime(1968, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Susan Taylor", "07640266298" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 59, new DateTime(1965, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Richard Taylor", "07805345253" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1972, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Thomas Smith", "07456129635" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2000, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jessica White", "07599619258" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1977, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "William Harris", "07806874986" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 39, new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Thomas", "07330112191" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 28, new DateTime(1996, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Thomas Martin", "07297937662" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1977, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Johnson", "07878666073" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 23, new DateTime(2002, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Robert Martin", "07734912769" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 35, new DateTime(1990, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara Harris", "07244477956" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 33, new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joseph Anderson", "07603477481" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 47, new DateTime(1977, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Susan Thomas", "07853322251" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1976, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "David Johnson", "07629191335" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 57, new DateTime(1967, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Patricia Smith", "07674021358" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1973, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Sarah White", "07907677659" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 53, new DateTime(1971, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Harris", "07487148699" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1970, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Smith", "07561798091" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1972, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Taylor", "07353270886" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1970, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles Harris", "07436945931" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "James Taylor", "07377877117" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 27, new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "James White", "07572950326" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 58, new DateTime(1967, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Sarah Harris", "07985873735" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 25, new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Sarah Taylor", "07301091971" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 29, new DateTime(1995, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara Thomas", "07136770631" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { new DateTime(1976, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Jennifer Martin", "07822441011" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 37, new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jennifer Anderson", "07284746652" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 55, new DateTime(1969, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joseph Harris", "07278400033" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 56, new DateTime(1969, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Michael Martin", "07324803945" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1982, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Sarah Jackson", "07338647847" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1973, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Robert Harris", "07760642182" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 47, new DateTime(1977, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "James Brown", "07141991091" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1983, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Jessica Martin", "07754539848" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 23, new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Mary White", "07953313015" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1992, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah Smith", "07605948455" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 48, new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Michael Brown", "07509839705" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 29, new DateTime(1996, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Barbara Thomas", "07844609971" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 24, new DateTime(2000, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Patricia Brown", "07895633187" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1982, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Jackson", "07661574151" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 39, new DateTime(1986, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Linda Anderson", "07247075237" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 49, new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Brown", "07937748893" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 39, new DateTime(1986, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara White", "07623162570" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 26, new DateTime(1999, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Patricia Jackson", "07595791592" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 44, new DateTime(1980, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Sarah Thomas", "07130387126" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 42, new DateTime(1983, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Barbara Taylor", "07593184245" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 22, new DateTime(2002, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Jackson", "07514553698" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 39, new DateTime(1985, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan Harris", "07560658854" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 52, new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Charles White", "07554763589" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { new DateTime(1973, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Patricia Brown", "07541817257" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 26, new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Harris", "07483579404" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 60, new DateTime(1965, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Mary Smith", "07707843674" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 51, new DateTime(1974, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Sarah Jackson", "07544654541" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 54, new DateTime(1970, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Mary Jackson", "07722371088" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 37, new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Michael Jackson", "07199744962" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Charles Jackson", "07274577595" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1993, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Joseph Taylor", "07166522141" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 43, new DateTime(1981, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Mary Taylor", "07935981690" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 46, new DateTime(1978, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Thomas Smith", "07950667766" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 51, new DateTime(1974, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "David Harris", "07554535801" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 59, new DateTime(1966, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "William Jackson", "07353296613" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 51, new DateTime(1973, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Patricia Anderson", "07248652870" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 35, new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Martin", "07575233975" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 28, new DateTime(1997, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Robert Jackson", "07937935843" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[] { 23, new DateTime(2002, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda White", "07971959917" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 41, new DateTime(1984, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Barbara Taylor", "07741465574" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 34, new DateTime(1990, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Elizabeth Harris", "07492854354" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 32, new DateTime(1992, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Elizabeth Thomas", "07124244947" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[] { 29, new DateTime(1995, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "David Smith", "07949159961" });
        }
    }
}
