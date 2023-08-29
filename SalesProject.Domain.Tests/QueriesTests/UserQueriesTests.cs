using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using System.Linq;

namespace SalesProject.Domain.Tests.QueriesTests;

public class UserQueriesTests
{
    private readonly List<User> _users;
    private readonly List<string> _invalidEmails;
    public UserQueriesTests()
    {
        Role _userRole = new("User", "user");
        Role _adminRole = new("Admin", "admin");
        _users = new List<User>
        {
            new("Andre Baltieri", "balta@balta.io", "00000000000", "FSDA09yh87n-0I", _userRole.Id),
            new("David Malan", "david@havard.com", "11111111111", "S09U8SNU800-0", _userRole.Id),
            new("Igor", "teste@email.com", "22222222222", "9Y8DSA-fsu09", _adminRole.Id),
            new("Igor", "email@email.com", "33333333333", "FDSG67H-fsu09", _adminRole.Id)
        };
        _invalidEmails = new List<string>
        {
            "invalidemail",
            "withoutatsymbol.com",
            "email with spaces@teste.com"
        };

    }

    [Fact]
    public void Should_Return_User_When_Id_Is_Valid()
    {
        var id = _users[0].Id;

        var result = _users.AsQueryable().Where(UserQueries.GetById(id));
        Assert.Equal(1, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Id_Is_Invalid()
    {
        Guid? invalidId = null;

        var result = _users.AsQueryable().Where(UserQueries.GetById(invalidId.GetValueOrDefault()));
        Assert.Empty(result);
    }

    [Fact]
    public void Should_Return_All_Users_With_Given_Name()
    {
        var result = _users.AsQueryable().Where(UserQueries.GetByName("Igor"));
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Name_Is_Not_Registered()
    {
        var result = _users.AsQueryable().Where(UserQueries.GetByName("Balta"));
        Assert.Empty(result);
    }

    [Fact]
    public void Should_Return_All_Users_With_Given_Email()
    {
        var result = _users.AsQueryable().Where(UserQueries.GetByEmail("balta@balta.io"));
        Assert.Equal(1, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Email_Is_Invalid()
    {
        foreach(var email in _invalidEmails)
        {
            var result = _users.AsQueryable().Where(UserQueries.GetByEmail(email));
            Assert.Empty(result);
        }
    }
}
