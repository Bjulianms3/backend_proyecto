using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tw.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Videojuego",
                columns: table => new
                {
                    VideojuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videojuego", x => x.VideojuegoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriaVideojuego",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    VideojuegosVideojuegoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaVideojuego", x => new { x.CategoriasCategoriaId, x.VideojuegosVideojuegoId });
                    table.ForeignKey(
                        name: "FK_CategoriaVideojuego_Categoria_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaVideojuego_Videojuego_VideojuegosVideojuegoId",
                        column: x => x.VideojuegosVideojuegoId,
                        principalTable: "Videojuego",
                        principalColumn: "VideojuegoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48dfad57-b484-46f3-a0af-7ffab24448aa", null, "Administrador", "ADMINISTRADOR" },
                    { "9ef73af5-94ff-41b9-9c4f-d5bf0b20b61d", null, "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6a893ddd-709d-4fc3-9873-0acc4b0d1994", 0, "dcec328b-2616-4b03-a811-9e8e576c7b20", "zS20018182@estudiantes.uv.mx", false, false, null, "Bernardo julian marin sanchez", "ZS20018182@ESTUDIANTES.UV.MX", "ZS20018182@ESTUDIANTES.UV.MX", "AQAAAAIAAYagAAAAEHgSEUlxgaaMWQrmSSqzCEUtmvLjkgU4jGNTrM158wspILxKIXMI5aZvrli1nM+v/g==", null, false, true, "0dd0b866-29bc-49c2-8e3a-cc3e49321d72", false, "zS20018182@estudiantes.uv.mx" },
                    { "da65c0e2-c3de-4225-9007-b1f7947e99d5", 0, "f83f6da6-65a9-4193-9de2-77571898e8e7", "bernardojulianmarinsanchez0@gmail.com", false, false, null, "usuario juli", "BERNARDOJULIANMARINSANCHEZ0@GMAIL.COM", "BERNARDOJULIANMARINSANCHEZ0@GMAIL.COM", "AQAAAAIAAYagAAAAELzJ1ucdl2q/+a3tFW6ys7meHVlJffU6AXLB3GUWNg0+ogUHf+eJIQxq0mQVeyXs7A==", null, false, false, "e2c51297-60ac-4a90-bfad-13d9352fc4be", false, "bernardojulianmarinsanchez0@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Nombre", "Protegida" },
                values: new object[,]
                {
                    { 1, "Disparos", true },
                    { 2, "Aventura", true },
                    { 3, "Deportes", true },
                    { 4, "Terror", true },
                    { 5, "Peleas", true }
                });

            migrationBuilder.InsertData(
                table: "Videojuego",
                columns: new[] { "VideojuegoId", "Anio", "Descripcion", "Poster", "Titulo" },
                values: new object[,]
                {
                    { 1, 2017, "La trama comienza con el personaje principal, el Guardian, que es un miembro de la Alianza de los Guardianes, una organización que protege la Tierra y el universo de la amenaza del Imperio de los Caballeros de la Luz.", "https://m.media-amazon.com/images/I/71mJCznfFcL._AC_SX569_.jpg", "Destinity 2" },
                    { 2, 2021, "En esta nueva entrega, el jefe Maestro, el gran héroe de la humanidad y personaje principal de la saga, se enfrentará a un grupo sanguinario y temible conocido como los Desterrados", "https://m.media-amazon.com/images/I/81nWynmiDPL._AC_SL1500_.jpg", "Halo infinite" },
                    { 3, 2023, "El juego se centra en partidas por equipos en mapas con un entorno destructible, donde se anima a los jugadores a utilizar el entorno dinámico a su favor", "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/2073850/header.jpg?t=1714660383", "The Finals" },
                    { 4, 2020, " es un shooter en primera persona frenético y ultraviolento, inspirado en los mejores FPS de los 90 tanto en el apartado artístico como en cuanto a mecánicas. Su mantra: la humanidad está muerta, la sangre es combustible, el infierno está lleno.", "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1229490/header.jpg?t=1704406135", "Ultrakill" },
                    { 5, 2016, "Overwatch 2 es un juego de acción en equipo gratuito ambientado en un futuro optimista en el que todas las partidas presentan una refriega definitiva 5c5. Juega como una luchadora por la libertad que salta en el tiempo, ", "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/2357570/header.jpg?t=1715731747", "Overwatch 2" },
                    { 6, 2014, "El combate en Black Desert Online se basa en la acción, requiriendo puntería manual similar a aquellos encontrados en videojuegos de disparos en tercera persona. Las habilidades pueden activarse a través de uso de combos para atacar, esquivando o bloqueando.", "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/582660/header.jpg?t=1715716651", "Black Desert online" },
                    { 7, 2023, "Su trama por lo general describe las heroicas aventuras del joven guerrero Link, que debe enfrentarse a peligros y resolver acertijos para ayudar a la Princesa Zelda a derrotar a Ganondorf y salvar su hogar, el reino de Hyrule.", "https://m.media-amazon.com/images/I/71glcphYY0L.__AC_SX300_SY300_QL70_ML2_.jpg", "The Legend of zelda" },
                    { 8, 2022, ". La historia sigue al personaje del jugador, un Sinluz, que es un miembro de un grupo de exiliados que han sido convocados de vuelta a las Tierras Intermedias después de la Guerra de la Devastación.", "https://m.media-amazon.com/images/I/71GPiuyNtkL.__AC_SX300_SY300_QL70_ML2_.jpg", "Elden ring" },
                    { 9, 2015, "La historia principal tiene lugar en el año 2287, 10 años después de los eventos de Fallout 3 y 210 años después de La Gran Guerra, que causó devastación nuclear catastrófica. ", "https://m.media-amazon.com/images/I/812nlgWkM6L.__AC_SX300_SY300_QL70_ML2_.jpg", "Fallout 4" },
                    { 10, 2021, "Forza Horizon 5 es un videojuego de carreras multijugador en línea desarrollado por Playground Games y publicado por Xbox Game Studios. Es el quinto título de Forza Horizon", "https://m.media-amazon.com/images/I/71xPkgvw11L.__AC_SX300_SY300_QL70_ML2_.jpg", "Forza Horizon 5" },
                    { 11, 2022, "es un videojuego de simulación de carreras de 2022 desarrollado por Polyphony Digital y publicado por Sony Interactive Entertainment. El juego es la octava entrega principal de la serie Gran Turismo", "https://m.media-amazon.com/images/I/81MdKU3FomL._AC_SX679_.jpg", "Gran Turismo 7" },
                    { 12, 2014, "es un videojuego de carreras de simulación desarrollado por Kunos Simulazioni. Está diseñado con énfasis en una experiencia de carreras realista con soporte para una amplia personalización y modificación. ", "https://m.media-amazon.com/images/I/81A6KBrJBvL._AC_SX342_.jpg", "Assetto corsa" },
                    { 13, 2019, "Need for Speed Heat es juego de carreras ambientado en un entorno mundo abierto llamado Palm City, una versión ficticia de la ciudad de Miami, Florida.", "https://m.media-amazon.com/images/I/71epK-pP+9L._AC_SX385_.jpg", "Need for Speed heat" },
                    { 14, 2015, "es un videojuego de lucha desarrollado por Bandai Namco Studios y Arika y publicado por Bandai Namco Entertainment. El juego se lanzó para PlayStation 5, Windows y Xbox Series X/S el 26 de enero de 2024", "https://m.media-amazon.com/images/I/71N8vrjkr+L._AC_SX342_.jpg", "Resident Evil 4" },
                    { 15, 2014, "Alien: Isolation es un videojuego de terror tipo horror de supervivencia y sigilo en primera persona", "https://m.media-amazon.com/images/I/81IIuRXbjoL._AC_SX569_.jpg", "Alien Isolation" },
                    { 16, 2014, "La historia sigue a Joel, un superviviente cansado y desesperado que ha perdido a su hija, y a Ellie, una joven de 14 años que ha sido infectada por el virus", "https://m.media-amazon.com/images/I/71Ku7i1sXUL._AC_SX385_.jpg", "The Last Of us" },
                    { 17, 2023, "En Lethal Company, los jugadores obtienen y venden chatarra de exomoons abandonados e industrializados mientras evitan las trampas, los peligros ambientales y los monstruos", "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1966720/header.jpg?t=1700231592", "Lethal Company" },
                    { 18, 1994, "La trama del juego se centra en la situación que se ha dado tras la aparición en la anterior entrega del misterioso personaje Verse, cuyos poderes han llevado al regreso de muchos luchadores que habían muerto o desaparecido en el pasado.", "https://m.media-amazon.com/images/I/81+PxnVvDeL._AC_SX569_.jpg", "The king of Fighers XV" },
                    { 19, 2023, "Street Fighter 6 presenta tres modos de juego generales: Fighting Ground, World Tour y Battle Hub. Fighting Ground contiene batallas versus locales y en línea, así como modos de entrenamiento y arcade", "https://m.media-amazon.com/images/I/91t8mF84tEL._AC_SX522_.jpg", "Street Fighter 6" },
                    { 20, 2018, "Como todos los juegos de Soulcalibur anteriores a esta entrega, las peleas de Soulcalibur VI tienen lugar en un ambiente tridimensional, donde los luchadores se enfrentan con varios tipos de armas.", "https://m.media-amazon.com/images/I/712tzVpRppL._AC_SX569_.jpg", "Soulcalibur 6" },
                    { 21, 2024, "es un videojuego de lucha desarrollado por Bandai Namco Studios y Arika y publicado por Bandai Namco Entertainment. El juego se lanzó para PlayStation 5, Windows y Xbox Series X/S el 26 de enero de 2024", "https://m.media-amazon.com/images/I/812ymCiKznL._AC_SX385_.jpg", "Tekken 8" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "48dfad57-b484-46f3-a0af-7ffab24448aa", "6a893ddd-709d-4fc3-9873-0acc4b0d1994" },
                    { "9ef73af5-94ff-41b9-9c4f-d5bf0b20b61d", "da65c0e2-c3de-4225-9007-b1f7947e99d5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaVideojuego_VideojuegosVideojuegoId",
                table: "CategoriaVideojuego",
                column: "VideojuegosVideojuegoId");
        }

        /// <inheritdoc />
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
                name: "CategoriaVideojuego");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Videojuego");
        }
    }
}
