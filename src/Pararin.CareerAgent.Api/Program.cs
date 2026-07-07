using Pararin.CareerAgent.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Pararin AI-Agent");

app.MapGet("/Person/{firstname}", (string firstName) =>
{
    return firstName;
    //JobPosting jobPosting = new JobPosting();
    //jobPosting.Description = "...";
});

app.Run();

#region .:| Draft |:.

//app.MapPost("/Person/Add", async (HttpContext context, MyClass mc) =>
//{
//    //MyClass student = await context.Request.ReadFromJsonAsync<MyClass>() ?? default!;
//    //return mc.id * 524;

//    try
//    {
//        MyClass student = await context.Request.ReadFromJsonAsync<MyClass>() ?? default!;
//        return Results.Ok(mc.id * 524);
//    }
//    catch (Exception ex)
//    {
//        return Results.BadRequest(ex.Message);
//    }

//});

//class MyClass
//{
//    public int id;
//}

#endregion