namespace vidz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0ad1a3f7-fb71-4f27-a0c5-3edd2253849d', N'admin@vidz.com', 0, N'AOnZlj2nj5p08TWwXRglIbfam2NZlkCCgeV7g7kufmY4vWPr9FZQ6Bu2w5Q8vY4oNA==', N'8ec66ae5-c50e-4e1e-8f10-78376f78941f', NULL, 0, 0, NULL, 1, 0, N'admin@vidz.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bcca6040-bae9-418f-a8c3-4082ac7cf7ca', N'guest@vidz.com', 0, N'AM8Tx8Fe0rqSbgK0RGYSlfNHnAG1ON5Ob9/kTghgwwNmDxQOhBDsx2hweApCXdr8cA==', N'137578c9-0125-4e1a-b5ca-329ec0a0d5e9', NULL, 0, 0, NULL, 1, 0, N'guest@vidz.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aae373a7-73dd-48c2-b753-3da9605ff15c', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0ad1a3f7-fb71-4f27-a0c5-3edd2253849d', N'aae373a7-73dd-48c2-b753-3da9605ff15c')
            ");
        }

        public override void Down()
        {
        }
    }
}
