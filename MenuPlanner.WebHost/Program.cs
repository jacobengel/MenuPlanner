using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

using MenuPlanner.Domain;
using MenuPlanner.DynamoDb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddScoped<IDynamoDBContext, DynamoDBContext>();

builder.Services.AddScoped<IMapper<MenuPlanner.API.Models.Recipes.Ingredient, MenuPlanner.Domain.Models.Recipes.Ingredient>, MenuPlanner.WebHost.Mappers.IngredientMapper>();
builder.Services.AddScoped<IMapper<MenuPlanner.DynamoDb.Models.Recipes.Ingredient, MenuPlanner.Domain.Models.Recipes.Ingredient>, MenuPlanner.DynamoDb.Mappers.IngredientMapper>();

builder.Services.AddScoped<IMenuPlannerRepository<MenuPlanner.Domain.Models.Recipes.Ingredient>, MenuPlannerDynamoDBIngredientRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();