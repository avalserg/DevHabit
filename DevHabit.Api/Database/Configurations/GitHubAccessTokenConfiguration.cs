﻿using DevHabit.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevHabit.Api.Database.Configurations;

public class GitHubAccessTokenConfiguration : IEntityTypeConfiguration<GitHubAccessToken>
{
    public void Configure(EntityTypeBuilder<GitHubAccessToken> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(h => h.Id).HasMaxLength(500);
        builder.Property(h => h.UserId).HasMaxLength(500);
        builder.Property(h => h.Token).HasMaxLength(1000);

        builder.HasIndex(gh => gh.UserId).IsUnique();

        builder.HasOne<User>()
            .WithOne()
            .HasForeignKey<GitHubAccessToken>(gh => gh.UserId);
    }
}
