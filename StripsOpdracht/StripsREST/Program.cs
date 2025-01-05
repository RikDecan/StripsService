using StripsBL.Interfaces;
using StripsBL.Models;
using StripsBL.Services;

using StripsDL.Repositories;
using StripsDL;




public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.



        builder.Services.AddDbContext<StripContext>();

        builder.Services.AddScoped<IStripRepository, StripRepository>();
        builder.Services.AddScoped<StripService>();

        //builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        //builder.Services.AddScoped<EquipmentService>();

        //builder.Services.AddScoped<IProgramRepository, ProgramRepository>();
        //builder.Services.AddScoped<ProgramRepository>();

        //builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
        //builder.Services.AddScoped<ReservationService>();

        //builder.Services.AddScoped<IRunningSessionRepository, RunningsSessionRepository>();
        //builder.Services.AddScoped<RunningSessionServices>();


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
    }
}