using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ErfanLearn.DataLayer.Migrations
{
    public partial class AddFileMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_courseGroups_GroupId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseLevel_LevelId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseStatus_StatusId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_courseGroups_SubGroup",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Users_TeacherId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEpisode_Course_CourseId",
                table: "CourseEpisode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseEpisode",
                table: "CourseEpisode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "CourseEpisode",
                newName: "CourseEpisodes");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEpisode_CourseId",
                table: "CourseEpisodes",
                newName: "IX_CourseEpisodes_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_TeacherId",
                table: "Courses",
                newName: "IX_Courses_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_SubGroup",
                table: "Courses",
                newName: "IX_Courses_SubGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Course_StatusId",
                table: "Courses",
                newName: "IX_Courses_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_LevelId",
                table: "Courses",
                newName: "IX_Courses_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_GroupId",
                table: "Courses",
                newName: "IX_Courses_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseEpisodes",
                table: "CourseEpisodes",
                column: "EpisodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(nullable: false),
                    FileData = table.Column<byte[]>(nullable: false),
                    FileExtension = table.Column<string>(nullable: false),
                    FileContent = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEpisodes_Courses_CourseId",
                table: "CourseEpisodes",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_courseGroups_GroupId",
                table: "Courses",
                column: "GroupId",
                principalTable: "courseGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseLevel_LevelId",
                table: "Courses",
                column: "LevelId",
                principalTable: "CourseLevel",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseStatus_StatusId",
                table: "Courses",
                column: "StatusId",
                principalTable: "CourseStatus",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_courseGroups_SubGroup",
                table: "Courses",
                column: "SubGroup",
                principalTable: "courseGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseEpisodes_Courses_CourseId",
                table: "CourseEpisodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_courseGroups_GroupId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseLevel_LevelId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseStatus_StatusId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_courseGroups_SubGroup",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_TeacherId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseEpisodes",
                table: "CourseEpisodes");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "CourseEpisodes",
                newName: "CourseEpisode");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherId",
                table: "Course",
                newName: "IX_Course_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_SubGroup",
                table: "Course",
                newName: "IX_Course_SubGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_StatusId",
                table: "Course",
                newName: "IX_Course_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_LevelId",
                table: "Course",
                newName: "IX_Course_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_GroupId",
                table: "Course",
                newName: "IX_Course_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEpisodes_CourseId",
                table: "CourseEpisode",
                newName: "IX_CourseEpisode_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseEpisode",
                table: "CourseEpisode",
                column: "EpisodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_courseGroups_GroupId",
                table: "Course",
                column: "GroupId",
                principalTable: "courseGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseLevel_LevelId",
                table: "Course",
                column: "LevelId",
                principalTable: "CourseLevel",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseStatus_StatusId",
                table: "Course",
                column: "StatusId",
                principalTable: "CourseStatus",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_courseGroups_SubGroup",
                table: "Course",
                column: "SubGroup",
                principalTable: "courseGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Users_TeacherId",
                table: "Course",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEpisode_Course_CourseId",
                table: "CourseEpisode",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
