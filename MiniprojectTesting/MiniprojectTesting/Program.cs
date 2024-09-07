using MiniprojectTesting.Components;
using MiniprojectTesting.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register HttpClient with a base address
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://todo-api.bestcar.id/") // Set your API base address
});

// Register your services
builder.Services.AddScoped<TodoService>();
builder.Services.AddScoped<TodoDetailService>();
builder.Services.AddScoped<AuthenticationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
