using MiniprojectTesting.Models;
using System.Net.Http.Json;

namespace MiniprojectTesting.Services
{
    public class TodoDetailService
    {
        private readonly HttpClient _httpClient;

        public TodoDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TodoDetailModel>> GetTodoDetailsAsync(string todoId)
        {
            return await _httpClient.GetFromJsonAsync<List<TodoDetailModel>>($"https://todo-api.bestcar.id/api/v1/todo/detail/{todoId}");
        }

        public async Task<TodoDetailModel> GetTodoDetailAsync(string todoDetailId)
        {
            return await _httpClient.GetFromJsonAsync<TodoDetailModel>($"https://todo-api.bestcar.id/api/v1/todo/detail/{todoDetailId}");
        }

        public async Task CreateTodoDetailAsync(TodoDetailModel todoDetail)
        {
            await _httpClient.PostAsJsonAsync($"https://todo-api.bestcar.id/api/v1/todo/detail", todoDetail);
        }

        public async Task UpdateTodoDetailAsync(TodoDetailModel todoDetail)
        {
            await _httpClient.PutAsJsonAsync($"https://todo-api.bestcar.id/api/v1/todo/detail", todoDetail);
        }

        public async Task DeleteTodoDetailAsync(string todoDetailId)
        {
            await _httpClient.DeleteAsync($"https://todo-api.bestcar.id/api/v1/todo/detail/?todoDetailId={todoDetailId}");
        }
    }
}
