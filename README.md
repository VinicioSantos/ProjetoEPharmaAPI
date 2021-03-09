# ProjetoEPharmaAPI

Para rodar o projeto é necessário configurar a connectionString com uma instancia de banco sql server, basta alterar o Parametro server da Classe "CommonModel" e a ConnectionString no "appsettings.json"

Rodar os comandos de migration

```powershell
add-migration -Context CommonModel Initial
```

```powershell
Update-Database -Context CommonModel
```

Feito isso, banco será criado e migration aplicado, apenas iniciar aplicação no projeto de interface, abrirá a pagina do swagger com todos os serviços disponiveis