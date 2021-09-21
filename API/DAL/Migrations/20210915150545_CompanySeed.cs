﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class CompanySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Digitube', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Cogibox', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Flashspan', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Teklist', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Zoonoodle', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Mydo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Bubbletube', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Oyope', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Innotype', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Realblab', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Feedfire', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Shufflester', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Omba', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Skinder', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Edgeclub', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Camimbo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Roodel', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Voomm', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Twitterbridge', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Eadel', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Voomm', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Zoovu', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Zazio', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Jayo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Dynazzy', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('BlogXS', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Dazzlesphere', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Gabtune', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Fatz', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Meembee', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Wordtune', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Tazz', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Topiczoom', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Quinu', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Muxo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Feedmix', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Voolith', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Youbridge', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Thoughtsphere', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Realblab', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Minyx', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Aimbo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Zoombeat', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Gabvine', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Plambee', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Eazzy', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Browsebug', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Linkbuzz', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Tavu', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Einti', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Skyba', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Dynabox', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Mynte', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Pixope', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Kare', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Twitterbridge', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Blogtag', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Yadel', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Livepath', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Edgeify', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Yoveo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Cogilith', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Meevee', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Aimbo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Topdrive', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Flashspan', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Eimbee', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Rhynoodle', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Snaptags', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Yadel', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Omba', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Muxo', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Edgeclub', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('LiveZ', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Browsecat', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Babbleopia', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('LiveZ', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Tazz', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Twitterworks', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Thoughtmix', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Skipfire', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Zoomdog', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Flashset', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Zoovu', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Skipfire', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Twimm', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Thoughtworks', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Jatri', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Buzzster', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Blognation', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Reallinks', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Teklist', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Realcube', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Kazu', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Eare', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Eazzy', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Skivee', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Gabvine', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Oyondu', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 1);");
            migrationBuilder.Sql(" insert into Companies(Name, Guid, CreatedAt, UpdatedAt, Active) values('Voomm', '" + Guid.NewGuid() + "', '" + DateTime.UtcNow + "', '" + DateTime.UtcNow + "', 0);");
        }
    }
}
