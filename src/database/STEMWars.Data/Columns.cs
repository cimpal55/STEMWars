using System.Data;

namespace STEMWars.Data
{
    public class Columns
    {
        public static class Country
        {
            public const string Id = "Id";
            public const string Name = "Name";
            public const string Code = "Code";
        }
        public static class User
        {
            public const string Id = "Id";
            public const string RoleId = "Role";
            public const string Email = "Email";
            public const string PasswordHash = "PasswordHash";
            public const string PasswordSalt = "PasswordSalt";
            public const string Rating = "Rating";
            public const string Role = "Role";
            public const string Created = "Created";
        }
        public static class Address
        {
            public const string Id = "Id";
            public const string UserId = "UserId";
            public const string CountryId = "CountryId";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string Street = "Street";
            public const string City = "City";
            public const string State = "State";
            public const string Zip = "Zip";
            public const string Created = "Created";
        }

        public static class Room
        {
            public const string Id = "Id";
            public const string Name = "Name";
            public const string Capacity = "Capacity";
            public const string IsActive = "IsActive";
            public const string Created = "Created";
        }

        public static class User_in_room
        {
            public const string UserId = "UserId";
            public const string RoomId = "RoomId";
            public const string Score = "Score";
        }
        public static class User_question_history
        {
            public const string UserId = "UserId";
            public const string RoomId = "RoomId";
            public const string QuestionId = "QuestionId";
            public const string Score = "Score";
        }

        public static class User_answer_history
        {
            public const string UserId = "UserId";
            public const string RoomId = "RoomId";
            public const string QuestionId = "QuestionId";
            public const string AnswerId = "AnswerId";
        }

        public static class Answer
        {
            public const string Id = "Id";
            public const string QuestionId = "QuestionId";
            public const string Text = "Text";
            public const string IsCorrect = "IsCorrect";
        }
        public static class Topic
        {
            public const string Id = "Id";
            public const string Name = "Name";
        }

        public static class QuestionOptions
        {
            public const string QuestionId = "FirstOption";
            public const string Option = "Option";
            public const string IsAnswer = "IsAnswer";
        }
        public static class Question
        {
            public const string Id = "Id";
            public const string TopicId = "TopicId";
            public const string Type = "Type";
            public const string Difficulty = "Difficulty";
        }

    }
}