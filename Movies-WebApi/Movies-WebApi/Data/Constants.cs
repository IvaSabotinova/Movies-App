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

        public const string ImageDataRequiredErrorMessage = "Image data is required.";

        public const string ImageMIMETypeRequiredErrorMessage = "Image MIME type is required.";

        public const string MovieDoesNotExist = "Movie does not exist!";

        public const int UsernameMaxLength = 30;

        public const int UsernameMinLength = 3;

        public const string UsernameErrorMessage = "Username is required!";

        public const int EmailMaxLenght = 330;

        public const int EmailMinLength = 5;

        public const string EmailErrorMessage = "The Email is required.";

        public const int PasswordMaxLength = 30;

        public const int PasswordMinLength = 6;

        public const string InvalidState = "Validation error(s) ocurred. Please check all input fields!";

        public const string RegisterError = "Error while registering!";

        public const string LoginError = "Username or password is incorrect!";

        public const string UserNotFound = "User not found!";

        public const string UserMovieNotExits = "User and/or movie not found!";

    }
}
