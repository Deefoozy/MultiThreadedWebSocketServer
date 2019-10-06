﻿using WebSocketTest.Interfaces;
using WebSocketTest.Models.Clients;

namespace WebSocketTest.Models.GameObjects
{
    internal class Player : GameObject
	{
		private int _score = 0;
		private int _playerNumber;
		private int _speed = 15;
		private Inputs _inputs = new Inputs();

		public Client ClientInfo { get; private set; }

		public Player(IVector2d position, IVector2d dimensions, IVector2d velocity) : base(position, dimensions, velocity) { }

		public Player(IPhysicsData phys) : base(phys) { }

		/// <summary>
		/// Binds ClientTcp to player
		/// </summary>
		/// <param name="passedClient"></param>
		/// <param name="passedPlayerNumber"></param>
		public void BindPlayer(Client passedClient, int passedPlayerNumber)
		{
			ClientInfo = passedClient;
			_playerNumber = passedPlayerNumber;
			Position.SetPosition(
				200,
				50 + 700 * (_playerNumber - 1)
			);
		}

		/// <summary>
		/// Moves player to the left
		/// </summary>
		public void MoveLeft()
		{
			Position.X -= _speed;
		}

		/// <summary>
		/// Moves player to the right
		/// </summary>
		public void MoveRight()
		{
			Position.X += _speed;
		}

		/// <summary>
		/// Gets player score
		/// </summary>
		/// <returns></returns>
		public int GetScore()
		{
			return _score;
		}
	}
}
