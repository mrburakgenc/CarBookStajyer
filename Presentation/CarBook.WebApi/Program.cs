using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//ABOUTS
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();

//BANNERS
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();

//BRANDS
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();