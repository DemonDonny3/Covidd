using MassTransit;
using TwoPhaseCommitExercise.Contracts.Coordinator;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMassTransitHostedService();
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<>();

    x.UsingRabbitMq((context, rabbitConfigurator) =>
    {



        rabbitConfigurator.Host(
            "roedeer-01.rmq.cloudamqp.com",
            "vpeeygzh",
            credentials =>
            {
                credentials.Username("vpeeygzh");
                credentials.Password("");
            });

        rabbitConfigurator.ReceiveEndpoint("orders_create_client", e =>
        {
            e.Consumer<CreateClientEventConsumer>(context);
        });
    });

});

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
