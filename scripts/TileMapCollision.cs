using Godot;

public partial class TileMapCollision : TileMapLayer
{	
	[Export]
	public int SourceId { get; set; } = 1;
	[Export]
	public Vector2I Tile { get; set; } = new(2, 0);

	public override void _Ready()
	{
		var filledTiles = GetUsedCells();
		foreach (var cell in filledTiles)
		{
			var neighbors = GetSurroundingCells(cell);
			foreach (var neighbor in neighbors)
			{
				if (GetCellSourceId(neighbor) != -1) continue;
				SetCell(neighbor, SourceId, Tile);				
			}
		}
	}
}
