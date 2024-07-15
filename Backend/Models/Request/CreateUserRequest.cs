﻿namespace Backend.Models.Request
{
    public class CreateUserRequest
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public CreateUserRequest()
        {
        }
    }
}
