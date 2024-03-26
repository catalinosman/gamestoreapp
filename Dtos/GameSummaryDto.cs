namespace GameStore.Api.Dtos;

// records are immutable, the properties cannot change
public record class GameSummaryDto(
    int Id,
    string Name,
    string GenreId,
    decimal Price,
    DateOnly ReleaseDate);
