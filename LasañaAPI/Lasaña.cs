namespace LasañaAPI;
public class Lasaña
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int actualMinutes)
    {
        int expectedMinutes = ExpectedMinutesInOven();
        return expectedMinutes - actualMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        int preparationTimePerLayer = 2;
        return numberOfLayers * preparationTimePerLayer;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
    {
        int preparationTime = PreparationTimeInMinutes(numberOfLayers);
        int expectedMinutesInOven = ExpectedMinutesInOven();
        return preparationTime + actualMinutesInOven;
    }
}
