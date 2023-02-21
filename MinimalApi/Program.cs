using MinimalApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () =>
{
    return "Hello world";

});
app.MapPost("/", ( Book book) =>
{
    return Results.Ok(book);
});
app.MapPut("/",()=>
{
    return Results.Ok("PutAction Method");
});
app.MapDelete("/", () =>
{
    return Results.Ok("Delete Action");
});
app.Run();