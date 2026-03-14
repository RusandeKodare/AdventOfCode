namespace AdventOfCode01;

internal class Program
{
    static void Main(string[] args)
    {
        //var ui = new UI.UI();
        //var countAllZeroes = true;
        //var zeroCounter = new ZeroCounter();
        //var rotationApplier = new RotationApplier(ui, zeroCounter, countAllZeroes);

        //var x2025Day1Part1x = new x2025Day1x(rotationApplier);

        //x2025Day1Part1x.CalcuateAmountOfZeroes();

        //ui.Write(zeroCounter.GetZeroes());
        DoSomething();
    }
    //First attempt: 21898734247 (Success!)
    public static void DoSomething()
    {
        var input = "655-1102,2949-4331,885300-1098691,1867-2844,20-43,4382100-4484893,781681037-781860439,647601-734894,2-16,180-238,195135887-195258082,47-64,4392-6414,6470-10044,345-600,5353503564-5353567532,124142-198665,1151882036-1151931750,6666551471-6666743820,207368-302426,5457772-5654349,72969293-73018196,71-109,46428150-46507525,15955-26536,65620-107801,1255-1813,427058-455196,333968-391876,482446-514820,45504-61820,36235767-36468253,23249929-23312800,5210718-5346163,648632326-648673051,116-173,752508-837824";

        var something = input.Split(",");

        List<string> list = new List<string>();

        List<long> invalidIds = new ();

        var amountIfInvalidIds = 0;


        foreach (var thing in something)
        {
            var splitted = thing.Split("-");
            list.AddRange(splitted);
        }
        long startDigit = 0;
        long endDigit = 0;
        for (int i = 0; i < list.Count; i = i + 2)
        {
            var secondPlaceToCompare = i + 1;

            //for (int j = 1; j < list[i].Length;)
            //{
            startDigit = long.Parse(list[i]);
            endDigit = long.Parse(list[secondPlaceToCompare]);

            while (startDigit <= endDigit)
            {
                var digitToString = startDigit.ToString();
                if (digitToString.Length % 2 == 0)
                {
                    var half = digitToString.Length / 2;
                    var firstHalf = digitToString.Substring(0, half);
                    var otherHalf = digitToString.Substring(half);
                    if (firstHalf == otherHalf)
                    {
                        amountIfInvalidIds++;
                        invalidIds.Add(startDigit);
                    }
                        

                }
                //else
                //{
                //    var half = (digitToString.Length - 1) / 2;
                //    var firstHalf = digitToString.Substring(0, half).ToString();
                //    var otherHalf = digitToString.Substring((half + 1)).ToString();
                //    if (firstHalf == otherHalf)
                //    {
                //        amountIfInvalidIds++;
                //        invalidIds.Add(startDigit);
                //    }
                        

                //}

                startDigit++;
                //}
            }

        }

        long sum = 0;

        foreach (var invalidId in invalidIds)
        {
            sum = sum + invalidId;
        }
        Console.WriteLine(sum);
        Console.WriteLine(amountIfInvalidIds);
        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}


    }
}
