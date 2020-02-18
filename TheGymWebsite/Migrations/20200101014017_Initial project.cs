using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheGymWebsite.Migrations
{
    public partial class Initialproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Title = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    AddressLineOne = table.Column<string>(nullable: false),
                    AddressLineTwo = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: false),
                    Postcode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreePasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DateIssued = table.Column<DateTime>(nullable: false),
                    DateUsed = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreePasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gyms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    AddressLineOne = table.Column<string>(nullable: false),
                    AddressLineTwo = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: false),
                    Postcode = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipDeals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipDeals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenHours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    DayName = table.Column<int>(nullable: false),
                    OpenTime = table.Column<TimeSpan>(nullable: false),
                    CloseTime = table.Column<TimeSpan>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(maxLength: 200, nullable: false),
                    JobType = table.Column<int>(nullable: false),
                    JobPeriod = table.Column<int>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    PayInterval = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecord",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceRecord_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "210b86ac-4cf9-4622-b036-63538527cf2e", "e04ea160-3b06-4cb4-b232-ab3d9cc01af5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLineOne", "AddressLineTwo", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Title", "Town", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18500ac7-d4d4-48e3-ae25-73472024b0bf", 0, "1 Admin Road", "Admin Area", "382252dc-20e6-4b26-883d-2147301d983a", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", true, "AdminFirstName", 0, "AdminLastName", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHRzTJbDkTvC+5H3avMusIrNK/ewzf53XWCamofOt9I+94pwK/LvQ9S9loHYOOAWxw==", "00000000000", false, "AD1 2MN", "d0a471d3-bd2b-4293-97a1-d5f3b0cbceb5", 0, "AdminTown", false, "admin@admin.com" },
                    { "0626cffb-c5c4-4be2-8ea9-cb90fd168f71", 0, "1 huss Road", "huss Area", "05df934a-0959-4c26-a751-7939aa7a4e78", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "huss@yahoo.com", true, "hussFirstName", 0, "hussLastName", false, null, "HUSS@YAHOO.COM", "HUSS@YAHOO.COM", "AQAAAAEAACcQAAAAEBztugXWM9oBsie7a8B/1ng8DiKXY/KILgE3ch1XTeeR1MH/xXzPEK5V38JkvJuv9Q==", "00000000000", false, "AD1 2MN", "2f818cc9-7f1a-4613-b9b0-17519271a749", 0, "hussTown", false, "huss@yahoo.com" },
                    { "87a8cfe3-48d7-4b8c-b476-54464c0177ad", 0, "1 beky Road", "beky Area", "4b9e4e6b-91a8-4f13-96cb-272271bc122c", new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "beky@yahoo.com", true, "bekyFirstName", 1, "bekyLastName", false, null, "BEKY@YAHOO.COM", "BEKY@YAHOO.COM", "AQAAAAEAACcQAAAAEMZymqrfPfE12f89R7Tt0QQVCQk31n3iKOwNxGh1dB2U7Ns5aMcIaZdB4ggtREbGRw==", "00000000000", false, "AD1 2MN", "6ab79e09-01a2-4f54-bfef-f593a508bb92", 0, "bekyTown", false, "beky@yahoo.com" },
                    { "b70dbb4b-a9ff-49d6-8bb4-508e78f658d3", 0, "1 alice Road", "alice Area", "4c6aef58-3071-4a66-afcb-eb321c9ae9e7", new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@yahoo.com", true, "aliceFirstName", 1, "aliceLastName", false, null, "ALICE@YAHOO.COM", "ALICE@YAHOO.COM", "AQAAAAEAACcQAAAAEAfYhstFgQTnRgRa1P7LMngapoHA0ZrDeIDFR0GLOS+jMQ8W/mCCyscyDsQMsCOLKw==", "00000000000", false, "AD1 2MN", "934f2cc4-488b-44fc-b5b4-69a222bff8fe", 0, "aliceTown", false, "alice@yahoo.com" },
                    { "e652e007-6ce7-4234-b72e-af8bf5f09e93", 0, "1 seba Road", "seba Area", "d09f5303-4849-4122-b92c-bccaf4ffb67a", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seba@yahoo.com", true, "sebaFirstName", 1, "sebaLastName", false, null, "SEBA@YAHOO.COM", "SEBA@YAHOO.COM", "AQAAAAEAACcQAAAAEBlXYJlX3426FrBUooTBrqZWeWiAZPBOO13KQAyOBHfU997tqy2nKPVe+kkkEaFdRQ==", "00000000000", false, "AD1 2MN", "c4e0f17a-c8fe-4032-97b2-a8b620d3a8a6", 0, "sebaTown", false, "seba@yahoo.com" },
                    { "dbe94e74-5203-456f-adcd-f7545da15481", 0, "1 john Road", "john Area", "13bff1bb-c702-4348-8c7b-84c0567d4850", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@yahoo.com", true, "johnFirstName", 0, "johnLastName", false, null, "JOHN@YAHOO.COM", "JOHN@YAHOO.COM", "AQAAAAEAACcQAAAAEP0hKfS3qyVzz9Qpf3Oc/yLyx9rgm/VFvh1WzFk7jP38rSF6hCZeezTSEJcg65si9A==", "00000000000", false, "AD1 2MN", "b960c8f0-1989-47bf-b90a-951a5c1c95f0", 0, "johnTown", false, "john@yahoo.com" },
                    { "58c91f33-4d85-4ef7-8c43-86d4123add0c", 0, "1 tom Road", "tom Area", "68989f5e-32d6-424a-9921-5fc3fce52163", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tom@yahoo.com", true, "tomFirstName", 0, "tomLastName", false, null, "TOM@YAHOO.COM", "TOM@YAHOO.COM", "AQAAAAEAACcQAAAAENz/5xVAM1QLaenkCX4z3+6KqliIC3zXuMEFfDePmYi0cB2v/yPFtaprB2qh+gXNHg==", "00000000000", false, "AD1 2MN", "6adb239a-13ec-44cf-a8c8-0a2af050b9d2", 0, "tomTown", false, "tom@yahoo.com" },
                    { "753a18b8-e312-4761-b249-73fce0add698", 0, "1 jack Road", "jack Area", "b5007b00-6e83-401c-966e-aceaa556026f", new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack@yahoo.com", true, "jackFirstName", 0, "jackLastName", false, null, "JACK@YAHOO.COM", "JACK@YAHOO.COM", "AQAAAAEAACcQAAAAEONakR7gdRJn3QJ2kGrfv36vFv8ixjs9MLldX+1gSgJZFvcOy/9yVf2kUngQk+1bSw==", "00000000000", false, "AD1 2MN", "b2d0f823-e375-471e-9ad0-ea46854f547d", 0, "jackTown", false, "jack@yahoo.com" },
                    { "afda1649-0e87-4b7d-9ebd-2a1f01b7b1f8", 0, "1 jam Road", "jam Area", "ba302a8b-5a94-435f-b435-2761c36cfbcd", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jam@yahoo.com", true, "jamFirstName", 0, "jamLastName", false, null, "JAM@YAHOO.COM", "JAM@YAHOO.COM", "AQAAAAEAACcQAAAAEDQ7fkJn8J3MVBS+IgzkZwrmEVDDjl+ywvGxnlq9yOZEIwRaYYylhta90HvCdSSWQw==", "00000000000", false, "AD1 2MN", "fa1e1164-3340-4070-8664-0f66f0a1ba1d", 0, "jamTown", false, "jam@yahoo.com" },
                    { "e61e44bd-cadf-4509-a133-cb5d3e6c4841", 0, "1 mark Road", "mark Area", "5b061821-b402-4b5f-8f7d-57c4ccf5a653", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark@yahoo.com", true, "markFirstName", 0, "markLastName", false, null, "MARK@YAHOO.COM", "MARK@YAHOO.COM", "AQAAAAEAACcQAAAAEHl6e/2v1rygN2/N5bqBr8ZE9JgQLhQYJuCOuoJFWCxkcJSzD4urYUU7g0WzeJdMvg==", "00000000000", false, "AD1 2MN", "fa287936-dfa6-4848-b7ba-06507acf146b", 0, "markTown", false, "mark@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "AddressLineOne", "AddressLineTwo", "Email", "GymName", "Postcode", "Telephone", "Town" },
                values: new object[] { 1, "33 Oak road", "Erdon", "thegymbirmingham@yahoo.com", "The Gym", "B20 1EZ", "07739983984", "Birmingham" });

            migrationBuilder.InsertData(
                table: "MembershipDeals",
                columns: new[] { "Id", "Duration", "Price" },
                values: new object[,]
                {
                    { 1, 1, 10m },
                    { 2, 3, 20m },
                    { 3, 7, 100m },
                    { 4, 8, 160m }
                });

            migrationBuilder.InsertData(
                table: "OpenHours",
                columns: new[] { "Id", "CloseTime", "Date", "DayName", "Note", "OpenTime" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 22, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new TimeSpan(0, 6, 0, 0, 0) },
                    { 2, new TimeSpan(0, 22, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new TimeSpan(0, 6, 0, 0, 0) },
                    { 3, new TimeSpan(0, 22, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, new TimeSpan(0, 6, 0, 0, 0) },
                    { 4, new TimeSpan(0, 22, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, new TimeSpan(0, 6, 0, 0, 0) },
                    { 5, new TimeSpan(0, 22, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, new TimeSpan(0, 6, 0, 0, 0) },
                    { 6, new TimeSpan(0, 20, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, new TimeSpan(0, 20, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "ManageBusiness", "True", "210b86ac-4cf9-4622-b036-63538527cf2e" },
                    { 2, "ManageRoles", "True", "210b86ac-4cf9-4622-b036-63538527cf2e" },
                    { 3, "ManageUsers", "True", "210b86ac-4cf9-4622-b036-63538527cf2e" },
                    { 4, "IssueBans", "True", "210b86ac-4cf9-4622-b036-63538527cf2e" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 10, "DateOfBirth", "01/01/1984", "753a18b8-e312-4761-b249-73fce0add698" },
                    { 9, "DateOfBirth", "01/01/1993", "58c91f33-4d85-4ef7-8c43-86d4123add0c" },
                    { 8, "DateOfBirth", "01/01/1994", "dbe94e74-5203-456f-adcd-f7545da15481" },
                    { 7, "DateOfBirth", "01/01/1970", "e652e007-6ce7-4234-b72e-af8bf5f09e93" },
                    { 6, "DateOfBirth", "01/01/1960", "b70dbb4b-a9ff-49d6-8bb4-508e78f658d3" },
                    { 4, "DateOfBirth", "01/01/2000", "0626cffb-c5c4-4be2-8ea9-cb90fd168f71" },
                    { 11, "DateOfBirth", "01/01/1982", "afda1649-0e87-4b7d-9ebd-2a1f01b7b1f8" },
                    { 3, "MembershipExpiry", "31/12/9999", "18500ac7-d4d4-48e3-ae25-73472024b0bf" },
                    { 2, "Employee", "01/01/2020", "18500ac7-d4d4-48e3-ae25-73472024b0bf" },
                    { 1, "DateOfBirth", "01/01/2000", "18500ac7-d4d4-48e3-ae25-73472024b0bf" },
                    { 5, "DateOfBirth", "01/01/1950", "87a8cfe3-48d7-4b8c-b476-54464c0177ad" },
                    { 12, "DateOfBirth", "01/01/2010", "e61e44bd-cadf-4509-a133-cb5d3e6c4841" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "18500ac7-d4d4-48e3-ae25-73472024b0bf", "210b86ac-4cf9-4622-b036-63538527cf2e" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecord_UserId",
                table: "AttendanceRecord",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipDeals_Duration",
                table: "MembershipDeals",
                column: "Duration",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AttendanceRecord");

            migrationBuilder.DropTable(
                name: "FreePasses");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropTable(
                name: "MembershipDeals");

            migrationBuilder.DropTable(
                name: "OpenHours");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
