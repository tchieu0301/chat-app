using back_end.Contexts;
using back_end.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ChatApplicationDb>();

var app = builder.Build();
var accountEndpoint = app.MapGroup("/account");
accountEndpoint.MapPost("/", createAccount);
accountEndpoint.MapGet("/", getAccounts);

app.Run();

static async Task<IResult> createAccount(ChatApplicationDb db, Account account)
{
    db.Accounts.Add(account);
    await db.SaveChangesAsync();
    return TypedResults.Created($"/user", account);
}

static async Task<IResult> getAccounts(ChatApplicationDb db)
{
    return TypedResults.Ok(await db.Accounts.ToListAsync());
}
