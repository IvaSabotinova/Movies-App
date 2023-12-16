namespace MoviesWebApi.Data
{
    public static class Constants
    {
        public const string AdministratorRoleName = "Administrator";

        public const string UserRoleName = "User";

        public const int GenreNameMinLength = 2;

        public const int GenreNameMaxLength = 30;

        public const int MovieTitleMinLength = 2;

        public const int MovieTitleMaxLength = 260;

        public const int MovieDescriptionMinLength = 10;

        public const int MovieDescriptionMaxLength = 1000;

        public const string ImageUrlRegex = "^https:\\/\\/.+$";

        public const string ImageDataRequiredErrorMessage = "Image data is required.";

        public const string ImageMIMETypeRequiredErrorMessage = "Image MIME type is required.";

    }
}
