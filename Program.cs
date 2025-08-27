Point p1 = new Point();
Point p2 = new Point();

//user input for p1 x-axis and y
Console.WriteLine("Enter X for P1: ");
p1.Xcoordinate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y for P1: ");
p1.Ycoordinate = Convert.ToDouble(Console.ReadLine());

//samething for p2
Console.WriteLine("Enter X for P2: "); 
p2.Xcoordinate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y for P2: ");
p2.Ycoordinate = Convert.ToDouble(Console.ReadLine());


//determining whether p2>p1 or p2<p1 to output the location of the point 
if (p2.Xcoordinate > p1.Xcoordinate)
{
    Console.WriteLine("P2 is to the  right of P1");
}
else if (p2.Xcoordinate < p1.Xcoordinate)
{
    Console.WriteLine("P2 is to the left of P1");
}
else
{
    Console.WriteLine("P2 is on the same vertical axis as P1"); //in case if user inputs the same value for both point

}




class Point

{
    public double Xcoordinate   { get; set; }
    public double Ycoordinate { get; set; }

}

