﻿namespace SalesProject.Domain.Models;

public class Admin
{
    public Admin(string name, string email, string passwordHash, string role)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
}