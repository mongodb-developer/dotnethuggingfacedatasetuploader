using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace HuggingFaceDatasetUploader.Models;


public class Movie
{
    public string plot { get; set; }
    public string[] genres { get; set; }
    public int runtime { get; set; }
    public string[] cast { get; set; }
    public int num_mflix_comments { get; set; }
    public string poster { get; set; }
    public string title { get; set; }
    public string fullplot { get; set; }
    public string[] languages { get; set; }
    public string[] directors { get; set; }
    public string[] writers { get; set; }
    public Awards awards { get; set; }
    public Imdb imdb { get; set; }
    public string[] countries { get; set; }
    public string type { get; set; }
    public float[] plot_embedding { get; set; }
}

public class Awards
{
    public int wins { get; set; }
    public int nominations { get; set; }
    public string text { get; set; }
}

public class Imdb
{
    public float rating { get; set; }
    public int votes { get; set; }
    public int id { get; set; }
}
