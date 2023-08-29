using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;

namespace SalesProject.Domain.Tests.QueriesTests;

public class RoleQueriesTests
{
    private readonly List<Role> _roles;
    public RoleQueriesTests()
    {
        _roles = new List<Role>
        {
            new("User", "user"),
            new("Admin", "admin"),
            new("Employee", "employee"),
            new("User", "user")
        };
    }

    [Fact]
    public void Should_Return_Role_When_Id_Is_Valid()
    {
        var id = _roles[0].Id;

        var result = _roles.AsQueryable().Where(RoleQueries.GetById(id));
        Assert.Equal(1, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Id_Is_Invalid()
    {
        Guid? invalidId = null;

        var result = _roles.AsQueryable().Where(RoleQueries.GetById(invalidId.GetValueOrDefault()));
        Assert.Equal(0, result.Count());
    }

    [Fact]
    public void Should_Return_All_Roles_With_Given_Name()
    {
        var result = _roles.AsQueryable().Where(RoleQueries.GetByName("User"));
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Name_Is_Not_Registered()
    {
        var result = _roles.AsQueryable().Where(RoleQueries.GetByName("Usuario"));
        Assert.Empty(result);
    }

    [Fact]
    public void Should_Return_All_Roles_With_Given_Slug()
    {
        var result = _roles.AsQueryable().Where(RoleQueries.GetBySlug("admin"));
        Assert.Equal(1, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Slug_Is_Not_Registered()
    {
        var result = _roles.AsQueryable().Where(RoleQueries.GetBySlug("administrador"));
        Assert.Empty(result);
    }
}
