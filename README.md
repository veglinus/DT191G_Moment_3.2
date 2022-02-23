# Moment 3.2 - Entity Framework (EF) Core

Run with: `dotnet run`

To migrate:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

To recreate controllers:
```
dotnet aspnet-codegenerator controller -name AlbumController -m Album -dc AlbumContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f

dotnet aspnet-codegenerator controller -name ArtistController -m Artist -dc AlbumContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f
```