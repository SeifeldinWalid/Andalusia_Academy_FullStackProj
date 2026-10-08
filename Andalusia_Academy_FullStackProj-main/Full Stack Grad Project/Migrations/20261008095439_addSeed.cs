using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Full_Stack_Grad_Project.Migrations
{
    /// <inheritdoc />
    public partial class addSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "CareerPathPrograms",
                keyColumns: new[] { "CareerPathId", "ProgramId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "CareerPathSkills",
                keyColumns: new[] { "CareerPathId", "SkillId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 20, 15 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 22, 12 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 24, 13 });

            migrationBuilder.DeleteData(
                table: "CourseSkills",
                keyColumns: new[] { "CourseId", "SkillId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "ProgramCourses",
                keyColumns: new[] { "CourseId", "ProgramId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CareerPaths",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CareerPaths",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CareerPaths",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CareerPaths",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CareerPaths",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CareerPaths",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CareerPaths",
                columns: new[] { "Id", "Description", "EstimatedMonths", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Build complete web applications, from responsive React front ends to .NET APIs and databases.", 9, "https://picsum.photos/seed/path-fullstack/600/400", "Full-Stack Web Developer" },
                    { 2, "Turn raw data into insights and predictions using Python, SQL and machine learning.", 8, "https://picsum.photos/seed/path-data/600/400", "Data Scientist" },
                    { 3, "Create cross platform mobile apps that run on Android and iOS.", 6, "https://picsum.photos/seed/path-mobile/600/400", "Mobile Developer" },
                    { 4, "Automate, deploy and operate applications at scale in the cloud.", 7, "https://picsum.photos/seed/path-devops/600/400", "Cloud & DevOps Engineer" },
                    { 5, "Design intuitive and accessible digital experiences from research to prototype.", 4, "https://picsum.photos/seed/path-design/600/400", "UI/UX Designer" },
                    { 6, "Protect organizations by finding vulnerabilities and defending systems and networks.", 6, "https://picsum.photos/seed/path-cyber/600/400", "Cybersecurity Analyst" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsPopular", "Name" },
                values: new object[,]
                {
                    { 1, true, "Web Development" },
                    { 2, true, "Data Science & AI" },
                    { 3, true, "Mobile Development" },
                    { 4, false, "Cloud & DevOps" },
                    { 5, false, "Cybersecurity" },
                    { 6, true, "UI/UX Design" }
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://picsum.photos/seed/partner-1/200/100", "Microsoft" },
                    { 2, "https://picsum.photos/seed/partner-2/200/100", "Google Cloud" },
                    { 3, "https://picsum.photos/seed/partner-3/200/100", "AWS Academy" },
                    { 4, "https://picsum.photos/seed/partner-4/200/100", "Cisco Networking Academy" },
                    { 5, "https://picsum.photos/seed/partner-5/200/100", "ITIDA" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Description", "DurationWeeks", "ImageUrl", "Level", "Title" },
                values: new object[,]
                {
                    { 1, "Go from your first HTML page to production ready React applications.", 12, "https://picsum.photos/seed/program-frontend/600/400", "Beginner", "Front-End Web Development" },
                    { 2, "Build secure, data driven REST APIs with C#, ASP.NET Core, SQL Server and EF Core.", 14, "https://picsum.photos/seed/program-backend/600/400", "Intermediate", "Back-End Development with .NET" },
                    { 3, "Collect, clean, analyze and visualize data to answer real business questions.", 10, "https://picsum.photos/seed/program-data/600/400", "Beginner", "Data Analysis Professional" },
                    { 4, "Build, train and evaluate machine learning and deep learning models end to end.", 16, "https://picsum.photos/seed/program-ml/600/400", "Advanced", "Machine Learning Engineer Track" },
                    { 5, "Design and ship cross platform mobile apps for Android and iOS.", 10, "https://picsum.photos/seed/program-mobile/600/400", "Beginner", "Mobile App Development" },
                    { 6, "Automate delivery and run applications reliably in containers and the cloud.", 12, "https://picsum.photos/seed/program-devops/600/400", "Intermediate", "DevOps & Cloud Engineering" },
                    { 7, "Research, design and prototype digital products that users love.", 8, "https://picsum.photos/seed/program-design/600/400", "Beginner", "Product Design (UI/UX)" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HTML & CSS" },
                    { 2, "JavaScript" },
                    { 3, "React" },
                    { 4, "C#" },
                    { 5, "ASP.NET Core" },
                    { 6, "SQL" },
                    { 7, "Python" },
                    { 8, "Machine Learning" },
                    { 9, "Data Visualization" },
                    { 10, "Docker" },
                    { 11, "Microsoft Azure" },
                    { 12, "Network Security" },
                    { 13, "Figma" },
                    { 14, "Flutter" },
                    { 15, "Git" },
                    { 16, "TypeScript" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AuthorName", "AvatarUrl", "Content", "Role" },
                values: new object[,]
                {
                    { 1, "Sara Ahmed", "https://i.pravatar.cc/150?img=47", "The Front-End program took me from zero to my first job in less than a year. The projects were exactly what interviewers asked about.", "Front-End Developer" },
                    { 2, "Omar Khaled", "https://i.pravatar.cc/150?img=12", "Clear explanations, real datasets and great mentors. The Power BI course alone paid for itself.", "Data Analyst" },
                    { 3, "Mariam Hassan", "https://i.pravatar.cc/150?img=45", "I published my first Flutter app on the Play Store while still in the program.", "Mobile Developer" },
                    { 4, "Youssef Ali", "https://i.pravatar.cc/150?img=33", "The ASP.NET Core and EF Core courses are the most practical .NET content I have found.", "Back-End Developer" }
                });

            migrationBuilder.InsertData(
                table: "CareerPathPrograms",
                columns: new[] { "CareerPathId", "ProgramId", "Order" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 2 },
                    { 2, 3, 1 },
                    { 2, 4, 2 },
                    { 3, 5, 1 },
                    { 4, 2, 2 },
                    { 4, 6, 1 },
                    { 5, 1, 2 },
                    { 5, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "CareerPathSkills",
                columns: new[] { "CareerPathId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 15 },
                    { 1, 16 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 14 },
                    { 3, 15 },
                    { 4, 5 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 15 },
                    { 5, 1 },
                    { 5, 13 },
                    { 6, 12 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "DurationHours", "ImageUrl", "IsFeatured", "Level", "Price", "Status", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Build and style your first web pages with semantic HTML, Flexbox, Grid and responsive design.", 12, "https://picsum.photos/seed/html-css/600/400", true, "Beginner", 49m, "Published", "HTML & CSS Fundamentals", "Online" },
                    { 2, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Master variables, functions, arrays, objects, async/await and the DOM using modern JavaScript.", 18, "https://picsum.photos/seed/javascript/600/400", true, "Beginner", 59m, "Published", "Modern JavaScript (ES6+)", "Online" },
                    { 3, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Add static typing to your JavaScript projects with types, interfaces, generics and strict mode.", 10, "https://picsum.photos/seed/typescript/600/400", false, "Intermediate", 49m, "Published", "TypeScript Essentials", "Recorded" },
                    { 4, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Build single page applications with components, hooks, routing and API integration in React.", 24, "https://picsum.photos/seed/react/600/400", true, "Intermediate", 79m, "Published", "React from Zero to Hero", "Online" },
                    { 5, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Learn C# syntax, object oriented programming, collections, LINQ and exception handling.", 20, "https://picsum.photos/seed/csharp/600/400", false, "Beginner", 59m, "Published", "C# Programming Fundamentals", "Online" },
                    { 6, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Design and build clean REST APIs with controllers, dependency injection, validation and Swagger.", 28, "https://picsum.photos/seed/aspnet/600/400", true, "Intermediate", 89m, "Published", "Building REST APIs with ASP.NET Core", "Hybrid" },
                    { 7, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Write SQL queries, design normalized schemas and work with joins, indexes and transactions.", 14, "https://picsum.photos/seed/sql/600/400", false, "Beginner", 49m, "Published", "SQL & Relational Databases", "Online" },
                    { 8, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Map your domain to a database with EF Core: relationships, migrations, queries and performance.", 16, "https://picsum.photos/seed/efcore/600/400", false, "Advanced", 69m, "Published", "Entity Framework Core in Depth", "Recorded" },
                    { 9, 4, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Version control your code, work with branches and pull requests, and collaborate on GitHub.", 6, "https://picsum.photos/seed/git/600/400", false, "Beginner", 0m, "Published", "Git & GitHub for Teams", "Recorded" },
                    { 10, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Start programming with Python: data types, control flow, functions, files and modules.", 16, "https://picsum.photos/seed/python/600/400", true, "Beginner", 49m, "Published", "Python for Everyone", "Online" },
                    { 11, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Clean, transform and analyze real datasets using Pandas and NumPy in Jupyter notebooks.", 20, "https://picsum.photos/seed/pandas/600/400", false, "Intermediate", 69m, "Published", "Data Analysis with Pandas", "Online" },
                    { 12, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Turn data into interactive dashboards and reports that business teams can act on.", 15, "https://picsum.photos/seed/powerbi/600/400", false, "Intermediate", 79m, "Published", "Data Visualization with Power BI", "Onsite" },
                    { 13, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Understand supervised and unsupervised learning and build models with scikit-learn.", 30, "https://picsum.photos/seed/ml/600/400", true, "Intermediate", 99m, "Published", "Machine Learning Foundations", "Online" },
                    { 14, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Build neural networks for computer vision and NLP using PyTorch.", 32, "https://picsum.photos/seed/pytorch/600/400", false, "Advanced", 129m, "ComingSoon", "Deep Learning with PyTorch", "Online" },
                    { 15, 3, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Build beautiful cross platform mobile apps for Android and iOS with Flutter and Dart.", 26, "https://picsum.photos/seed/flutter/600/400", false, "Beginner", 79m, "Published", "Flutter Mobile Apps", "Online" },
                    { 16, 3, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Scale your Flutter apps with Bloc, Riverpod, clean architecture and testing.", 18, "https://picsum.photos/seed/flutter-advanced/600/400", false, "Advanced", 89m, "Published", "Advanced Flutter & State Management", "Recorded" },
                    { 17, 3, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Use your React skills to ship native mobile apps with React Native and Expo.", 14, "https://picsum.photos/seed/react-native/600/400", false, "Intermediate", 69m, "ComingSoon", "React Native Crash Course", "Recorded" },
                    { 18, 4, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Package and run applications in containers with Docker, images, volumes and Compose.", 14, "https://picsum.photos/seed/docker/600/400", false, "Intermediate", 69m, "Published", "Docker & Containers", "Online" },
                    { 19, 4, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Learn core cloud concepts and deploy web apps, databases and storage on Microsoft Azure.", 18, "https://picsum.photos/seed/azure/600/400", false, "Beginner", 79m, "Published", "Azure Cloud Fundamentals", "Hybrid" },
                    { 20, 4, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Automate building, testing and deploying your applications with GitHub Actions.", 10, "https://picsum.photos/seed/cicd/600/400", false, "Intermediate", 59m, "Published", "CI/CD Pipelines with GitHub Actions", "Online" },
                    { 21, 5, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Understand threats, vulnerabilities, encryption and how to protect systems and networks.", 16, "https://picsum.photos/seed/cyber/600/400", false, "Beginner", 59m, "Published", "Cybersecurity Essentials", "Online" },
                    { 22, 5, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Find and exploit vulnerabilities legally using industry tools in hands-on labs.", 36, "https://picsum.photos/seed/ethical-hacking/600/400", false, "Advanced", 149m, "Published", "Ethical Hacking & Penetration Testing", "Onsite" },
                    { 23, 6, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Learn user research, wireframing, visual hierarchy and usability testing.", 12, "https://picsum.photos/seed/uiux/600/400", true, "Beginner", 49m, "Published", "UI/UX Design Principles", "Online" },
                    { 24, 6, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Design interactive prototypes and design systems with components and auto layout in Figma.", 10, "https://picsum.photos/seed/figma/600/400", false, "Intermediate", 59m, "Published", "Prototyping with Figma", "Recorded" },
                    { 25, 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Make your websites usable for everyone by following WCAG guidelines.", 8, "https://picsum.photos/seed/a11y/600/400", false, "Intermediate", 39m, "Draft", "Web Accessibility Basics", "Online" }
                });

            migrationBuilder.InsertData(
                table: "CourseSkills",
                columns: new[] { "CourseId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 3, 16 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 5 },
                    { 8, 6 },
                    { 9, 15 },
                    { 10, 7 },
                    { 11, 7 },
                    { 11, 9 },
                    { 12, 9 },
                    { 13, 7 },
                    { 13, 8 },
                    { 14, 7 },
                    { 14, 8 },
                    { 15, 14 },
                    { 16, 14 },
                    { 17, 2 },
                    { 17, 3 },
                    { 18, 10 },
                    { 19, 11 },
                    { 20, 10 },
                    { 20, 15 },
                    { 21, 12 },
                    { 22, 12 },
                    { 23, 13 },
                    { 24, 13 },
                    { 25, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProgramCourses",
                columns: new[] { "CourseId", "ProgramId", "Order" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 4 },
                    { 4, 1, 5 },
                    { 9, 1, 3 },
                    { 5, 2, 1 },
                    { 6, 2, 4 },
                    { 7, 2, 2 },
                    { 8, 2, 5 },
                    { 9, 2, 3 },
                    { 7, 3, 2 },
                    { 10, 3, 1 },
                    { 11, 3, 3 },
                    { 12, 3, 4 },
                    { 10, 4, 1 },
                    { 11, 4, 2 },
                    { 13, 4, 3 },
                    { 14, 4, 4 },
                    { 2, 5, 1 },
                    { 15, 5, 2 },
                    { 16, 5, 3 },
                    { 17, 5, 4 },
                    { 9, 6, 1 },
                    { 18, 6, 2 },
                    { 19, 6, 3 },
                    { 20, 6, 4 },
                    { 1, 7, 3 },
                    { 23, 7, 1 },
                    { 24, 7, 2 }
                });
        }
    }
}
