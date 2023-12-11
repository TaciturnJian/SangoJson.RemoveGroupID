using System.Text;

foreach (var file in Directory.GetFiles(@"C:\Users\Sango\Downloads\duff3\test"))
{
    var builder = new StringBuilder();
    foreach (var line in File.ReadAllLines(file))
    {
        if (line.Contains("group_id")) continue;
        builder.AppendLine(line);
    }
    File.WriteAllText(file, builder.ToString());
}
