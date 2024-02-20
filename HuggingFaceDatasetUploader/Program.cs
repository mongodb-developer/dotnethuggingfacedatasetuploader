// See https://aka.ms/new-console-template for more information

using HuggingFaceDatasetUploader.Models;
using MongoDB.Driver;
using System.Text.Json;

string connectionString = "";
string databaseName = "sample_mflix";
string collectionName = "embedded_movies";
HttpClient httpClient = new HttpClient();
MongoClient mongoClient;
List<Movie> movies = new List<Movie>();

Console.WriteLine("Hello, Welcome to the Hugging Face Dataset Uploader!");
Console.WriteLine("Please enter your connection string");

connectionString = Console.ReadLine();

while(string.IsNullOrWhiteSpace(connectionString))
{
    Console.WriteLine("Please enter your connection string");
    connectionString = Console.ReadLine();
}

mongoClient = new MongoClient(connectionString);

Task.Run(async () =>
{
 await DownloadMoviesDataset();
 await UploadMoviesDataset();
});

Console.WriteLine("Press any key to exit...");
Console.Read();

async Task DownloadMoviesDataset()
{
    Console.WriteLine("Downloading Movies Dataset...");
    
    var response =
        await httpClient.GetAsync(
            "https://huggingface.co/datasets/AIatMongoDB/embedded_movies/resolve/main/sample_mflix.embedded_movies.json?download=true");
    string content = await response.Content.ReadAsStringAsync();
    movies = JsonSerializer.Deserialize < List<Movie>>(content);
}

async Task UploadMoviesDataset()
{
    Console.WriteLine("Uploading Movies Dataset...");
    var database = mongoClient.GetDatabase(databaseName);
    var collection = database.GetCollection<Movie>(collectionName);
    await collection.InsertManyAsync(movies);
    Console.WriteLine("Movies Dataset Uploaded Successfully!");
}