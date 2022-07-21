var videoGameNames = new List<string>()
{"Grand Theft Auto","Assassins Creed", "Ghost of Tsumashu", "Far Cry"};

var orderByNameLength = videoGameNames.OrderBy(name => name.Length).ToList();
orderByNameLength.ForEach(name => Console.WriteLine(name));

            