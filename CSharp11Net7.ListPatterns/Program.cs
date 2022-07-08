// See https://aka.ms/new-console-template for more information


var dayNames = new[]
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

int counter = 20;

while (--counter > 0)
{
    dayNames = dayNames.OrderBy(i => Guid.NewGuid()).ToArray();

    // Joker: _, ..(length between 0 && --)
    string result = dayNames switch
    {
        [] => "Empty List",
        //[_] => "Single Item",
        ["Monday"] => "Only day is Monday", // length == 1 && [0] == "Monday"
        ["Monday", _] => "First day is Monday and length == 2",// length == 2 && [0] == "Monday"
                                                               //[string firstDay, .. string[] rest] => $"First day is {firstDay} with rest {string.Join(',', rest)}",

        // length >= 3 && [^2] == "Saturday" && [^1] == "Sunday"
        [_, .., "Saturday", "Sunday"] => "The perfect weekend order",

        [_, _, "Wednesday", .., _] => "The 3rd day is Wednesday",

        ["Monday", _, _, _,"Friday", _, _] => "The perfect weekday order",
        _ => "Default"
    };

    Console.WriteLine($"Result: {result}");
}








Console.ReadLine();