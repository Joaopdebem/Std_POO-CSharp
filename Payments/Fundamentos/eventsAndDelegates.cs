/*using System;

namespace Payments
{
	// Delagates => Anonymous methods
	class Program {
		static void Main(string[] args)
		{
			var room = new Room(3);
			room.RoomSoldOutEvent += OnRoomSoldOut;
			room.ReserveSeat();
			room.ReserveSeat();
			room.ReserveSeat();
			room.ReserveSeat();			
		}

		static void OnRoomSoldOut(object sender, EventArgs e)
		{
			Console.WriteLine ("Esta sala está lotada!");
		}
	}

	public class Room
	{
		public Room (int seats)
		{
			Seats = seats;
			seatsInUse = 0;
		}
		private int seatsInUse = 0;
		public int Seats { get; set; }

		public void ReserveSeat()
		{
			seatsInUse++;
			if (seatsInUse > Seats){
				OnRoomSoldOut(EventArgs.Empty);
			}
			else
			{
				Console.WriteLine("Assento reservado.");
			}

		}

		public event EventHandler RoomSoldOutEvent;
		protected virtual void OnRoomSoldOut (EventArgs e)
		{
			EventHandler handle = RoomSoldOutEvent;
			handle?.Invoke(this,e);
		}

	}

}
*/