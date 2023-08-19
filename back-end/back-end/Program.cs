using back_end.Contexts;
using back_end.Entities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ChatApplicationDb>();

var app = builder.Build();
var accountEndpoint = app.MapGroup("/account");

accountEndpoint.MapPost("/", createAccount);
accountEndpoint.MapPost("/login", validateAccount);



app.Run();

static async Task<IResult> validateAccount(ChatApplicationDb db, Account account)
{
    var accountData = await db.Accounts.Where(x => x.username == account.username).FirstOrDefaultAsync();
    if (accountData == null)
    {
        return TypedResults.NotFound(new { message = "Not Found" });
    }
    return TypedResults.Ok(new { message = "login success", accountData });
}

static async Task<IResult> createAccount(ChatApplicationDb db, Account account)
{
    if(account.username == null && account.password == null 
        && account.firstname==null && account.lastname==null && account.email == null)
    {
        db.Accounts.Add(account);
        await db.SaveChangesAsync();
        return TypedResults.Created($"/account", new {message = "create account success", account });
    }
    return TypedResults.BadRequest(new { message = "missing fields" });
}

