using Hospital_OPD___Appointment_Management_System__HAMS_.Data;
using Hospital_OPD___Appointment_Management_System__HAMS_.Helpers;
using Hospital_OPD___Appointment_Management_System__HAMS_.Repositories;
using Hospital_OPD___Appointment_Management_System__HAMS_.Repositories.Interfaces;
using Hospital_OPD___Appointment_Management_System__HAMS_.Services;
using Hospital_OPD___Appointment_Management_System__HAMS_.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var addssms = builder.Configuration.GetConnectionString("dbcs");
builder.Services.AddDbContext<ApplicationDBcontext>(options => options.UseSqlServer(addssms));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Automapping (early, global)
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddAutoMapper(typeof(MappingProfile));
//builder.Services.AddAutoMapper(typeof(Program));


//DI for Repositories and Services
//(1)For Doctor
builder.Services.AddScoped<IDoctorServices, DoctorService>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
//(2)For Patient
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IPatientServices, PatientService>();
//(3)For Department 
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
//(4)For Appointment
builder.Services.AddScoped<IAppointmentRepository,  AppointmentRepository>();
builder.Services.AddScoped<IAppointmentServices, AppointmentServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
