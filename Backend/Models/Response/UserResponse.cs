﻿namespace Backend.Models.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public UserResponse()
        {
        }
    }
}
