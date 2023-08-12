using back_end.Contexts;
using back_end.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ChatApplicationDb>();
var app = builder.Build();
app.MapPost("/user",CreateAccount);

app.Run();

static async Task<IResult> CreateAccount(ChatApplicationDb db, Account account)
{
    db.Accounts.Add(account);
    await db.SaveChangesAsync();
    return TypedResults.Created($"/user", account);
}
