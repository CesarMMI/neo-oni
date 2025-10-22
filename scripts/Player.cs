using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public float Speed = 150.0f;

	public override void _PhysicsProcess(double delta)
	{
		var velocity = Velocity;

		var direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
		if (direction != Vector2.Zero)
		{
			velocity = direction * Speed;
		}
		else
		{
			velocity = Vector2.Zero;
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
