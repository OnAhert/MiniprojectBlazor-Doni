using MiniprojectTesting.Models;
using System.Net.Http.Json;

namespace MiniprojectTesting.Services
{
    public class TodoService
    {
        private readonly HttpClient _httpClient;

        public TodoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TodoModel>> GetTodosAsync(int pageNumber, int pageSize)
        {
            return await _httpClient.GetFromJsonAsync<List<TodoModel>>($"https://todo-api.bestcar.id/api/v1/todo?pageNumber={pageNumber}&pageSize={pageSize}") ?? new List<TodoModel>();
        }

        public async Task DeleteTodoAsync(string todoId)
        {
            var response = await _httpClient.DeleteAsync($"https://todo-api.bestcar.id/api/v1/todo/?todoId={todoId}");
            response.EnsureSuccessStatusCode();
        }

        public async Task AddTodoAsync(TodoModel todo)
        {
            var response = await _httpClient.PostAsJsonAsync("https://todo-api.bestcar.id/api/v1/todo", todo);
            response.EnsureSuccessStatusCode();
        }
    }
}
