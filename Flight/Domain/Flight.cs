namespace Domain;

public class Flight
{
    private int RemainingSeat;
    private Dictionary<string, int> Passenger = new();

    public Flight(int seatCapacity)
    {
        RemainingSeat = seatCapacity;
    }

    public object? Book(string passengerName, int numberOfSeatToBook)
    {
        if (RemainingSeat > 0 && RemainingSeat - numberOfSeatToBook > 0)
        {
            Passenger.Add(passengerName, numberOfSeatToBook);
            RemainingSeat -= numberOfSeatToBook;
        }
        else
            return new OverBookingError();

        return null;
    }

    public int RemainingNumebrOfSeats()
    {
        return RemainingSeat;
    }
}

