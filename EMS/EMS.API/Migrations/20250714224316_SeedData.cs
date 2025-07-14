using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 22, new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Sarah White", "07779031884" },
                    { 2, 53, new DateTime(1972, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Michael Smith", "07405996016" },
                    { 3, 42, new DateTime(1982, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Barbara White", "07723366584" },
                    { 4, 57, new DateTime(1967, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "David Brown", "07927847324" },
                    { 5, 31, new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Joseph Jackson", "07181099521" },
                    { 6, 22, new DateTime(2003, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Susan Harris", "07591909908" },
                    { 7, 21, new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "John Brown", "07703138056" },
                    { 8, 40, new DateTime(1984, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "John Harris", "07553537983" },
                    { 9, 48, new DateTime(1977, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Martin", "07181776514" },
                    { 10, 25, new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Thomas", "07810253031" },
                    { 11, 53, new DateTime(1971, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Elizabeth Thomas", "07511913220" },
                    { 12, 38, new DateTime(1986, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charles Johnson", "07127276230" },
                    { 13, 34, new DateTime(1991, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Elizabeth Thomas", "07845105766" },
                    { 14, 27, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Barbara Harris", "07597040756" },
                    { 15, 42, new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Elizabeth Smith", "07705949211" },
                    { 16, 43, new DateTime(1982, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "James Thomas", "07750723106" },
                    { 17, 31, new DateTime(1994, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "David Jackson", "07609234811" },
                    { 18, 53, new DateTime(1971, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Michael Taylor", "07854362849" },
                    { 19, 36, new DateTime(1988, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Smith", "07759790344" },
                    { 20, 37, new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jessica Jackson", "07148887791" },
                    { 21, 22, new DateTime(2003, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "William Harris", "07237076891" },
                    { 22, 24, new DateTime(2001, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Thomas Martin", "07756386023" },
                    { 23, 36, new DateTime(1988, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "James Jackson", "07803841951" },
                    { 24, 30, new DateTime(1994, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "David Harris", "07473674841" },
                    { 25, 25, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Charles Harris", "07669455070" },
                    { 26, 56, new DateTime(1969, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "James White", "07919480245" },
                    { 27, 41, new DateTime(1984, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Patricia White", "07762186566" },
                    { 28, 50, new DateTime(1975, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda Smith", "07617023123" },
                    { 29, 55, new DateTime(1969, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Karen Martin", "07926549427" },
                    { 30, 21, new DateTime(2003, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "William Johnson", "07423900169" },
                    { 31, 53, new DateTime(1971, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Richard White", "07843478129" },
                    { 32, 45, new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jennifer Taylor", "07965796452" },
                    { 33, 50, new DateTime(1974, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Michael Taylor", "07696515560" },
                    { 34, 56, new DateTime(1968, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Susan Taylor", "07640266298" },
                    { 35, 59, new DateTime(1965, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Richard Taylor", "07805345253" },
                    { 36, 53, new DateTime(1972, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Thomas Smith", "07456129635" },
                    { 37, 24, new DateTime(2000, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Jessica White", "07599619258" },
                    { 38, 48, new DateTime(1977, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "William Harris", "07806874986" },
                    { 39, 39, new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Thomas", "07330112191" },
                    { 40, 28, new DateTime(1996, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Thomas Martin", "07297937662" },
                    { 41, 48, new DateTime(1977, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Johnson", "07878666073" },
                    { 42, 23, new DateTime(2002, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Robert Martin", "07734912769" },
                    { 43, 35, new DateTime(1990, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara Harris", "07244477956" },
                    { 44, 33, new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joseph Anderson", "07603477481" },
                    { 45, 47, new DateTime(1977, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Susan Thomas", "07853322251" },
                    { 46, 48, new DateTime(1976, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "David Johnson", "07629191335" },
                    { 47, 57, new DateTime(1967, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Patricia Smith", "07674021358" },
                    { 48, 52, new DateTime(1973, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Sarah White", "07907677659" },
                    { 49, 53, new DateTime(1971, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Robert Harris", "07487148699" },
                    { 50, 54, new DateTime(1970, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Karen Smith", "07561798091" },
                    { 51, 52, new DateTime(1972, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Taylor", "07353270886" },
                    { 52, 54, new DateTime(1970, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Charles Harris", "07436945931" },
                    { 53, 48, new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "James Taylor", "07377877117" },
                    { 54, 27, new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "James White", "07572950326" },
                    { 55, 58, new DateTime(1967, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Sarah Harris", "07985873735" },
                    { 56, 25, new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Sarah Taylor", "07301091971" },
                    { 57, 29, new DateTime(1995, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara Thomas", "07136770631" },
                    { 58, 48, new DateTime(1976, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Jennifer Martin", "07822441011" },
                    { 59, 37, new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jennifer Anderson", "07284746652" },
                    { 60, 55, new DateTime(1969, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joseph Harris", "07278400033" },
                    { 61, 56, new DateTime(1969, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Michael Martin", "07324803945" },
                    { 62, 42, new DateTime(1982, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Sarah Jackson", "07338647847" },
                    { 63, 52, new DateTime(1973, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Robert Harris", "07760642182" },
                    { 64, 47, new DateTime(1977, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "James Brown", "07141991091" },
                    { 65, 42, new DateTime(1983, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Jessica Martin", "07754539848" },
                    { 66, 23, new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Mary White", "07953313015" },
                    { 67, 32, new DateTime(1992, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Sarah Smith", "07605948455" },
                    { 68, 48, new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Michael Brown", "07509839705" },
                    { 69, 29, new DateTime(1996, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Barbara Thomas", "07844609971" },
                    { 70, 24, new DateTime(2000, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Patricia Brown", "07895633187" },
                    { 71, 42, new DateTime(1982, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "William Jackson", "07661574151" },
                    { 72, 39, new DateTime(1986, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Linda Anderson", "07247075237" },
                    { 73, 49, new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mary Brown", "07937748893" },
                    { 74, 39, new DateTime(1986, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Barbara White", "07623162570" },
                    { 75, 26, new DateTime(1999, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Patricia Jackson", "07595791592" },
                    { 76, 44, new DateTime(1980, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Sarah Thomas", "07130387126" },
                    { 77, 42, new DateTime(1983, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Barbara Taylor", "07593184245" },
                    { 78, 22, new DateTime(2002, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thomas Jackson", "07514553698" },
                    { 79, 39, new DateTime(1985, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Susan Harris", "07560658854" },
                    { 80, 52, new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Charles White", "07554763589" },
                    { 81, 51, new DateTime(1973, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Patricia Brown", "07541817257" },
                    { 82, 26, new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Harris", "07483579404" },
                    { 83, 60, new DateTime(1965, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Mary Smith", "07707843674" },
                    { 84, 51, new DateTime(1974, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Sarah Jackson", "07544654541" },
                    { 85, 54, new DateTime(1970, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Mary Jackson", "07722371088" },
                    { 86, 37, new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Michael Jackson", "07199744962" },
                    { 87, 32, new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Charles Jackson", "07274577595" },
                    { 88, 32, new DateTime(1993, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Joseph Taylor", "07166522141" },
                    { 89, 43, new DateTime(1981, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Mary Taylor", "07935981690" },
                    { 90, 46, new DateTime(1978, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Thomas Smith", "07950667766" },
                    { 91, 51, new DateTime(1974, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "David Harris", "07554535801" },
                    { 92, 59, new DateTime(1966, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "William Jackson", "07353296613" },
                    { 93, 51, new DateTime(1973, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Patricia Anderson", "07248652870" },
                    { 94, 35, new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "Jessica Martin", "07575233975" },
                    { 95, 28, new DateTime(1997, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Robert Jackson", "07937935843" },
                    { 96, 23, new DateTime(2002, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Linda White", "07971959917" },
                    { 97, 41, new DateTime(1984, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Barbara Taylor", "07741465574" },
                    { 98, 34, new DateTime(1990, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Elizabeth Harris", "07492854354" },
                    { 99, 32, new DateTime(1992, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Elizabeth Thomas", "07124244947" },
                    { 100, 29, new DateTime(1995, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "David Smith", "07949159961" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
