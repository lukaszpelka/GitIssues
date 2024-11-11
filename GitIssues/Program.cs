using GitHubIssuesManager;
using IssuesManagerAbstract;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddSingleton<IIssuesManager, GitHubIssuesManager.GitHubIssuesManager>();
builder.Services.AddSingleton<IIssuesManager, GitLabIssuesManager.GitLabIssuesManager>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();