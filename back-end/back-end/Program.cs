using back_end.Contexts;
using back_end.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ChatApplicationDb>();

var app = builder.Build();
var accountEndpoint = app.MapGroup("/account");
var friendEndpoint = app.MapGroup("/friend");

accountEndpoint.MapPost("/", createAccount);
accountEndpoint.MapGet("/", getAccounts);

friendEndpoint.MapPost("/", createFriend);

app.Run();

static async Task<IResult> createFriend(ChatApplicationDb db, Friend friend)
{
    friend.account = await db.Accounts.FindAsync(friend.account);
    db.Friends.Add(friend);
    await db.SaveChangesAsync();
    return TypedResults.Created($"/friend", friend);
}
static async Task<IResult> createAccount(ChatApplicationDb db, Account account)
{
    db.Accounts.Add(account);
    await db.SaveChangesAsync();
    return TypedResults.Created($"/account", account);
}

static async Task<IResult> getAccounts(ChatApplicationDb db)
{
    return TypedResults.Ok(await db.Accounts.ToListAsync());
}
