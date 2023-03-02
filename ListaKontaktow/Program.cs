using ListaKontaktow.Authentication;
using ListaKontaktow.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

//dodanie po³¹czenia do lokalnej bazy danych sqlite poprzez kontekst
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source = Kontakty.db");
});

//dodanie servisów obs³uguj¹cych dzia³ania na tabelach bazy danych
builder.Services.AddScoped<KontaktServices>();
builder.Services.AddScoped<KategoriaServices>();
builder.Services.AddScoped<PodkategoriaServices>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
