using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddedMessage = "Added!";
        public static string DeletedMessage = "Deleted!";
        public static string UpdatedMessage = "Updated!";
        public static string CarNameInvalid = "The car name invalid";
        public static string MaintenanceTime = "System is under maintenance";
        public static string CarRentalInvalid = "The car is already rented";

        public static string UserNotFound = "This user not found";

        public static string PasswordIncorrect { get; internal set; }
        public static User SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExist { get; internal set; }
        public static string UserRegistered { get; internal set; }
    }
}
