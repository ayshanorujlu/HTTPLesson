using HTTP;
using System.Text.Json;
#region HttpPost



//HttpClient client = new();
//Post post = new()
//{
//    Id = 1,
//    UserId = 1,
//    Title = "Test",
//    Body = "Test",
//};

//Uri uri = new Uri(@"https://jsonplaceholder.typicode.com/posts");

//string json = JsonSerializer.Serialize(post);

//StringContent stringContent= new StringContent(json);

//HttpResponseMessage httpResponse = await client.PostAsync(uri, stringContent);

//Console.WriteLine((int)httpResponse.StatusCode);

//var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

//Console.WriteLine(jsonResponse);

#endregion


#region HttpDelete
//HttpClient client = new();

//Post post = new()
//{
//    UserId = 1,
//    Id = 1,
//    Title = "Test",
//    Body = "Test",
//};

//Uri uri = new Uri(@"https://jsonplaceholder.typicode.com/posts/1");

//string json = JsonSerializer.Serialize(post);

//StringContent stringContent = new(json);

//HttpResponseMessage httpResponse = await client.DeleteAsync(uri);

//Console.WriteLine((int)httpResponse.StatusCode);

//var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

//Console.WriteLine(jsonResponse);
#endregion

#region HttpPut
//HttpClient client = new();

//Post post = new()
//{
//    UserId = 1,
//    Id = 1,
//    Title = "Test",
//    Body = "Test",
//};

//Uri uri = new Uri(@"https://jsonplaceholder.typicode.com/posts/1");

//string json = JsonSerializer.Serialize(post);

//StringContent stringContent = new(json);

//HttpResponseMessage httpResponse = await client.PutAsync(uri, stringContent);

//Console.WriteLine((int)httpResponse.StatusCode);

//var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

//Console.WriteLine(jsonResponse);
#endregion