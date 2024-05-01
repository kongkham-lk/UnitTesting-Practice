using FluentAssertions;
using Domain;

namespace FlightTester;

public class FlightSpecificationTest
{
    [Fact]
    public void BookingToReduceTheSeatNumbers()
    {
        //Given
        Flight flight = new(seatCapacity: 3);

        //When
        flight.Book("John", 1);

        //Then
        flight.RemainingNumebrOfSeats().Should().Be(2);
    }

    [Fact]
    public void AvoidsOverbooking()
    {
        //Given
        Flight flight = new(seatCapacity: 3);

        //When
        var error = flight.Book("Chris", 4);

        //Then
        error.Should().BeOfType<OverBookingError>();
    }
}
