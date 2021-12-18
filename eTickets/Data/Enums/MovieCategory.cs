namespace eTickets.Data
{
    //By default, the first item of an enum has the value 0. The second has the value 1, and so on.
    public enum MovieCategory
    {
        //Enums are used when we know all possible values at compile time, such as choices on a menu, rounding modes, command line flags, etc
        Action = 1,
        Comedy,
        Drama,
        Documentary,
        Cartoon,
        Horror
    }
}
