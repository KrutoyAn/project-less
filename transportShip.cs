public class TransportShip : BaseShip
{
    public override string Move(int distance)
    {
        double time = (double)distance / 1000;
        return string.Format("Пройдено км: {0} за время {1} ", distance, time);
    }

    public override string Fight()
    {
        return "Транспортный корабль не может вступать в бой";
    }

    public override string ToString()
    {
        return "Транспортный корабль";
    }
}