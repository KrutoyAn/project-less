public class FightShip : BaseShip
{
    public override string Move(int distance)
    {
        double time = (double)distance / 2000;
        return string.Format("Пройдено км: {0} за время {1} ", distance, time);
    }

    public override string Fight()
    {
        return "Противник уничтожен!";
    }

    public override string ToString()
    {
        return "Боевой Корабль";
    }
}