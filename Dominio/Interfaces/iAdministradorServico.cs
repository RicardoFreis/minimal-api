using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Dominio.Interfaces;

public interface iAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
     Administrador? BuscaporId(int id);
    List<Administrador> Todos(int? pagina);
}