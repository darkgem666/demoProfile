﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using com.profillingTool.models;

namespace DemoProfiling.Migrations
{
    [DbContext(typeof(ProfileContext))]
    partial class ProfileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("com.profillingTool.models.Profile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("center");

                    b.Property<string>("description");

                    b.Property<int>("jobcode");

                    b.Property<string>("profileName");

                    b.HasKey("id");

                    b.ToTable("Profile");
                });
        }
    }
}
